using ColorGame.CustomControls;

namespace ColorGame
{
    partial class GameForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameForm));
            gameTimer = new System.Windows.Forms.Timer(components);
            resultLabel = new Label();
            btnLever = new CustomButton();
            labelBaitAttempt = new Label();
            board = new PictureBox();
            labelBAIT = new Label();
            colorContainer = new CustomPictureBox();
            pictureBoxJackbot = new PictureBox();
            colorRedBet = new ColorUserControl();
            colorGreenBet = new ColorUserControl();
            colorBlueBet = new ColorUserControl();
            colorYellowBet = new ColorUserControl();
            colorOrangeBet = new ColorUserControl();
            colorPinkBet = new ColorUserControl();
            msgUserControl = new MsgUserControl();
            verticalProgressBar = new VerticalProgressBar();
            picuteBoxGameStatistics = new CustomPictureBox();
            pictureBoxBetHistory = new CustomPictureBox();
            pictureBoxBack = new PictureBox();
            mode1 = new CustomPictureBox();
            mode2 = new CustomPictureBox();
            mode3 = new CustomPictureBox();
            colorPurpleBet = new ColorUserControl();
            colorCyanBet = new ColorUserControl();
            colorBrownBet = new ColorUserControl();
            colorBlackBet = new ColorUserControl();
            colorWhiteBet = new ColorUserControl();
            colorGrayBet = new ColorUserControl();
            labelPrizeMultiplier = new CustomLabel();
            labelCurrentBalance = new CustomLabel();
            pictureBoxCoins = new PictureBox();
            toolTip = new ToolTip(components);
            pictureBoxChangeMode = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)board).BeginInit();
            ((System.ComponentModel.ISupportInitialize)colorContainer).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxJackbot).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picuteBoxGameStatistics).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxBetHistory).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxBack).BeginInit();
            ((System.ComponentModel.ISupportInitialize)mode1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)mode2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)mode3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxCoins).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxChangeMode).BeginInit();
            SuspendLayout();
            // 
            // gameTimer
            // 
            gameTimer.Interval = 30;
            gameTimer.Tick += gameTimer_Tick;
            // 
            // resultLabel
            // 
            resultLabel.AutoSize = true;
            resultLabel.BackColor = Color.Transparent;
            resultLabel.Font = new Font("Space Mono", 11.249999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            resultLabel.ForeColor = Color.White;
            resultLabel.Location = new Point(868, 581);
            resultLabel.Name = "resultLabel";
            resultLabel.Size = new Size(73, 22);
            resultLabel.TabIndex = 10;
            resultLabel.Text = "Waiting";
            resultLabel.Visible = false;
            // 
            // btnLever
            // 
            btnLever.BackColor = Color.Transparent;
            btnLever.CornerRadius = 4;
            btnLever.EnableHover = false;
            btnLever.FlatAppearance.BorderSize = 0;
            btnLever.FlatStyle = FlatStyle.Flat;
            btnLever.Font = new Font("Space Mono", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLever.ForeColor = Color.White;
            btnLever.GlowColor = Color.Cyan;
            btnLever.GlowSize = 8;
            btnLever.GradientAngle = 45F;
            btnLever.GradientColor1 = Color.LightCoral;
            btnLever.GradientColor2 = Color.Wheat;
            btnLever.HoverOverlayColor = Color.Red;
            btnLever.Location = new Point(1211, 581);
            btnLever.Name = "btnLever";
            btnLever.Size = new Size(173, 49);
            btnLever.TabIndex = 11;
            btnLever.Text = "Roll";
            btnLever.UseVisualStyleBackColor = false;
            btnLever.Visible = false;
            btnLever.Click += btnLever_Click;
            btnLever.MouseEnter += btnLever_MouseEnter;
            btnLever.MouseLeave += btnLever_MouseLeave;
            // 
            // labelBaitAttempt
            // 
            labelBaitAttempt.AutoSize = true;
            labelBaitAttempt.BackColor = Color.Transparent;
            labelBaitAttempt.Font = new Font("Space Mono", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelBaitAttempt.ForeColor = Color.White;
            labelBaitAttempt.Location = new Point(1280, 643);
            labelBaitAttempt.Name = "labelBaitAttempt";
            labelBaitAttempt.Size = new Size(96, 28);
            labelBaitAttempt.TabIndex = 12;
            labelBaitAttempt.Text = "Bait: 3";
            labelBaitAttempt.Visible = false;
            // 
            // board
            // 
            board.BackColor = Color.Transparent;
            board.Image = (Image)resources.GetObject("board.Image");
            board.Location = new Point(248, 65);
            board.Name = "board";
            board.Size = new Size(606, 606);
            board.SizeMode = PictureBoxSizeMode.StretchImage;
            board.TabIndex = 14;
            board.TabStop = false;
            board.Visible = false;
            // 
            // labelBAIT
            // 
            labelBAIT.AutoSize = true;
            labelBAIT.BackColor = Color.Transparent;
            labelBAIT.Font = new Font("Space Mono", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelBAIT.ForeColor = Color.White;
            labelBAIT.Location = new Point(359, 674);
            labelBAIT.Name = "labelBAIT";
            labelBAIT.Size = new Size(404, 32);
            labelBAIT.TabIndex = 15;
            labelBAIT.Text = "Win Big Prizes in Color Games!";
            labelBAIT.Visible = false;
            // 
            // colorContainer
            // 
            colorContainer.BackColor = Color.Transparent;
            colorContainer.GlowColor = Color.Black;
            colorContainer.GlowSize = 4;
            colorContainer.Image = Properties.Resources.Panel;
            colorContainer.Location = new Point(868, 254);
            colorContainer.Name = "colorContainer";
            colorContainer.Opacity = 100;
            colorContainer.Size = new Size(520, 281);
            colorContainer.SizeMode = PictureBoxSizeMode.StretchImage;
            colorContainer.TabIndex = 18;
            colorContainer.TabStop = false;
            colorContainer.Visible = false;
            // 
            // pictureBoxJackbot
            // 
            pictureBoxJackbot.Image = Properties.Resources.Jackpot;
            pictureBoxJackbot.Location = new Point(861, 51);
            pictureBoxJackbot.Name = "pictureBoxJackbot";
            pictureBoxJackbot.Size = new Size(535, 183);
            pictureBoxJackbot.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxJackbot.TabIndex = 23;
            pictureBoxJackbot.TabStop = false;
            pictureBoxJackbot.Visible = false;
            // 
            // colorRedBet
            // 
            colorRedBet.Location = new Point(878, 265);
            colorRedBet.Name = "colorRedBet";
            colorRedBet.Size = new Size(162, 82);
            colorRedBet.TabIndex = 24;
            toolTip.SetToolTip(colorRedBet, "Red");
            colorRedBet.Visible = false;
            // 
            // colorGreenBet
            // 
            colorGreenBet.Location = new Point(1046, 265);
            colorGreenBet.Name = "colorGreenBet";
            colorGreenBet.Size = new Size(162, 82);
            colorGreenBet.TabIndex = 25;
            toolTip.SetToolTip(colorGreenBet, "Green");
            colorGreenBet.Visible = false;
            // 
            // colorBlueBet
            // 
            colorBlueBet.Location = new Point(1214, 265);
            colorBlueBet.Name = "colorBlueBet";
            colorBlueBet.Size = new Size(162, 82);
            colorBlueBet.TabIndex = 26;
            toolTip.SetToolTip(colorBlueBet, "Blue");
            colorBlueBet.Visible = false;
            // 
            // colorYellowBet
            // 
            colorYellowBet.Location = new Point(878, 353);
            colorYellowBet.Name = "colorYellowBet";
            colorYellowBet.Size = new Size(162, 82);
            colorYellowBet.TabIndex = 27;
            toolTip.SetToolTip(colorYellowBet, "Yellow");
            colorYellowBet.Visible = false;
            // 
            // colorOrangeBet
            // 
            colorOrangeBet.Location = new Point(1046, 353);
            colorOrangeBet.Name = "colorOrangeBet";
            colorOrangeBet.Size = new Size(162, 82);
            colorOrangeBet.TabIndex = 28;
            toolTip.SetToolTip(colorOrangeBet, "Orange");
            colorOrangeBet.Visible = false;
            // 
            // colorPinkBet
            // 
            colorPinkBet.Location = new Point(1214, 353);
            colorPinkBet.Name = "colorPinkBet";
            colorPinkBet.Size = new Size(162, 82);
            colorPinkBet.TabIndex = 29;
            toolTip.SetToolTip(colorPinkBet, "Pink");
            colorPinkBet.Visible = false;
            // 
            // msgUserControl
            // 
            msgUserControl.BackColor = Color.Transparent;
            msgUserControl.Location = new Point(156, -6);
            msgUserControl.Name = "msgUserControl";
            msgUserControl.Size = new Size(1225, 65);
            msgUserControl.TabIndex = 30;
            msgUserControl.Visible = false;
            // 
            // verticalProgressBar
            // 
            verticalProgressBar.BackColor = Color.Gray;
            verticalProgressBar.BorderStyle = BorderStyle.FixedSingle;
            verticalProgressBar.FillColor = Color.OrangeRed;
            verticalProgressBar.Location = new Point(843, 256);
            verticalProgressBar.Name = "verticalProgressBar";
            verticalProgressBar.Progress = 0;
            verticalProgressBar.Size = new Size(13, 275);
            verticalProgressBar.TabIndex = 35;
            verticalProgressBar.Visible = false;
            // 
            // picuteBoxGameStatistics
            // 
            picuteBoxGameStatistics.BackColor = Color.Transparent;
            picuteBoxGameStatistics.BackgroundImage = Properties.Resources.Panel;
            picuteBoxGameStatistics.GlowColor = Color.Black;
            picuteBoxGameStatistics.GlowSize = 6;
            picuteBoxGameStatistics.Location = new Point(21, 72);
            picuteBoxGameStatistics.Name = "picuteBoxGameStatistics";
            picuteBoxGameStatistics.Opacity = 100;
            picuteBoxGameStatistics.Size = new Size(245, 220);
            picuteBoxGameStatistics.TabIndex = 36;
            picuteBoxGameStatistics.TabStop = false;
            picuteBoxGameStatistics.Visible = false;
            // 
            // pictureBoxBetHistory
            // 
            pictureBoxBetHistory.BackColor = Color.Transparent;
            pictureBoxBetHistory.BackgroundImage = Properties.Resources.Panel;
            pictureBoxBetHistory.BorderStyle = BorderStyle.FixedSingle;
            pictureBoxBetHistory.GlowColor = Color.Black;
            pictureBoxBetHistory.GlowSize = 6;
            pictureBoxBetHistory.Location = new Point(21, 298);
            pictureBoxBetHistory.Name = "pictureBoxBetHistory";
            pictureBoxBetHistory.Opacity = 100;
            pictureBoxBetHistory.Size = new Size(245, 217);
            pictureBoxBetHistory.TabIndex = 37;
            pictureBoxBetHistory.TabStop = false;
            pictureBoxBetHistory.Visible = false;
            // 
            // pictureBoxBack
            // 
            pictureBoxBack.BackColor = Color.Transparent;
            pictureBoxBack.Image = Properties.Resources.Back;
            pictureBoxBack.Location = new Point(7, 4);
            pictureBoxBack.Name = "pictureBoxBack";
            pictureBoxBack.Size = new Size(57, 43);
            pictureBoxBack.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxBack.TabIndex = 38;
            pictureBoxBack.TabStop = false;
            toolTip.SetToolTip(pictureBoxBack, "Back");
            pictureBoxBack.Click += pictureBoxBack_Click;
            pictureBoxBack.MouseEnter += pictureBoxBack_MouseEnter;
            pictureBoxBack.MouseLeave += pictureBoxBack_MouseLeave;
            // 
            // mode1
            // 
            mode1.BackColor = Color.Transparent;
            mode1.GlowColor = Color.White;
            mode1.GlowSize = 1;
            mode1.Image = (Image)resources.GetObject("mode1.Image");
            mode1.Location = new Point(195, 99);
            mode1.Name = "mode1";
            mode1.Opacity = 100;
            mode1.Size = new Size(332, 581);
            mode1.SizeMode = PictureBoxSizeMode.AutoSize;
            mode1.TabIndex = 39;
            mode1.TabStop = false;
            mode1.MouseClick += mode1_MouseClick;
            mode1.MouseEnter += mode1_MouseEnter;
            mode1.MouseLeave += mode1_MouseLeave;
            // 
            // mode2
            // 
            mode2.BackColor = Color.Transparent;
            mode2.GlowColor = Color.White;
            mode2.GlowSize = 1;
            mode2.Image = (Image)resources.GetObject("mode2.Image");
            mode2.Location = new Point(535, 99);
            mode2.Name = "mode2";
            mode2.Opacity = 100;
            mode2.Size = new Size(332, 581);
            mode2.SizeMode = PictureBoxSizeMode.AutoSize;
            mode2.TabIndex = 40;
            mode2.TabStop = false;
            mode2.MouseClick += mode2_MouseClick;
            mode2.MouseEnter += mode2_MouseEnter;
            mode2.MouseLeave += mode2_MouseLeave;
            // 
            // mode3
            // 
            mode3.BackColor = Color.Transparent;
            mode3.GlowColor = Color.White;
            mode3.GlowSize = 1;
            mode3.Image = (Image)resources.GetObject("mode3.Image");
            mode3.Location = new Point(878, 99);
            mode3.Name = "mode3";
            mode3.Opacity = 100;
            mode3.Size = new Size(332, 581);
            mode3.SizeMode = PictureBoxSizeMode.AutoSize;
            mode3.TabIndex = 41;
            mode3.TabStop = false;
            mode3.MouseClick += mode3_MouseClick;
            mode3.MouseEnter += mode3_MouseEnter;
            mode3.MouseLeave += mode3_MouseLeave;
            // 
            // colorPurpleBet
            // 
            colorPurpleBet.Location = new Point(1046, 441);
            colorPurpleBet.Name = "colorPurpleBet";
            colorPurpleBet.Size = new Size(162, 82);
            colorPurpleBet.TabIndex = 42;
            toolTip.SetToolTip(colorPurpleBet, "Purple");
            colorPurpleBet.Visible = false;
            // 
            // colorCyanBet
            // 
            colorCyanBet.Location = new Point(1214, 441);
            colorCyanBet.Name = "colorCyanBet";
            colorCyanBet.Size = new Size(162, 82);
            colorCyanBet.TabIndex = 43;
            toolTip.SetToolTip(colorCyanBet, "Cyan");
            colorCyanBet.Visible = false;
            // 
            // colorBrownBet
            // 
            colorBrownBet.Location = new Point(878, 441);
            colorBrownBet.Name = "colorBrownBet";
            colorBrownBet.Size = new Size(162, 82);
            colorBrownBet.TabIndex = 44;
            toolTip.SetToolTip(colorBrownBet, "Brown");
            colorBrownBet.Visible = false;
            // 
            // colorBlackBet
            // 
            colorBlackBet.Location = new Point(882, 637);
            colorBlackBet.Name = "colorBlackBet";
            colorBlackBet.Size = new Size(120, 82);
            colorBlackBet.TabIndex = 45;
            colorBlackBet.Visible = false;
            // 
            // colorWhiteBet
            // 
            colorWhiteBet.Location = new Point(1008, 637);
            colorWhiteBet.Name = "colorWhiteBet";
            colorWhiteBet.Size = new Size(120, 82);
            colorWhiteBet.TabIndex = 46;
            colorWhiteBet.Visible = false;
            // 
            // colorGrayBet
            // 
            colorGrayBet.Location = new Point(1134, 637);
            colorGrayBet.Name = "colorGrayBet";
            colorGrayBet.Size = new Size(120, 82);
            colorGrayBet.TabIndex = 47;
            colorGrayBet.Visible = false;
            // 
            // labelPrizeMultiplier
            // 
            labelPrizeMultiplier.AutoSize = true;
            labelPrizeMultiplier.BackColor = Color.Transparent;
            labelPrizeMultiplier.Font = new Font("Space Mono", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelPrizeMultiplier.ForeColor = Color.White;
            labelPrizeMultiplier.GlowColor = Color.Black;
            labelPrizeMultiplier.GlowSize = 6;
            labelPrizeMultiplier.Location = new Point(1208, 543);
            labelPrizeMultiplier.Name = "labelPrizeMultiplier";
            labelPrizeMultiplier.Size = new Size(180, 28);
            labelPrizeMultiplier.TabIndex = 48;
            labelPrizeMultiplier.Text = "1.0 Multiplier";
            labelPrizeMultiplier.Visible = false;
            // 
            // labelCurrentBalance
            // 
            labelCurrentBalance.AutoSize = true;
            labelCurrentBalance.BackColor = Color.Transparent;
            labelCurrentBalance.Font = new Font("Space Mono", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelCurrentBalance.ForeColor = Color.White;
            labelCurrentBalance.GlowColor = Color.Black;
            labelCurrentBalance.GlowSize = 6;
            labelCurrentBalance.Location = new Point(901, 541);
            labelCurrentBalance.Name = "labelCurrentBalance";
            labelCurrentBalance.Size = new Size(72, 28);
            labelCurrentBalance.TabIndex = 49;
            labelCurrentBalance.Text = "1,000";
            labelCurrentBalance.Visible = false;
            // 
            // pictureBoxCoins
            // 
            pictureBoxCoins.BackColor = Color.Transparent;
            pictureBoxCoins.Image = Properties.Resources.Currency;
            pictureBoxCoins.Location = new Point(872, 543);
            pictureBoxCoins.Name = "pictureBoxCoins";
            pictureBoxCoins.Size = new Size(25, 25);
            pictureBoxCoins.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxCoins.TabIndex = 50;
            pictureBoxCoins.TabStop = false;
            pictureBoxCoins.Visible = false;
            // 
            // pictureBoxChangeMode
            // 
            pictureBoxChangeMode.BackColor = Color.Transparent;
            pictureBoxChangeMode.Image = (Image)resources.GetObject("pictureBoxChangeMode.Image");
            pictureBoxChangeMode.Location = new Point(1389, 256);
            pictureBoxChangeMode.Name = "pictureBoxChangeMode";
            pictureBoxChangeMode.Size = new Size(57, 43);
            pictureBoxChangeMode.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxChangeMode.TabIndex = 51;
            pictureBoxChangeMode.TabStop = false;
            toolTip.SetToolTip(pictureBoxChangeMode, "Change Mode");
            pictureBoxChangeMode.Visible = false;
            pictureBoxChangeMode.Click += pictureBoxChangeMode_Click;
            pictureBoxChangeMode.MouseEnter += pictureBoxChangeMode_MouseEnter;
            pictureBoxChangeMode.MouseLeave += pictureBoxChangeMode_MouseLeave;
            // 
            // GameForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1464, 731);
            Controls.Add(mode3);
            Controls.Add(pictureBoxChangeMode);
            Controls.Add(pictureBoxCoins);
            Controls.Add(labelCurrentBalance);
            Controls.Add(colorGrayBet);
            Controls.Add(colorWhiteBet);
            Controls.Add(colorBlackBet);
            Controls.Add(labelPrizeMultiplier);
            Controls.Add(colorBrownBet);
            Controls.Add(colorCyanBet);
            Controls.Add(colorPurpleBet);
            Controls.Add(mode2);
            Controls.Add(mode1);
            Controls.Add(pictureBoxBack);
            Controls.Add(pictureBoxBetHistory);
            Controls.Add(picuteBoxGameStatistics);
            Controls.Add(verticalProgressBar);
            Controls.Add(msgUserControl);
            Controls.Add(colorPinkBet);
            Controls.Add(colorOrangeBet);
            Controls.Add(colorYellowBet);
            Controls.Add(colorBlueBet);
            Controls.Add(colorGreenBet);
            Controls.Add(colorRedBet);
            Controls.Add(labelBAIT);
            Controls.Add(labelBaitAttempt);
            Controls.Add(btnLever);
            Controls.Add(resultLabel);
            Controls.Add(board);
            Controls.Add(colorContainer);
            Controls.Add(pictureBoxJackbot);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "GameForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ColorGame - Prototype";
            Shown += GameForm_Shown;
            ((System.ComponentModel.ISupportInitialize)board).EndInit();
            ((System.ComponentModel.ISupportInitialize)colorContainer).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxJackbot).EndInit();
            ((System.ComponentModel.ISupportInitialize)picuteBoxGameStatistics).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxBetHistory).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxBack).EndInit();
            ((System.ComponentModel.ISupportInitialize)mode1).EndInit();
            ((System.ComponentModel.ISupportInitialize)mode2).EndInit();
            ((System.ComponentModel.ISupportInitialize)mode3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxCoins).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxChangeMode).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Timer gameTimer;
        private Label resultLabel;
        private CustomControls.CustomButton btnLever;
        private Label labelBaitAttempt;
        private PictureBox board;
        private Label labelBAIT;
        private CustomPictureBox colorContainer;
        private PictureBox jackpotBG;
        private Label label1;
        private PictureBox pictureBoxJackbot;
        private ColorUserControl colorRedBet;
        private ColorUserControl colorGreenBet;
        private ColorUserControl colorBlueBet;
        private ColorUserControl colorYellowBet;
        private ColorUserControl colorOrangeBet;
        private ColorUserControl colorPinkBet;
        private MsgUserControl msgUserControl;
        private VerticalProgressBar verticalProgressBar;
        private CustomPictureBox picuteBoxGameStatistics;
        private CustomPictureBox mode2;
        private CustomLabel customLabel1;
        private CustomPictureBox pictureBoxBetHistory;
        private PictureBox pictureBoxBack;
        private CustomPictureBox mode1;
        private CustomPictureBox mode3;
        private ColorUserControl colorPurpleBet;
        private ColorUserControl colorCyanBet;
        private ColorUserControl colorBrownBet;
        private ColorUserControl colorBlackBet;
        private ColorUserControl colorWhiteBet;
        private ColorUserControl colorGrayBet;
        private CustomLabel labelPrizeMultiplier;
        private CustomLabel labelCurrentBalance;
        private PictureBox pictureBoxCoins;
        private ToolTip toolTip;
        private PictureBox pictureBoxChangeMode;
    }
}