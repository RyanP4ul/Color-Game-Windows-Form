namespace ColorGame
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnStart = new Button();
            btnExit = new Button();
            btnHelp = new Button();
            pictureBox1 = new PictureBox();
            btnWallet = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnStart
            // 
            btnStart.BackColor = Color.Khaki;
            btnStart.FlatAppearance.BorderSize = 0;
            btnStart.FlatStyle = FlatStyle.Flat;
            btnStart.Font = new Font("Space Mono", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnStart.Location = new Point(628, 364);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(198, 45);
            btnStart.TabIndex = 0;
            btnStart.Text = "START";
            btnStart.UseVisualStyleBackColor = false;
            btnStart.Click += btnStart_Click;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.Silver;
            btnExit.FlatAppearance.BorderSize = 0;
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Font = new Font("Space Mono", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExit.Location = new Point(663, 481);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(129, 33);
            btnExit.TabIndex = 1;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // btnHelp
            // 
            btnHelp.BackColor = Color.Silver;
            btnHelp.FlatAppearance.BorderSize = 0;
            btnHelp.FlatStyle = FlatStyle.Flat;
            btnHelp.Font = new Font("Space Mono", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnHelp.Location = new Point(663, 431);
            btnHelp.Name = "btnHelp";
            btnHelp.Size = new Size(129, 33);
            btnHelp.TabIndex = 3;
            btnHelp.Text = "Help";
            btnHelp.UseVisualStyleBackColor = false;
            btnHelp.Click += btnHelp_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.Logo;
            pictureBox1.Location = new Point(542, 116);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(362, 229);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // btnWallet
            // 
            btnWallet.BackColor = Color.Silver;
            btnWallet.FlatAppearance.BorderSize = 0;
            btnWallet.FlatStyle = FlatStyle.Flat;
            btnWallet.Font = new Font("Space Mono", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnWallet.Location = new Point(813, 431);
            btnWallet.Name = "btnWallet";
            btnWallet.Size = new Size(129, 33);
            btnWallet.TabIndex = 5;
            btnWallet.Text = "Wallet";
            btnWallet.UseVisualStyleBackColor = false;
            btnWallet.Click += btnWallet_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Background;
            ClientSize = new Size(1464, 731);
            Controls.Add(btnWallet);
            Controls.Add(pictureBox1);
            Controls.Add(btnHelp);
            Controls.Add(btnExit);
            Controls.Add(btnStart);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Color Game";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnStart;
        private Button btnExit;
        private Button btnHelp;
        private PictureBox pictureBox1;
        private Button btnWallet;
    }
}
