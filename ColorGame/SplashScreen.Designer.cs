namespace ColorGame
{
    partial class SplashScreen
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
            labelLoading = new ColorGame.CustomControls.CustomLabel();
            customPanel1 = new ColorGame.CustomControls.CustomPanel();
            pictureBox1 = new PictureBox();
            customPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // labelLoading
            // 
            labelLoading.AutoSize = true;
            labelLoading.Font = new Font("Space Mono", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelLoading.ForeColor = Color.White;
            labelLoading.GlowColor = Color.Black;
            labelLoading.GlowSize = 6;
            labelLoading.Location = new Point(189, 326);
            labelLoading.Name = "labelLoading";
            labelLoading.Size = new Size(192, 28);
            labelLoading.TabIndex = 0;
            labelLoading.Text = "Loading Game...";
            // 
            // customPanel1
            // 
            customPanel1.BackColor = Color.Transparent;
            customPanel1.BorderColor = Color.Black;
            customPanel1.BorderThickness = 0F;
            customPanel1.Controls.Add(pictureBox1);
            customPanel1.Controls.Add(labelLoading);
            customPanel1.CornerRadius = 1;
            customPanel1.Dock = DockStyle.Fill;
            customPanel1.GradientAngle = 45F;
            customPanel1.GradientColor1 = Color.Chocolate;
            customPanel1.GradientColor2 = Color.FromArgb(255, 192, 128);
            customPanel1.Location = new Point(0, 0);
            customPanel1.Name = "customPanel1";
            customPanel1.Opacity = 180;
            customPanel1.Size = new Size(578, 486);
            customPanel1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Logo;
            pictureBox1.Location = new Point(106, 81);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(362, 229);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // SplashScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(578, 486);
            Controls.Add(customPanel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "SplashScreen";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SplashScreen";
            Load += SplashScreen_Load;
            customPanel1.ResumeLayout(false);
            customPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private CustomControls.CustomLabel labelLoading;
        private CustomControls.CustomPanel customPanel1;
        private PictureBox pictureBox1;
    }
}