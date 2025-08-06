using ColorGame.enums;
using System.Drawing;

namespace ColorGame
{
    public partial class ColorUserControl : UserControl
    {

        public GameForm? rootClass;
        public bool hasBet = false;
        public event EventHandler? BetPlaced;
        public int betAmount = 0;
        private bool isActive = false;

        public ColorUserControl()
        {
            InitializeComponent();
            Refresh();
        }

        public void Refresh()
        {
            if (betAmount > 0)
            {
                isActive = true;
                panel_MouseEnter(null, null);
                pictureBoxCoins.Visible = true;
                labelBetAmount.Visible = true;
            }
            else
            {
                isActive = false;
                panel_MouseLeave(null, null);
                pictureBoxCoins.Visible = false;
                labelBetAmount.Visible = false;
            }
        }

        public void SetGradientColor(GameForm gameForm, string name, Color color1, Color color2)
        {
            Name = name;
            rootClass = gameForm;
            panel.GradientColor1 = color1;
            panel.GradientColor2 = color2;

            if (rootClass == null) return;
           
            this.Size = GetSize();
            panel.Size = this.Size;

            var posY = panel.Height - labelBetAmount.Height;
            pictureBoxCoins.Location = new Point(3, posY + 3);
            labelBetAmount.Location = new Point(pictureBoxCoins.Width + 3, posY);

            customLabelName.Text = name;
            customLabelName.Visible = false;
            Visible = true;
        }

        private Size GetSize()
        {
            return rootClass?.gameMode switch
            {
                GameModeEnum.Classic => new Size(162, 128),
                GameModeEnum.Challenger => new Size(162, 82),
                GameModeEnum.Risks => new Size(120, 82),
                _ => throw new ArgumentOutOfRangeException(nameof(rootClass.gameMode), "Unsupported game mode.")
            };
        }

        public void Reset()
        {
            betAmount = 0;
            labelBetAmount.Text = "0";
            hasBet = false;

            Refresh();
        }

        private void panel_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                Utils.PlayButtonSound();

                if (rootClass == null) throw new Exception("HEY DEEP SHIT YOU FORGET THE VALUE OF ROOT CLASS");

                var betForm = rootClass.ModalBet(hasBet ? betAmount : 0);

                if (betForm == null) throw new Exception("Error modal bet!");

                if (betForm != null)
                {
                    // IF USER WANT TO EDIT THE BET AMOUNT ADD THE BET AMOUNT SINCE SYSTEM REDUCE THE USER BALANCE
                    if (hasBet)
                    {
                        rootClass.balance += betAmount;
                    }

                    if (betForm.ResultStatus == 1)
                    {
                        betAmount = betForm.Amount;

                        if (betAmount > rootClass.balance) throw new Exception("Insufficient balance.");
                        if (betForm.Amount < 20) throw new Exception("Minimum bet amount is 20");

                        labelBetAmount.Text = betAmount.ToString("N0");
                        rootClass.balance -= betAmount;

                        rootClass.SetBalance(rootClass.balance);

                        if (rootClass.colorBets.ContainsKey(Name))
                        {
                            rootClass.colorBets[Name] = betAmount; // UPDATE
                        }
                        else
                        {
                            rootClass.colorBets.Add(Name, betAmount); // ADD
                        }

                        Refresh();

                        hasBet = true;
                    }
                    else if (betForm.ResultStatus == 2)
                    {
                        betAmount = 0;

                        rootClass.SetBalance(rootClass.balance);

                        rootClass.colorBets.Remove(Name);

                        Refresh();

                        hasBet = false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void panel_MouseEnter(object sender, EventArgs e)
        {
            //panel.GradientColor1 = Color.Red;
            //panel.GradientColor2 = Color.FromArgb(192, 0, 0);
            panel.BorderColor = Color.White;
            panel.BorderThickness = 5;
            Cursor = Cursors.Hand;
            customLabelName.Visible = true;
            Invalidate();
        }

        private void panel_MouseLeave(object sender, EventArgs e)
        {
            if (isActive) return;

            panel.BorderColor = Color.WhiteSmoke;
            panel.BorderThickness = 2;
            Cursor = Cursors.Default;
            customLabelName.Visible = false;
            Invalidate();
        }
    }
}
