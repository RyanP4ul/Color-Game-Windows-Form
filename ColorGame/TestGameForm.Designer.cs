namespace ColorGame
{
    partial class TestGameForm
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
            btnBack = new Button();
            labelCurrentBalance = new Label();
            btnRoll = new Button();
            btnRed = new Button();
            btnBlue = new Button();
            btnYellow = new Button();
            btnGreen = new Button();
            btnWhite = new Button();
            btnViolet = new Button();
            label1 = new Label();
            label2 = new Label();
            btnDecreaseBet = new Button();
            btnIncreaseBet = new Button();
            timerRollChecker = new System.Windows.Forms.Timer(components);
            randomColor1 = new Panel();
            randomColor2 = new Panel();
            randomColor3 = new Panel();
            flowLayoutPanelBet = new FlowLayoutPanel();
            panelColors = new Panel();
            pictureBox1 = new PictureBox();
            customPanel1 = new ColorGame.CustomControls.CustomPanel();
            customPanel2 = new ColorGame.CustomControls.CustomPanel();
            customPanel3 = new ColorGame.CustomControls.CustomPanel();
            customPanel4 = new ColorGame.CustomControls.CustomPanel();
            customPanel5 = new ColorGame.CustomControls.CustomPanel();
            customPanel6 = new ColorGame.CustomControls.CustomPanel();
            customPanel7 = new ColorGame.CustomControls.CustomPanel();
            customButton1 = new ColorGame.CustomControls.CustomButton();
            customPanel8 = new ColorGame.CustomControls.CustomPanel();
            customPanel9 = new ColorGame.CustomControls.CustomPanel();
            customPanel10 = new ColorGame.CustomControls.CustomPanel();
            panelColors.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.DodgerBlue;
            btnBack.FlatAppearance.BorderSize = 0;
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.Font = new Font("Space Mono", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBack.ForeColor = Color.White;
            btnBack.Location = new Point(22, 11);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(172, 33);
            btnBack.TabIndex = 1;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // labelCurrentBalance
            // 
            labelCurrentBalance.AutoSize = true;
            labelCurrentBalance.Font = new Font("Space Mono", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelCurrentBalance.Location = new Point(345, 20);
            labelCurrentBalance.Name = "labelCurrentBalance";
            labelCurrentBalance.Size = new Size(160, 24);
            labelCurrentBalance.TabIndex = 2;
            labelCurrentBalance.Text = "Balance: 1000.0";
            // 
            // btnRoll
            // 
            btnRoll.BackColor = Color.Orange;
            btnRoll.FlatAppearance.BorderSize = 0;
            btnRoll.FlatStyle = FlatStyle.Flat;
            btnRoll.Font = new Font("Space Mono", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRoll.ForeColor = Color.White;
            btnRoll.Location = new Point(491, 273);
            btnRoll.Name = "btnRoll";
            btnRoll.Size = new Size(204, 51);
            btnRoll.TabIndex = 3;
            btnRoll.Text = "ROLL";
            btnRoll.UseVisualStyleBackColor = false;
            btnRoll.Click += btnRoll_Click;
            // 
            // btnRed
            // 
            btnRed.BackColor = Color.Red;
            btnRed.FlatAppearance.BorderSize = 0;
            btnRed.FlatStyle = FlatStyle.Flat;
            btnRed.Font = new Font("Space Mono", 9.749999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRed.ForeColor = Color.White;
            btnRed.Location = new Point(14, 13);
            btnRed.Name = "btnRed";
            btnRed.Size = new Size(69, 51);
            btnRed.TabIndex = 4;
            btnRed.TextAlign = ContentAlignment.BottomRight;
            btnRed.UseVisualStyleBackColor = false;
            btnRed.Click += btnRed_Click;
            // 
            // btnBlue
            // 
            btnBlue.BackColor = Color.Blue;
            btnBlue.FlatAppearance.BorderSize = 0;
            btnBlue.FlatStyle = FlatStyle.Flat;
            btnBlue.Font = new Font("Space Mono", 9.749999F, FontStyle.Bold);
            btnBlue.ForeColor = Color.White;
            btnBlue.Location = new Point(105, 13);
            btnBlue.Name = "btnBlue";
            btnBlue.Size = new Size(69, 51);
            btnBlue.TabIndex = 5;
            btnBlue.TextAlign = ContentAlignment.BottomRight;
            btnBlue.UseVisualStyleBackColor = false;
            btnBlue.Click += btnBlue_Click;
            // 
            // btnYellow
            // 
            btnYellow.BackColor = Color.FromArgb(255, 255, 128);
            btnYellow.FlatAppearance.BorderSize = 0;
            btnYellow.FlatStyle = FlatStyle.Flat;
            btnYellow.Font = new Font("Space Mono", 9.749999F, FontStyle.Bold);
            btnYellow.ForeColor = Color.Black;
            btnYellow.Location = new Point(199, 13);
            btnYellow.Name = "btnYellow";
            btnYellow.Size = new Size(69, 51);
            btnYellow.TabIndex = 6;
            btnYellow.TextAlign = ContentAlignment.BottomRight;
            btnYellow.UseVisualStyleBackColor = false;
            btnYellow.Click += btnYellow_Click;
            // 
            // btnGreen
            // 
            btnGreen.BackColor = Color.Lime;
            btnGreen.FlatAppearance.BorderSize = 0;
            btnGreen.FlatStyle = FlatStyle.Flat;
            btnGreen.Font = new Font("Space Mono", 9.749999F, FontStyle.Bold);
            btnGreen.ForeColor = Color.Black;
            btnGreen.Location = new Point(12, 80);
            btnGreen.Name = "btnGreen";
            btnGreen.Size = new Size(69, 51);
            btnGreen.TabIndex = 7;
            btnGreen.TextAlign = ContentAlignment.BottomRight;
            btnGreen.UseVisualStyleBackColor = false;
            btnGreen.Click += btnGreen_Click;
            // 
            // btnWhite
            // 
            btnWhite.BackColor = Color.White;
            btnWhite.FlatAppearance.BorderSize = 0;
            btnWhite.FlatStyle = FlatStyle.Flat;
            btnWhite.Font = new Font("Space Mono", 9.749999F, FontStyle.Bold);
            btnWhite.ForeColor = Color.Black;
            btnWhite.Location = new Point(105, 80);
            btnWhite.Name = "btnWhite";
            btnWhite.Size = new Size(69, 51);
            btnWhite.TabIndex = 8;
            btnWhite.TextAlign = ContentAlignment.BottomRight;
            btnWhite.UseVisualStyleBackColor = false;
            btnWhite.Click += btnWhite_Click;
            // 
            // btnViolet
            // 
            btnViolet.BackColor = Color.FromArgb(64, 0, 64);
            btnViolet.FlatAppearance.BorderSize = 0;
            btnViolet.FlatStyle = FlatStyle.Flat;
            btnViolet.Font = new Font("Space Mono", 9.749999F, FontStyle.Bold);
            btnViolet.ForeColor = Color.White;
            btnViolet.Location = new Point(199, 80);
            btnViolet.Name = "btnViolet";
            btnViolet.Size = new Size(69, 51);
            btnViolet.TabIndex = 9;
            btnViolet.TextAlign = ContentAlignment.BottomRight;
            btnViolet.UseVisualStyleBackColor = false;
            btnViolet.Click += btnViolet_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Space Mono", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(987, 97);
            label1.Name = "label1";
            label1.Size = new Size(180, 36);
            label1.TabIndex = 11;
            label1.Text = "Bet History";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Space Mono", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(437, 627);
            label2.Name = "label2";
            label2.Size = new Size(310, 24);
            label2.TabIndex = 12;
            label2.Text = "Win Big Prizes in Color Games!";
            // 
            // btnDecreaseBet
            // 
            btnDecreaseBet.BackColor = Color.Red;
            btnDecreaseBet.FlatStyle = FlatStyle.Flat;
            btnDecreaseBet.Font = new Font("Space Mono", 14.9999981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDecreaseBet.ForeColor = SystemColors.ControlLightLight;
            btnDecreaseBet.Location = new Point(470, 561);
            btnDecreaseBet.Name = "btnDecreaseBet";
            btnDecreaseBet.Size = new Size(74, 38);
            btnDecreaseBet.TabIndex = 13;
            btnDecreaseBet.Text = "-";
            btnDecreaseBet.UseVisualStyleBackColor = false;
            // 
            // btnIncreaseBet
            // 
            btnIncreaseBet.BackColor = Color.Lime;
            btnIncreaseBet.FlatStyle = FlatStyle.Flat;
            btnIncreaseBet.Font = new Font("Space Mono", 14.9999981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnIncreaseBet.ForeColor = SystemColors.ControlLightLight;
            btnIncreaseBet.Location = new Point(623, 561);
            btnIncreaseBet.Name = "btnIncreaseBet";
            btnIncreaseBet.Size = new Size(74, 38);
            btnIncreaseBet.TabIndex = 14;
            btnIncreaseBet.Text = "+";
            btnIncreaseBet.UseVisualStyleBackColor = false;
            // 
            // timerRollChecker
            // 
            timerRollChecker.Enabled = true;
            timerRollChecker.Tick += timerRollChecker_Tick;
            // 
            // randomColor1
            // 
            randomColor1.BackColor = Color.LightGray;
            randomColor1.Location = new Point(470, 174);
            randomColor1.Name = "randomColor1";
            randomColor1.Size = new Size(76, 57);
            randomColor1.TabIndex = 15;
            // 
            // randomColor2
            // 
            randomColor2.BackColor = Color.LightGray;
            randomColor2.Location = new Point(552, 174);
            randomColor2.Name = "randomColor2";
            randomColor2.Size = new Size(76, 57);
            randomColor2.TabIndex = 16;
            // 
            // randomColor3
            // 
            randomColor3.BackColor = Color.LightGray;
            randomColor3.Location = new Point(634, 174);
            randomColor3.Name = "randomColor3";
            randomColor3.Size = new Size(76, 57);
            randomColor3.TabIndex = 16;
            // 
            // flowLayoutPanelBet
            // 
            flowLayoutPanelBet.BackColor = SystemColors.ControlLight;
            flowLayoutPanelBet.Location = new Point(944, 136);
            flowLayoutPanelBet.Name = "flowLayoutPanelBet";
            flowLayoutPanelBet.Size = new Size(276, 515);
            flowLayoutPanelBet.TabIndex = 17;
            // 
            // panelColors
            // 
            panelColors.BackColor = SystemColors.ControlLight;
            panelColors.Controls.Add(btnBlue);
            panelColors.Controls.Add(btnRed);
            panelColors.Controls.Add(btnYellow);
            panelColors.Controls.Add(btnGreen);
            panelColors.Controls.Add(btnWhite);
            panelColors.Controls.Add(btnViolet);
            panelColors.Location = new Point(404, 374);
            panelColors.Name = "panelColors";
            panelColors.Size = new Size(281, 148);
            panelColors.TabIndex = 18;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.pngwing_com;
            pictureBox1.Location = new Point(308, 20);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(31, 27);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 19;
            pictureBox1.TabStop = false;
            // 
            // customPanel1
            // 
            customPanel1.BackColor = Color.Transparent;
            customPanel1.BorderColor = Color.FromArgb(192, 64, 0);
            customPanel1.BorderThickness = -1F;
            customPanel1.CornerRadius = 20;
            customPanel1.GradientAngle = 45F;
            customPanel1.GradientColor1 = Color.Red;
            customPanel1.GradientColor2 = Color.FromArgb(255, 128, 0);
            customPanel1.Location = new Point(65, 223);
            customPanel1.Name = "customPanel1";
            customPanel1.Opacity = 180;
            customPanel1.Size = new Size(72, 52);
            customPanel1.TabIndex = 20;
            // 
            // customPanel2
            // 
            customPanel2.BackColor = Color.Transparent;
            customPanel2.BorderColor = Color.FromArgb(128, 128, 255);
            customPanel2.BorderThickness = -1F;
            customPanel2.CornerRadius = 20;
            customPanel2.GradientAngle = 45F;
            customPanel2.GradientColor1 = Color.Blue;
            customPanel2.GradientColor2 = Color.FromArgb(0, 192, 192);
            customPanel2.Location = new Point(158, 223);
            customPanel2.Name = "customPanel2";
            customPanel2.Opacity = 180;
            customPanel2.Size = new Size(72, 52);
            customPanel2.TabIndex = 21;
            // 
            // customPanel3
            // 
            customPanel3.BackColor = Color.Transparent;
            customPanel3.BorderColor = Color.FromArgb(255, 255, 192);
            customPanel3.BorderThickness = -1F;
            customPanel3.CornerRadius = 20;
            customPanel3.GradientAngle = 45F;
            customPanel3.GradientColor1 = Color.Yellow;
            customPanel3.GradientColor2 = Color.FromArgb(224, 224, 224);
            customPanel3.Location = new Point(252, 223);
            customPanel3.Name = "customPanel3";
            customPanel3.Opacity = 180;
            customPanel3.Size = new Size(72, 52);
            customPanel3.TabIndex = 22;
            // 
            // customPanel4
            // 
            customPanel4.BackColor = Color.Transparent;
            customPanel4.BorderColor = Color.FromArgb(192, 255, 192);
            customPanel4.BorderThickness = -1F;
            customPanel4.CornerRadius = 20;
            customPanel4.GradientAngle = 45F;
            customPanel4.GradientColor1 = Color.Lime;
            customPanel4.GradientColor2 = Color.FromArgb(192, 255, 192);
            customPanel4.Location = new Point(65, 281);
            customPanel4.Name = "customPanel4";
            customPanel4.Opacity = 180;
            customPanel4.Size = new Size(72, 52);
            customPanel4.TabIndex = 21;
            // 
            // customPanel5
            // 
            customPanel5.BackColor = Color.Transparent;
            customPanel5.BorderColor = Color.FromArgb(224, 224, 224);
            customPanel5.BorderThickness = -1F;
            customPanel5.CornerRadius = 20;
            customPanel5.GradientAngle = 45F;
            customPanel5.GradientColor1 = Color.White;
            customPanel5.GradientColor2 = Color.FromArgb(224, 224, 224);
            customPanel5.Location = new Point(158, 281);
            customPanel5.Name = "customPanel5";
            customPanel5.Opacity = 180;
            customPanel5.Size = new Size(72, 52);
            customPanel5.TabIndex = 21;
            // 
            // customPanel6
            // 
            customPanel6.BackColor = Color.Transparent;
            customPanel6.BorderColor = Color.FromArgb(255, 192, 255);
            customPanel6.BorderThickness = -1F;
            customPanel6.CornerRadius = 20;
            customPanel6.GradientAngle = 45F;
            customPanel6.GradientColor1 = Color.FromArgb(64, 0, 64);
            customPanel6.GradientColor2 = Color.Purple;
            customPanel6.Location = new Point(252, 281);
            customPanel6.Name = "customPanel6";
            customPanel6.Opacity = 180;
            customPanel6.Size = new Size(72, 52);
            customPanel6.TabIndex = 21;
            // 
            // customPanel7
            // 
            customPanel7.BackColor = Color.Transparent;
            customPanel7.BorderColor = Color.Green;
            customPanel7.BorderThickness = 2F;
            customPanel7.CornerRadius = 20;
            customPanel7.GradientAngle = 45F;
            customPanel7.GradientColor1 = SystemColors.ControlLight;
            customPanel7.GradientColor2 = SystemColors.ControlLightLight;
            customPanel7.Location = new Point(738, 136);
            customPanel7.Name = "customPanel7";
            customPanel7.Opacity = 180;
            customPanel7.Size = new Size(200, 463);
            customPanel7.TabIndex = 23;
            // 
            // customButton1
            // 
            customButton1.BackColor = Color.Transparent;
            customButton1.CornerRadius = 20;
            customButton1.FlatAppearance.BorderSize = 0;
            customButton1.FlatStyle = FlatStyle.Flat;
            customButton1.Font = new Font("Space Mono", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            customButton1.ForeColor = Color.White;
            customButton1.GradientAngle = 45F;
            customButton1.GradientColor1 = Color.CornflowerBlue;
            customButton1.GradientColor2 = Color.MediumPurple;
            customButton1.Location = new Point(111, 374);
            customButton1.Name = "customButton1";
            customButton1.Size = new Size(179, 47);
            customButton1.TabIndex = 24;
            customButton1.Text = "ROLL";
            customButton1.UseVisualStyleBackColor = false;
            // 
            // customPanel8
            // 
            customPanel8.BackColor = Color.Transparent;
            customPanel8.BorderColor = Color.DarkGray;
            customPanel8.BorderThickness = 2F;
            customPanel8.CornerRadius = 20;
            customPanel8.GradientAngle = 45F;
            customPanel8.GradientColor1 = Color.LightGray;
            customPanel8.GradientColor2 = Color.SlateGray;
            customPanel8.Location = new Point(65, 108);
            customPanel8.Name = "customPanel8";
            customPanel8.Opacity = 180;
            customPanel8.Size = new Size(85, 57);
            customPanel8.TabIndex = 25;
            // 
            // customPanel9
            // 
            customPanel9.BackColor = Color.Transparent;
            customPanel9.BorderColor = Color.DarkGray;
            customPanel9.BorderThickness = 2F;
            customPanel9.CornerRadius = 20;
            customPanel9.GradientAngle = 45F;
            customPanel9.GradientColor1 = Color.LightGray;
            customPanel9.GradientColor2 = Color.SlateGray;
            customPanel9.Location = new Point(158, 108);
            customPanel9.Name = "customPanel9";
            customPanel9.Opacity = 180;
            customPanel9.Size = new Size(85, 57);
            customPanel9.TabIndex = 26;
            // 
            // customPanel10
            // 
            customPanel10.BackColor = Color.Transparent;
            customPanel10.BorderColor = Color.DarkGray;
            customPanel10.BorderThickness = 2F;
            customPanel10.CornerRadius = 20;
            customPanel10.GradientAngle = 45F;
            customPanel10.GradientColor1 = Color.LightGray;
            customPanel10.GradientColor2 = Color.SlateGray;
            customPanel10.Location = new Point(254, 108);
            customPanel10.Name = "customPanel10";
            customPanel10.Opacity = 180;
            customPanel10.Size = new Size(85, 57);
            customPanel10.TabIndex = 26;
            // 
            // GameForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            ClientSize = new Size(1242, 674);
            Controls.Add(customPanel10);
            Controls.Add(customPanel9);
            Controls.Add(customPanel8);
            Controls.Add(customButton1);
            Controls.Add(customPanel7);
            Controls.Add(customPanel6);
            Controls.Add(customPanel5);
            Controls.Add(customPanel4);
            Controls.Add(customPanel3);
            Controls.Add(customPanel2);
            Controls.Add(customPanel1);
            Controls.Add(pictureBox1);
            Controls.Add(panelColors);
            Controls.Add(flowLayoutPanelBet);
            Controls.Add(randomColor3);
            Controls.Add(randomColor2);
            Controls.Add(randomColor1);
            Controls.Add(btnIncreaseBet);
            Controls.Add(btnDecreaseBet);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnRoll);
            Controls.Add(labelCurrentBalance);
            Controls.Add(btnBack);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "GameForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Color Game";
            panelColors.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnBack;
        private Label labelCurrentBalance;
        private Button btnRoll;
        private Button btnRed;
        private Button btnBlue;
        private Button btnYellow;
        private Button btnGreen;
        private Button btnWhite;
        private Button btnViolet;
        private FlowLayoutPanel flowLayoutPanelBetHistory;
        private FlowLayoutPanel flowLayoutPanelBet;
        private Label label1;
        private Label label2;
        private Button btnDecreaseBet;
        private Button btnIncreaseBet;
        private System.Windows.Forms.Timer timerRollChecker;
        private Panel randomColor1;
        private Panel randomColor2;
        private Panel randomColor3;
        private Panel panelColors;
        private PictureBox pictureBox1;
        private CustomControls.CustomPanel customPanel1;
        private CustomControls.CustomPanel customPanel2;
        private CustomControls.CustomPanel customPanel3;
        private CustomControls.CustomPanel customPanel4;
        private CustomControls.CustomPanel customPanel5;
        private CustomControls.CustomPanel customPanel6;
        private CustomControls.CustomPanel customPanel7;
        private CustomControls.CustomButton customButton1;
        private CustomControls.CustomPanel customPanel8;
        private CustomControls.CustomPanel customPanel9;
        private CustomControls.CustomPanel customPanel10;
    }
}