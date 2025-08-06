using ColorGame.CustomControls;
using ColorGame.enums;
using ColorGame.Forms;
using ColorGame.Models;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Media;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace ColorGame
{

    public partial class GameForm : Form
    {

        // Constants
        private const int TIMER_INTERVAL = 16; // EVERY 16 MILLISECONDS CALL THE TICK WHICH IS WHERE FALLING, ROTATING DICES
        private const float GRAVITY = 1.3f; // YOU KNOW THIS :>
        private const float BOUNCE_DAMPENING = 0.4f; // CALCULATE FOR THE BOUNCE DICE
        private const float FRICTION = 0.95f;
        private const float AIR_RESISTANCE = 0.99f;
        private const int FLOOR_Y = 440;
        private int JACKPOT_PRIZE = 1000000; // IF YOU WIN YOU WIN!
        private const double LUCKY_GAUGE_MULTIPLIER = 0.25; // ADDING 25% CHANCE IF THE LUCKY GAUGE IS FULL
        private const int INITIAL_BALANCE = 1000;

        // POSITION AND DIMENSION OF THE LANDING ZONE
        private const int LANDING_ZONE_X = 0;
        private const int LANDING_ZONE_Y = 0;
        private const int LANDING_ZONE_WIDTH = 370;
        private const int LANDING_ZONE_HEIGHT = 500;
        private const float WALL_BOUNCE_FACTOR = 0.3f;

        // Game state
        public int balance = INITIAL_BALANCE;
        private bool isGameInitialized = true;
        private int baitAttempt = 3;
        private bool baitActive = false;
        private bool allLanded = false;
        private bool isRolling = false;
        private const int BAIT_CHANCE = 25; // IF YOU ARE NEW, BAIT CHANCE WILL ACTIVE TO MAKE YOU BROKE PERSON $_$
        private const int DICE_CHANCE = 5;
        private double PRIZE_MULTIPLIER = 1.0;
        private int MAX_DICES = 3;
        public GameModeEnum gameMode = GameModeEnum.Classic;

        // Game objects
        private Bitmap cachedBackground;
        private readonly List<Cube> cubes = new List<Cube>();
        private readonly Random rand = new Random();
        private string[] slotColors = { "Red", "Green", "Blue", "Yellow", "Orange", "Pink" }; // THIS IS THE COLOR OF DICES
        //private readonly Dictionary<string, Image> colorImages = new Dictionary<string, Image>(); // THIS IS WHERE COLOR DICES STORES. IT USED TO CHANCE THE DICES WHILE FALLING & ROTATING
        public readonly Dictionary<string, int> colorBets = new Dictionary<string, int>();

        // UI Controls
        #region Game Statistics
        public CustomLabel labelGameStatistics = new CustomLabel();
        public CustomLabel labelTotalPlayed = new CustomLabel();
        public CustomLabel labelTotalWins = new CustomLabel();
        public CustomLabel labelTotalLoses = new CustomLabel();
        public CustomLabel labelBiggestWins = new CustomLabel();

        public CustomLabel labelTotalPlayedValue = new CustomLabel();
        public CustomLabel labelTotalWinsValue = new CustomLabel();
        public CustomLabel labelTotalLosesValue = new CustomLabel();
        public CustomLabel labelBiggestWinsValue = new CustomLabel();
        #endregion

        public CustomPanel landingZone; // THIS IS THE INVISIBLE WALL
        public PictureBox? boardMsg = null;
        public CustomLabel? boardMsgText = null;
        public Panel betHistoryInner = new Panel();
        public CustomLabel betHistoryInnerText = new CustomLabel();

        public GameForm()
        {
            MinimizeBox = false;
            MaximizeBox = false;
            InitializeComponent();
            DoubleBuffered = true;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            System.Diagnostics.Debug.WriteLine($"ON LOAD!");

            string basePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "");

            // Load and cache background
            cachedBackground = new Bitmap($"{Utils.BASE_DIRECTORY}\\Images\\Background.png");

            InitializeGame();
        }

        protected override void OnPaintBackground(PaintEventArgs e)
        {
            if (cachedBackground != null)
            {
                e.Graphics.DrawImage(cachedBackground, 0, 0, ClientSize.Width, ClientSize.Height);
            }
        }

        private void InitializeGame()
        {
            try
            {

                // Setup UI
                msgUserControl.Parent = this;

                board.SendToBack();

                btnLever.Parent = this;

                labelCurrentBalance.Text = balance.ToString("N0");
                labelPrizeMultiplier.Text = $"{PRIZE_MULTIPLIER.ToString("f")} Multiplier";

                var boardHeader = new CustomPictureBox();
                boardHeader.GlowSize = 0;
                boardHeader.Image = Utils.LoadImage("IDK_1.png");
                boardHeader.SizeMode = PictureBoxSizeMode.StretchImage;
                boardHeader.Size = new Size(304, 57);
                boardHeader.Location = new Point(150, 35);
                boardHeader.Parent = board;
                boardHeader.BringToFront();
                board.Controls.Add(boardHeader);

                betHistoryInner.AutoSize = true;
                betHistoryInner.Size = new Size(pictureBoxBetHistory.Width, pictureBoxBetHistory.Height - 5);
                betHistoryInner.Location = new Point(0, 5);

                pictureBoxBetHistory.Controls.Add(betHistoryInnerText = Utils.CreateCustomLabel(11F, new Point((pictureBoxBetHistory.Width - betHistoryInnerText.Width) / 2, (pictureBoxBetHistory.Height - betHistoryInnerText.Height) / 2), "No Bet History", 5));
                pictureBoxBetHistory.Controls.Add(betHistoryInner);
                pictureBoxBetHistory.MouseWheel += pictureBoxBetHistory_MouseWheel;

                SetupTransparentControls();
                InitializeCustomLabels();
                CreateLandingZone();

                landingZone.BringToFront();

                boardMsg = new PictureBox();
                boardMsg.Image = Utils.LoadImage("PopMsg.png");
                boardMsg.BackColor = Color.Transparent;
                boardMsg.SizeMode = PictureBoxSizeMode.StretchImage;
                boardMsg.Size = new Size(305, 60);
                boardMsg.Location = new Point(40, 100);

                boardMsgText = Utils.CreateCustomLabel(11F, new Point(30, 8), "Please select your color!", 8, boardMsg);
                boardMsgText.AutoSize = false;
                boardMsgText.Size = new Size(250, 40);
                boardMsg.Controls.Add(boardMsgText);

                landingZone.Controls.Add(boardMsg);

                // Load game assets
                CreateColorCubes();

                // Configure timer
                gameTimer.Interval = TIMER_INTERVAL;
            }
            catch (Exception ex)
            {
                isGameInitialized = false;
                MessageBox.Show($"Error initializing game: {ex.Message}", "Initialization Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void SetBalance(int amount)
        {
            labelCurrentBalance.Text = amount.ToString("N0");
        }

        private void CreateLandingZone()
        {
            landingZone = new CustomPanel
            {
                Location = new Point(115, 30),
                Size = new Size(LANDING_ZONE_WIDTH, LANDING_ZONE_HEIGHT),
                BackColor = Color.Transparent,
                BorderStyle = BorderStyle.None,
                Opacity = 0,
                BorderThickness = 0,
                Parent = board
            };

            board.Controls.Add(landingZone);
            board.SendToBack();
        }

        private void SetupTransparentControls()
        {
            btnLever.Parent = this;
            btnLever.BackColor = Color.Transparent;

            pictureBoxBack.BackColor = Color.Transparent;
            pictureBoxBack.Parent = this;

            pictureBoxJackbot.Parent = this;
            pictureBoxJackbot.BackColor = Color.Transparent;
        }

        // SET NEW GRADIENT COLOR FOR THE COLOR BETS
        private void InitializeColorBets()
        {
            if (gameMode == GameModeEnum.Classic)
            {
                colorRedBet.SetGradientColor(this, "Red", Color.FromArgb(255, 128, 128), Color.FromArgb(192, 0, 0));
                colorGreenBet.SetGradientColor(this, "Green", Color.FromArgb(128, 255, 128), Color.Lime);
                colorBlueBet.SetGradientColor(this, "Blue", Color.FromArgb(128, 128, 255), Color.Blue);
                colorYellowBet.SetGradientColor(this, "Yellow", Color.FromArgb(255, 255, 192), Color.Yellow);
                colorOrangeBet.SetGradientColor(this, "Orange", Color.FromArgb(255, 224, 192), Color.FromArgb(255, 128, 0));
                colorPinkBet.SetGradientColor(this, "Pink", Color.FromArgb(255, 192, 255), Color.Fuchsia);

                colorRedBet.Location = new Point(878, 265);
                colorGreenBet.Location = new Point(1046, 265);
                colorBlueBet.Location = new Point(1214, 265);
                colorYellowBet.Location = new Point(878, 399);
                colorOrangeBet.Location = new Point(1046, 399);
                colorPinkBet.Location = new Point(1214, 399);
            }

            if (gameMode == GameModeEnum.Challenger)
            {
                colorRedBet.SetGradientColor(this, "Red", Color.FromArgb(255, 128, 128), Color.FromArgb(192, 0, 0));
                colorGreenBet.SetGradientColor(this, "Green", Color.FromArgb(128, 255, 128), Color.Lime);
                colorBlueBet.SetGradientColor(this, "Blue", Color.FromArgb(128, 128, 255), Color.Blue);
                colorYellowBet.SetGradientColor(this, "Yellow", Color.FromArgb(255, 255, 192), Color.Yellow);
                colorOrangeBet.SetGradientColor(this, "Orange", Color.FromArgb(255, 224, 192), Color.FromArgb(255, 128, 0));
                colorPinkBet.SetGradientColor(this, "Pink", Color.FromArgb(255, 192, 255), Color.Fuchsia);
                colorPurpleBet.SetGradientColor(this, "Purple", Color.BlueViolet, Color.MediumPurple);
                colorCyanBet.SetGradientColor(this, "Cyan", Color.Cyan, Color.FromArgb(192, 255, 255));
                colorBrownBet.SetGradientColor(this, "Brown", Color.SaddleBrown, Color.Sienna);

                colorRedBet.Location = new Point(878, 265);
                colorGreenBet.Location = new Point(1046, 265);
                colorBlueBet.Location = new Point(1214, 265);
                colorYellowBet.Location = new Point(878, 353);
                colorOrangeBet.Location = new Point(1046, 353);
                colorPinkBet.Location = new Point(1214, 353);
                colorPurpleBet.Location = new Point(878, 441);
                colorCyanBet.Location = new Point(1046, 441);
                colorBrownBet.Location = new Point(1214, 441);
            }

            if (gameMode == GameModeEnum.Risks)
            {
                colorRedBet.SetGradientColor(this, "Red", Color.FromArgb(255, 128, 128), Color.FromArgb(192, 0, 0));
                colorGreenBet.SetGradientColor(this, "Green", Color.FromArgb(128, 255, 128), Color.Lime);
                colorBlueBet.SetGradientColor(this, "Blue", Color.FromArgb(128, 128, 255), Color.Blue);
                colorYellowBet.SetGradientColor(this, "Yellow", Color.FromArgb(255, 255, 192), Color.Yellow);
                colorOrangeBet.SetGradientColor(this, "Orange", Color.FromArgb(255, 224, 192), Color.FromArgb(255, 128, 0));
                colorPinkBet.SetGradientColor(this, "Pink", Color.FromArgb(255, 192, 255), Color.Fuchsia);
                colorPurpleBet.SetGradientColor(this, "Purple", Color.BlueViolet, Color.MediumPurple);
                colorCyanBet.SetGradientColor(this, "Cyan", Color.Cyan, Color.FromArgb(192, 255, 255));
                colorBrownBet.SetGradientColor(this, "Brown", Color.SaddleBrown, Color.Sienna);
                colorBlackBet.SetGradientColor(this, "Black", Color.Black, Color.FromArgb(26, 26, 26));
                colorWhiteBet.SetGradientColor(this, "White", Color.White, Color.WhiteSmoke);
                colorGrayBet.SetGradientColor(this, "Gray", Color.Gray, Color.DarkGray);

                colorRedBet.Location = new Point(878, 265);
                colorGreenBet.Location = new Point(1004, 265);
                colorBlueBet.Location = new Point(1130, 265);
                colorYellowBet.Location = new Point(1256, 265);
                colorOrangeBet.Location = new Point(878, 353);
                colorPinkBet.Location = new Point(1004, 353);
                colorPurpleBet.Location = new Point(1130, 353);
                colorCyanBet.Location = new Point(1256, 353);
                colorBrownBet.Location = new Point(878, 441);
                colorBlackBet.Location = new Point(1004, 441);
                colorWhiteBet.Location = new Point(1130, 441);
                colorGrayBet.Location = new Point(1256, 441);
            }
        }

        private void InitializeCustomLabels()
        {
            // GAME STATISTICS
            picuteBoxGameStatistics.Controls.Add(labelGameStatistics = Utils.CreateCustomLabel(14F, new Point(10, 10), "Game Statistics", 8));
            picuteBoxGameStatistics.Controls.Add(labelTotalPlayed = Utils.CreateCustomLabel(11F, new Point(10, 60), "Total Played", 8));
            picuteBoxGameStatistics.Controls.Add(labelTotalWins = Utils.CreateCustomLabel(11F, new Point(10, 90), "Total Wins", 8));
            picuteBoxGameStatistics.Controls.Add(labelTotalLoses = Utils.CreateCustomLabel(11F, new Point(10, 120), "Total Loses", 8));
            picuteBoxGameStatistics.Controls.Add(labelBiggestWins = Utils.CreateCustomLabel(11F, new Point(10, 150), "Biggest Wins", 8));
            picuteBoxGameStatistics.Controls.Add(labelTotalPlayedValue = Utils.CreateCustomLabel(11F, new Point(220, 60), User.Instance.TotalPlayed.ToString(), 8));
            picuteBoxGameStatistics.Controls.Add(labelTotalWinsValue = Utils.CreateCustomLabel(11F, new Point(220, 90), User.Instance.TotalWins.ToString(), 8));
            picuteBoxGameStatistics.Controls.Add(labelTotalLosesValue = Utils.CreateCustomLabel(11F, new Point(220, 120), User.Instance.TotalLoses.ToString(), 8));
            picuteBoxGameStatistics.Controls.Add(labelBiggestWinsValue = Utils.CreateCustomLabel(11F, new Point(220, 150), User.Instance.BiggestWins.ToString(), 5));

            pictureBoxJackbot.Controls.Add(Utils.CreateCustomLabel(14.25F, new Point(180, 100), JACKPOT_PRIZE.ToString("N0"), 5, pictureBoxJackbot));
        }

        private void CreateColorCubes()
        {
            for (int i = 0; i < MAX_DICES; i++)
            {
                int startX = LANDING_ZONE_X + (LANDING_ZONE_WIDTH / 4) + (i * 85);
                int startY = LANDING_ZONE_Y + 20;

                var pictureBox = new PictureBox
                {
                    Size = new Size(50, 50),
                    BackColor = Color.Transparent,
                    Location = new Point(startX, startY),
                    SizeMode = PictureBoxSizeMode.StretchImage
                };
                Controls.Add(pictureBox);
                pictureBox.BringToFront();
                pictureBox.Parent = landingZone;

                var cube = new Cube
                {
                    CubeBox = pictureBox,
                    PosX = startX,
                    PosY = startY,
                    VelocityY = 0,
                    VelocityX = 0,
                    Rotation = 0,
                    HasLanded = false,
                    IsSpecial = false,
                    FinalColor = null,
                    AngularVelocity = rand.Next(15, 100)
                };

                cube.Collider = new CubeCollider(cube, startX, startY, pictureBox.Width, pictureBox.Height);
                cubes.Add(cube);
            }

            ResetCubes();
        }

        private Image GetRandomColorImage() => Utils.LoadImage($"{slotColors[rand.Next(slotColors.Length)]}.png");

        private Image RotateImage(Image img, float angle)
        {
            Bitmap rotated = new Bitmap(img.Width, img.Height);
            using (Graphics g = Graphics.FromImage(rotated))
            {
                g.Clear(Color.Transparent);
                g.InterpolationMode = InterpolationMode.HighQualityBicubic;
                g.SmoothingMode = SmoothingMode.AntiAlias;

                g.TranslateTransform(img.Width / 2f, img.Height / 2f);
                g.RotateTransform(angle);
                g.TranslateTransform(-img.Width / 2f, -img.Height / 2f);
                g.DrawImage(img, Point.Empty);
            }
            return rotated;
        }

        private void ResetCubes()
        {
            for (int i = 0; i < cubes.Count; i++)
            {
                var cube = cubes[i];
                cube.PosX = LANDING_ZONE_X + (LANDING_ZONE_WIDTH / 4) + (i * 85);
                cube.PosY = LANDING_ZONE_Y + 20;
                cube.VelocityY = 0;
                cube.VelocityX = (float)(rand.NextDouble() * 4 - 2);
                cube.Rotation = 0;
                cube.HasLanded = false;
                cube.FinalColor = null;
                cube.AngularVelocity = rand.Next(5, 15);
                cube.CubeBox.Location = new Point((int)cube.PosX, (int)cube.PosY);
                cube.CubeBox.Image = Utils.LoadImage($"{slotColors[rand.Next(slotColors.Length)]}.png");
                cube.Collider.UpdatePosition(cube.PosX, cube.PosY);
                cube.Chance = 0;
            }
        }

        private void gameTimer_Tick(object sender, EventArgs e)
        {
            if (!isGameInitialized) return;

            allLanded = true;

            int roll = rand.Next(0, 100);
            var bettedColors = colorBets.Keys.ToList();
            var unbettedColors = slotColors.Except(bettedColors).ToList();

            // Check collisions
            for (int i = 0; i < cubes.Count; i++)
            {
                var cube = cubes[i];
                if (!cube.HasLanded)
                {
                    UpdateCubePhysics(cube);
                    CheckWallCollisions(cube); // Check landing zone boundaries
                    cube.Collider.UpdatePosition(cube.PosX, cube.PosY);

                    // Check floor collision
                    if (cube.PosY + cube.CubeBox.Height >= FLOOR_Y)
                    {
                        HandleFloorCollision(cube, roll, bettedColors, unbettedColors);
                    }

                    // Check cube-to-cube collisions
                    for (int j = i + 1; j < cubes.Count; j++)
                    {
                        var other = cubes[j];
                        if (!other.HasLanded && cube.Collider.Intersects(other.Collider))
                        {
                            cube.Collider.HandleCollision(other.Collider);
                        }
                    }

                    // Update visual representation
                    cube.CubeBox.Location = new Point((int)cube.PosX, (int)cube.PosY);
                    cube.Rotation += cube.AngularVelocity;
                    cube.CubeBox.Image = cube.HasLanded ? Utils.LoadImage($"{cube.FinalColor}.png") : RotateImage(GetRandomColorImage(), cube.Rotation);

                    allLanded = false;
                }
            }

            if (allLanded)
            {

                // CANNOT JACKPOT IF BAIT OR LUCKY GAUGE IS ACTIVE
                if (IsSameColors() && (baitActive || verticalProgressBar.Progress >= 100))
                {
                    System.Diagnostics.Debug.WriteLine($"ANTI-JACKPOT TRIGGERED!");
                    RandomizeCubes();
                }

                gameTimer.Stop();

                btnLever.Enabled = true;

                board.Image = Utils.LoadImage("Board_Idle.png");

                ProcessGameResults();
            }
        }

        private void AddBetHistory(int totalGain)
        {
            var betListItem = new BetHistoryListItem();
            betListItem.Location = new Point(3, betHistoryInner.Controls.Count * betListItem.Height + 5);
            betListItem.Init(cubes, betHistoryInner.Controls.Count, totalGain);
            betHistoryInner.Controls.Add(betListItem);
            betHistoryInner.Controls.SetChildIndex(betListItem, 0);
            betHistoryInnerText.Visible = betHistoryInner.Controls.Count < 1;

            int y = 0;
            foreach (Control ctrl in betHistoryInner.Controls)
            {
                ctrl.Location = new Point(3, y);
                y += ctrl.Height + 5;
            }
        }

        private void RandomizeCubes()
        {
            foreach (var cube in cubes)
            {
                var randomColor = slotColors[rand.Next(slotColors.Length)];
                cube.FinalColor = randomColor;
                cube.CubeBox.Image = Utils.LoadImage($"{randomColor}.png");
            }
        }

        private void CheckWallCollisions(Cube cube)
        {
            // Left wall collision
            if (cube.PosX < LANDING_ZONE_X)
            {
                cube.PosX = LANDING_ZONE_X;
                cube.VelocityX = -cube.VelocityX * WALL_BOUNCE_FACTOR;
            }
            // Right wall collision
            else if (cube.PosX + cube.CubeBox.Width > LANDING_ZONE_X + LANDING_ZONE_WIDTH)
            {
                cube.PosX = LANDING_ZONE_X + LANDING_ZONE_WIDTH - cube.CubeBox.Width;
                cube.VelocityX = -cube.VelocityX * WALL_BOUNCE_FACTOR;
            }

            // Top wall collision
            if (cube.PosY < LANDING_ZONE_Y)
            {
                cube.PosY = LANDING_ZONE_Y;
                cube.VelocityY = -cube.VelocityY * WALL_BOUNCE_FACTOR;
            }
        }

        private void UpdateCubePhysics(Cube cube)
        {
            // Apply gravity
            cube.VelocityY += GRAVITY;

            // Add some randomness during fall
            if (cube.VelocityY > 4f)
            {
                cube.VelocityX += (float)(rand.NextDouble() - 0.5) * 0.5f;
            }

            // Apply air resistance
            cube.VelocityX *= AIR_RESISTANCE;
            cube.VelocityY *= AIR_RESISTANCE;

            // Update position
            cube.PosX += cube.VelocityX;
            cube.PosY += cube.VelocityY;
        }

        private void HandleFloorCollision(Cube cube, int roll, List<string> bettedColors, List<string> unbettedColors)
        {
            // Bounce if velocity is high enough
            if (Math.Abs(cube.VelocityY) > 1.5f)
            {
                cube.VelocityY = -cube.VelocityY * BOUNCE_DAMPENING;
                cube.VelocityX *= FRICTION;
                cube.PosY = FLOOR_Y - cube.CubeBox.Height;
            }
            else // Land if velocity is low and select the final color and evaluate the chance
            {
                cube.VelocityY = 0;
                cube.VelocityX = 0;
                cube.PosY = FLOOR_Y - cube.CubeBox.Height;
                cube.HasLanded = true;
                cube.Rotation = 0;

                var chance = DICE_CHANCE;
                var isLuckyGaugeFull = verticalProgressBar.Progress >= 100;

                if (isLuckyGaugeFull)
                {
                    chance += (int)(LUCKY_GAUGE_MULTIPLIER * 100);
                    verticalProgressBar.Progress = 0;
                }
                else if (baitActive)
                {
                    chance += BAIT_CHANCE;
                }

                chance = Math.Min(chance, 100);

                cube.Chance = chance;
                cube.FinalColor = DetermineFinalColor(roll, chance, bettedColors, unbettedColors);
            }
        }

        // Check if all cubes have the same color
        private bool IsSameColors() => cubes.Count > 1 && cubes.All(x => x.HasLanded && x.FinalColor == cubes[0].FinalColor);

        private string DetermineFinalColor(int roll, int chance, List<string> bettedColors, List<string> unbettedColors)
        {
            if (colorBets.Count > 0 && roll < chance)
            {
                var selectedColor = bettedColors[rand.Next(bettedColors.Count)];
                System.Diagnostics.Debug.WriteLine($"BETTED COLOR: {selectedColor}");
                return selectedColor;
            }

            // 80% chance to land on unbetted colors if available
            if (rand.Next(0, 100) < 80 && unbettedColors.Count > 0)
            {
                var selectedColor = unbettedColors[rand.Next(unbettedColors.Count)];
                System.Diagnostics.Debug.WriteLine($"UNBETTED COLOR: {selectedColor}");
                return selectedColor;
            }

            // Checking if the player is betted if not use the random select using the slots colors length
            return bettedColors.Count > 0 ? bettedColors[rand.Next(bettedColors.Count)] : slotColors[rand.Next(slotColors.Length)];
        }

        private void ProcessGameResults()
        {
            bool hasWon = false;
            int resultBetAmount = 0;

            StringBuilder result = new StringBuilder("Result:\n");

#if DEBUG

            System.Diagnostics.Debug.WriteLine($"===============================");

            result.AppendLine($"BAIT: {baitActive}");
            result.AppendLine($"LUCKY GAUGE: {verticalProgressBar.Progress >= 100}");

#endif

            var colorUserControls = Controls.OfType<ColorUserControl>();

            foreach (var cube in cubes)
            {
                if (colorBets.ContainsKey(cube.FinalColor))
                {
                    var colorUserControl = colorUserControls.FirstOrDefault(c => c.Name == cube.FinalColor);

                    if (colorUserControl != null)
                    {
                        int winnings = (int)(colorUserControl.betAmount * PRIZE_MULTIPLIER);
                        resultBetAmount += winnings;
                        balance += winnings;
                    }

                    hasWon = true;
#if DEBUG
                    result.AppendLine($"✅ Cube {cube.FinalColor}, {cube.Chance}");
#else
                    result.AppendLine($"✅ Cube {cube.FinalColor}");
#endif
                }
                else
                {
#if DEBUG
                    result.AppendLine($"❌ Cube {cube.FinalColor}, {cube.Chance}");
#else
                    result.AppendLine($"❌ Cube {cube.FinalColor}");
#endif
                }
            }

            msgUserControl.Show();
            msgUserControl.SetMsg(hasWon ? $"YOU WON {resultBetAmount.ToString("N0")}" : "YOU LOSE!");
            labelCurrentBalance.Text = balance.ToString("N0");
            resultLabel.Text = result.ToString();
            verticalProgressBar.Progress += 10;

            labelTotalPlayedValue.Text = (User.Instance.TotalPlayed += 1).ToString();
            labelTotalPlayedValue.Location = new Point(CalculateLeftAlignXPosition(labelTotalPlayedValue), labelTotalPlayedValue.Location.Y);

            if (User.Instance.BiggestWins < resultBetAmount)
            {
                User.Instance.BiggestWins = resultBetAmount;
                labelBiggestWinsValue.Text = User.Instance.BiggestWins.ToString("N0");
                labelBiggestWinsValue.Location = new Point(CalculateLeftAlignXPosition(labelBiggestWinsValue), labelBiggestWinsValue.Location.Y);
            }

            if (resultBetAmount > 0)
            {
                labelTotalWinsValue.Text = (User.Instance.TotalWins += 1).ToString();
                labelTotalWinsValue.Location = new Point(CalculateLeftAlignXPosition(labelTotalWinsValue), labelTotalWinsValue.Location.Y);

                Utils.PlayCoinSound();
            }
            else
            {
                foreach (var colorBet in colorBets)
                {
                    if (cubes.Any(c => c.FinalColor != colorBet.Key))
                    {
                        resultBetAmount -= colorBet.Value;
                    }
                }

                labelTotalLosesValue.Text = (User.Instance.TotalLoses += 1).ToString();
                labelTotalLosesValue.Location = new Point(CalculateLeftAlignXPosition(labelTotalLosesValue), labelTotalLosesValue.Location.Y);
            }

            isRolling = false;

            ResetColorBets();
            AddBetHistory(resultBetAmount);
        }

        private int CalculateLeftAlignXPosition(CustomLabel label)
        {
            return 220 - TextRenderer.MeasureText(label.Text, label.Font).Width + 17;
        }

        private void ResetColorBets()
        {
            foreach (var control in Controls.OfType<ColorUserControl>())
            {
                control.Reset();
            }
            colorBets.Clear();
        }

        private void btnLever_Click(object sender, EventArgs e)
        {
            Utils.PlayButtonSound();

            if (isRolling)
            {
                msgUserControl.Show();
                msgUserControl.SetMsg("Action too quickly! CHILL BRO!");
                return;
            }

            if (!isGameInitialized)
            {
                MessageBox.Show("Unable to start the game due to initialization errors.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (colorBets.Count < 1)
            {
                MessageBox.Show("Please place at least 1 bet before rolling.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (baitAttempt > 0)
            {
                baitActive = true;
                baitAttempt--;
                labelBaitAttempt.Text = $"Bait: {baitAttempt}";
            }
            else
            {
                baitActive = false;
            }

            isRolling = true;

            boardMsg.Visible = false;
            btnLever.Enabled = false;

            board.Image = Utils.LoadImage("Board_Play.png");

            ResetCubes();
            resultLabel.Text = "Rolling...";
            gameTimer.Start();
        }

        private string[] GetSlotColorByMode(GameModeEnum gameMode)
        {
            return gameMode switch
            {
                GameModeEnum.Classic => new string[] { "Red", "Green", "Blue", "Yellow", "Orange", "Pink" },
                GameModeEnum.Challenger => new string[] { "Red", "Green", "Blue", "Yellow", "Orange", "Pink", "Purple", "Cyan", "Brown" },
                GameModeEnum.Risks => new string[] { "Red", "Green", "Blue", "Yellow", "Orange", "Pink", "Purple", "Cyan", "Brown", "Black", "White", "Gray" }, // Example for Risks mode
            };
        }

        private void btnLever_MouseEnter(object sender, EventArgs e)
        {
            btnLever.Cursor = Cursors.Hand;
        }

        private void btnLever_MouseLeave(object sender, EventArgs e)
        {
            btnLever.Cursor = Cursors.Default;
        }

        public DialogBetForm? ModalBet(int amount = 0)
        {
            try
            {
                var modal = new DialogBetForm();

                var overlay = Utils.OverlayForm(this);

                overlay.Show();
                modal.ShowInTaskbar = false;
                modal.Init(balance, amount);
                modal.StartPosition = FormStartPosition.CenterParent;
                modal.ShowDialog(this);

                overlay.Close();

                return modal;
            }
            catch (Exception)
            {

            }

            return null;
        }

        private void GameForm_Shown(object sender, EventArgs e)
        {
            System.Diagnostics.Debug.WriteLine($"GAME FORM SHOW!");
        }

        private void pictureBoxBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            new MainForm().ShowDialog();
        }

        private void pictureBoxBack_MouseEnter(object sender, EventArgs e) => Cursor = Cursors.Hand;
        private void pictureBoxBack_MouseLeave(object sender, EventArgs e) => Cursor = Cursors.Default;

        private void pictureBoxBetHistory_MouseWheel(object sender, MouseEventArgs e)
        {
            int scrollAmount = 30; // Increase scroll step for better responsiveness
            int newY = betHistoryInner.Location.Y + (e.Delta > 0 ? scrollAmount : -scrollAmount);

            // Clamp to keep content within view
            int maxY = 0;
            int minY = pictureBoxBetHistory.Height - betHistoryInner.Height;
            if (minY > 0) minY = 0;

            newY = Math.Min(maxY, Math.Max(minY, newY));

            if (newY != betHistoryInner.Location.Y)
            {
                betHistoryInner.Location = new Point(betHistoryInner.Location.X, newY);
                pictureBoxBetHistory.Invalidate(); // Force redraw
            }
        }

        #region Game Mode Selection

        private void ModeMouseClick(GameModeEnum mode, double multiplier, int maxDices)
        {
            Utils.PlayButtonSound();

            gameMode = mode;
            PRIZE_MULTIPLIER = multiplier;
            MAX_DICES = maxDices;
            slotColors = GetSlotColorByMode(gameMode);
            JACKPOT_PRIZE = (int)(1000000 * PRIZE_MULTIPLIER);

            mode1.Visible = false;
            mode2.Visible = false;
            mode3.Visible = false;

            //Task.Delay(1000).Wait();
            //InitializeGame();

            colorBets.Clear();

            InitializeColorBets();
            ChangeMode(true);
        }

        private void ChangeMode(bool visible)
        {
            pictureBoxChangeMode.Visible = visible;
            labelPrizeMultiplier.Visible = visible;
            pictureBoxCoins.Visible = visible;
            labelCurrentBalance.Visible = visible;
            resultLabel.Visible = visible;
            picuteBoxGameStatistics.Visible = visible;
            pictureBoxBetHistory.Visible = visible;
            board.Visible = visible;
            pictureBoxJackbot.Visible = visible;
            colorContainer.Visible = visible;
            verticalProgressBar.Visible = visible;
            btnLever.Visible = visible;
            labelBAIT.Visible = visible;
            labelBaitAttempt.Visible = visible;
            msgUserControl.Visible = visible;

            var colorUserControls = Controls.OfType<ColorUserControl>();

            foreach (var control in colorUserControls)
            {
                if (control.Visible)
                    control.Visible = visible;
            }
        }

        private void ModeMouseEnter(CustomPictureBox pictureBox)
        {
            pictureBox.GlowSize = 4;
            Cursor = Cursors.Hand;
        }

        private void ModeMouseLeave(CustomPictureBox pictureBox)
        {
            pictureBox.GlowSize = 1;
            Cursor = Cursors.Default;
        }

        private void mode1_MouseClick(object sender, MouseEventArgs e) => ModeMouseClick(GameModeEnum.Classic, 1.0, 3);
        private void mode1_MouseEnter(object sender, EventArgs e) => ModeMouseEnter(mode1);
        private void mode1_MouseLeave(object sender, EventArgs e) => ModeMouseLeave(mode1);
        private void mode2_MouseClick(object sender, MouseEventArgs e) => ModeMouseClick(GameModeEnum.Challenger, 2.0, 3);
        private void mode2_MouseEnter(object sender, EventArgs e) => ModeMouseEnter(mode2);
        private void mode2_MouseLeave(object sender, EventArgs e) => ModeMouseLeave(mode2);
        private void mode3_MouseClick(object sender, MouseEventArgs e) => ModeMouseClick(GameModeEnum.Risks, 3.5, 3);
        private void mode3_MouseEnter(object sender, EventArgs e) => ModeMouseEnter(mode3);
        private void mode3_MouseLeave(object sender, EventArgs e) => ModeMouseLeave(mode3);

        #endregion

        private void pictureBoxChangeMode_Click(object sender, EventArgs e)
        {
            mode1.Visible = true;
            mode2.Visible = true;
            mode3.Visible = true;

            ChangeMode(false);
        }

        private void pictureBoxChangeMode_MouseEnter(object sender, EventArgs e) => Cursor = Cursors.Hand;
        private void pictureBoxChangeMode_MouseLeave(object sender, EventArgs e) => Cursor = Cursors.Default;
    }
}