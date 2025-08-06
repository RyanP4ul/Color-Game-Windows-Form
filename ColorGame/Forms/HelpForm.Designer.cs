namespace ColorGame.Forms
{
    partial class HelpForm
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
            labelHelp = new ColorGame.CustomControls.CustomLabel();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            btnClose = new ColorGame.CustomControls.CustomButton();
            label7 = new Label();
            pictureBoxClose = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBoxClose).BeginInit();
            SuspendLayout();
            // 
            // labelHelp
            // 
            labelHelp.AutoSize = true;
            labelHelp.BackColor = Color.Transparent;
            labelHelp.Font = new Font("Space Mono", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelHelp.ForeColor = Color.Black;
            labelHelp.GlowColor = Color.Transparent;
            labelHelp.GlowSize = 1;
            labelHelp.Location = new Point(21, 20);
            labelHelp.Name = "labelHelp";
            labelHelp.Size = new Size(144, 28);
            labelHelp.TabIndex = 1;
            labelHelp.Text = "Color Rules";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Space Mono", 11.249999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(21, 78);
            label1.Name = "label1";
            label1.Size = new Size(388, 22);
            label1.TabIndex = 2;
            label1.Text = "Welcome to Color Game! Here's how to play:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Space Mono", 9.749999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(21, 117);
            label2.Name = "label2";
            label2.Size = new Size(377, 20);
            label2.TabIndex = 3;
            label2.Text = "1. Select one or more colors to place your bet";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Space Mono", 9.749999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(21, 155);
            label3.Name = "label3";
            label3.Size = new Size(185, 20);
            label3.TabIndex = 4;
            label3.Text = "2. Set your bet amount";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Space Mono", 9.749999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(21, 191);
            label4.Name = "label4";
            label4.Size = new Size(361, 20);
            label4.TabIndex = 5;
            label4.Text = "3. Click the \"Roll\" button to start the game";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Space Mono", 9.749999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(21, 227);
            label5.Name = "label5";
            label5.Size = new Size(441, 20);
            label5.TabIndex = 6;
            label5.Text = "4. If your selected color matches the result, you win!";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Space Mono", 9.749999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(21, 264);
            label6.Name = "label6";
            label6.Size = new Size(449, 20);
            label6.TabIndex = 7;
            label6.Text = "5. Your winnings are calculated based on the multiplier";
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.Transparent;
            btnClose.CornerRadius = 5;
            btnClose.EnableHover = false;
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Space Mono", 9.749999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClose.ForeColor = Color.Black;
            btnClose.GlowColor = Color.Black;
            btnClose.GlowSize = 15;
            btnClose.GradientAngle = 45F;
            btnClose.GradientColor1 = Color.WhiteSmoke;
            btnClose.GradientColor2 = Color.FromArgb(229, 231, 235);
            btnClose.HoverOverlayColor = Color.FromArgb(80, 255, 255, 255);
            btnClose.Location = new Point(322, 379);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(140, 35);
            btnClose.TabIndex = 14;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnCancel_Click;
            btnClose.MouseEnter += btnClose_MouseEnter;
            btnClose.MouseLeave += btnClose_MouseLeave;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Space Mono", 9.749999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(32, 387);
            label7.Name = "label7";
            label7.Size = new Size(193, 20);
            label7.TabIndex = 15;
            label7.Text = "Good luck and have fun!";
            // 
            // pictureBoxClose
            // 
            pictureBoxClose.Image = Properties.Resources.Close;
            pictureBoxClose.Location = new Point(458, 12);
            pictureBoxClose.Name = "pictureBoxClose";
            pictureBoxClose.Size = new Size(26, 23);
            pictureBoxClose.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxClose.TabIndex = 16;
            pictureBoxClose.TabStop = false;
            pictureBoxClose.Click += pictureBoxClose_Click;
            pictureBoxClose.MouseEnter += pictureBoxClose_MouseEnter;
            pictureBoxClose.MouseLeave += pictureBoxClose_MouseLeave;
            // 
            // HelpForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(498, 438);
            Controls.Add(pictureBoxClose);
            Controls.Add(label7);
            Controls.Add(btnClose);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(labelHelp);
            FormBorderStyle = FormBorderStyle.None;
            Name = "HelpForm";
            Text = "HelpForm";
            ((System.ComponentModel.ISupportInitialize)pictureBoxClose).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CustomControls.CustomLabel labelHelp;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private CustomControls.CustomButton btnClose;
        private Label label7;
        private PictureBox pictureBoxClose;
    }
}