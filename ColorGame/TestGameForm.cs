using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Timers;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace ColorGame
{
    public partial class TestGameForm : Form
    {

        private struct BetHistory
        {
            public int Amount;
            public bool IsWin;
            public Color Color;
        }

        private struct Dice
        {
            public Color colorType;
            public double amountBet;

            public Dice(Color colorType, double amountBet)
            {
                this.colorType = colorType;
                this.amountBet = amountBet;
            }

        }

        // CONFIGURATION
        private const int MINIMUM_AMOUNT_BET = 20;
        private const int MAX_DICE_ROLL = 3;
        private const int MAX_COLORS = 6;
        private const int MAX_BAIT = 5; // INCREASE THE CHANCE OF WINNING :>

        private readonly Random _random = new Random();
        private DateTime startTime = DateTime.Now;
        private static double _balance = 0;

        private IList<Dice> _selectedDices = new List<Dice>();
        private IList<Color> _randomColorTypes = new List<Color> { Color.Red, Color.Blue, Color.Yellow, Color.Green, Color.White, Color.Purple };

        public TestGameForm()
        {
            InitializeComponent();

            this.MaximizeBox = false;
            this.MinimizeBox = false;
            //this.Icon = new Icon(Configuration.ICON);

            // IF BALANCE IS 0 GENERATE A RANDOM NUMBER 1000 - 5000.
            // SINCE BALANCE IS STATIC IT ONLY GENERATE ONCE.
            if (_balance == 0) _balance = (double)_random.Next(1000, 5000);

            btnRoll.Enabled = false; // DISABLE THE ROLL BUTTON UNTIL THE BET IS SELECTED
            randomColor1.Enabled = false;
            randomColor2.Enabled = false;
            randomColor3.Enabled = false;

            RefreshBalance();

            _selectedDices.Clear();
        }


        private DialogResult ConfirmationRemoveBet => MessageBox.Show("Do you want to remove your bet?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
        private void RefreshBalance() => labelCurrentBalance.Text = $"Balance: {_balance}";

        private void ResetAllColorButtons()
        {
            btnRed.Text = "";
            btnBlue.Text = "";
            btnYellow.Text = "";
            btnGreen.Text = "";
            btnWhite.Text = "";
            btnViolet.Text = "";
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            new MainForm().Show();
            this.Hide();
        }

        private void btnRoll_Click(object sender, EventArgs e)
        {
            //if (_selectedDices.Count < 1)
            //{
            //    MessageBox.Show($"Please select colors atleast 1 - {MAX_DICE_ROLL}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return;
            //}

            //startTime = DateTime.Now;

            //btnRoll.Enabled = false;

            //var timer = new System.Timers.Timer();
            //timer.Interval = 100;
            //timer.AutoReset = true;
            //timer.Elapsed += (sender, e) =>
            //{
            //    TimeSpan elapsed = DateTime.Now - startTime;

            //    var shuffledColors = _randomColorTypes.OrderBy(c => new Random().Next()).ToList();

            //    Invoke(new Action(() =>
            //    {
            //        randomColor1.BackColor = shuffledColors[0];
            //        randomColor2.BackColor = shuffledColors[1];
            //        randomColor3.BackColor = shuffledColors[2];

            //        if (elapsed.TotalSeconds > 6)
            //        {
            //            timer.Dispose();
            //            timer.Close();

            //            btnRoll.Enabled = true;

            //            ResetAllColorButtons();

            //            var betListItem = new BetListItem();
            //            betListItem.BackColor = flowLayoutPanelBet.Controls.Count % 2 == 0 ? Color.FromArgb(255, 255, 255) : Color.FromArgb(240, 240, 240);
            //            betListItem.Init(_selectedDices.Sum(x => x.amountBet), randomColor1, randomColor2, randomColor3);
            //            flowLayoutPanelBet.Controls.Add(betListItem);

            //            _selectedDices.Clear();
            //        }
            //    }));
            //};

            //timer.Start();
        }

        private void Timer_Elapsed(object? sender, System.Timers.ElapsedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void SelectColorItem(Button btnColor, Color colorType)
        {
            if (string.IsNullOrEmpty(btnColor.Text))
            {
                var response = Interaction.InputBox("Enter Bet Amount", "Bet", "0", 500, 300);

                if (string.IsNullOrEmpty(response)) return;

                var amountBet = Convert.ToDouble(response);

                if (MINIMUM_AMOUNT_BET > amountBet)
                {
                    MessageBox.Show($"The minium of bet amount is {MINIMUM_AMOUNT_BET}!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (_balance < amountBet)
                {
                    MessageBox.Show($"You broke bro!");
                    return;
                }

                if (_selectedDices.Count >= MAX_DICE_ROLL)
                {
                    MessageBox.Show($"You reached the max dice roll. Chill BROO!");
                    return;
                }

                _balance -= amountBet; // REDUCE PLAYER BALANCE
                btnColor.Text = amountBet.ToString();
                _selectedDices.Add(new Dice(colorType, amountBet));
                RefreshBalance();
            }
            else
            {
                if (ConfirmationRemoveBet == DialogResult.Yes)
                {
                    var _currentColorType = _selectedDices.First(x => x.colorType == colorType);
                    _balance += _currentColorType.amountBet;
                    _selectedDices.Remove(_currentColorType);
                    btnColor.Text = "";
                    RefreshBalance();
                }
            }
        }

        private void btnRed_Click(object sender, EventArgs e) => SelectColorItem(btnRed, Color.Red);
        private void btnBlue_Click(object sender, EventArgs e) => SelectColorItem(btnBlue, Color.Blue);
        private void btnYellow_Click(object sender, EventArgs e) => SelectColorItem(btnYellow, Color.Yellow);
        private void btnGreen_Click(object sender, EventArgs e) => SelectColorItem(btnGreen, Color.Green);
        private void btnWhite_Click(object sender, EventArgs e) => SelectColorItem(btnWhite, Color.White);
        private void btnViolet_Click(object sender, EventArgs e) => SelectColorItem(btnViolet, Color.Violet);
        private void timerRollChecker_Tick(object sender, EventArgs e) => btnRoll.Enabled = _selectedDices.Count > 0;

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            using (LinearGradientBrush brush = new LinearGradientBrush(
                this.ClientRectangle,                     // Area to fill
                Color.LightBlue,                          // Start color
                Color.MediumPurple,                       // End color
                LinearGradientMode.Vertical))             // Direction (can be Horizontal, ForwardDiagonal, etc.)
            {
                e.Graphics.FillRectangle(brush, this.ClientRectangle);
            }
        }

    }
}
