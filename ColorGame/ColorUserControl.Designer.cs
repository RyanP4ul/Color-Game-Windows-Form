namespace ColorGame
{
    partial class ColorUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            labelBetAmount = new ColorGame.CustomControls.CustomLabel();
            pictureBoxCoins = new PictureBox();
            panel = new ColorGame.CustomControls.CustomPanel();
            customLabelName = new ColorGame.CustomControls.CustomLabel();
            ((System.ComponentModel.ISupportInitialize)pictureBoxCoins).BeginInit();
            panel.SuspendLayout();
            SuspendLayout();
            // 
            // labelBetAmount
            // 
            labelBetAmount.AutoSize = true;
            labelBetAmount.Font = new Font("Space Mono", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelBetAmount.ForeColor = Color.White;
            labelBetAmount.GlowColor = Color.Black;
            labelBetAmount.GlowSize = 7;
            labelBetAmount.Location = new Point(35, 78);
            labelBetAmount.Name = "labelBetAmount";
            labelBetAmount.Size = new Size(24, 28);
            labelBetAmount.TabIndex = 25;
            labelBetAmount.Text = "0";
            // 
            // pictureBoxCoins
            // 
            pictureBoxCoins.Image = Properties.Resources.Currency;
            pictureBoxCoins.Location = new Point(9, 82);
            pictureBoxCoins.Name = "pictureBoxCoins";
            pictureBoxCoins.Size = new Size(20, 20);
            pictureBoxCoins.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxCoins.TabIndex = 26;
            pictureBoxCoins.TabStop = false;
            // 
            // panel
            // 
            panel.BackColor = Color.Transparent;
            panel.BorderColor = Color.WhiteSmoke;
            panel.BorderThickness = 2F;
            panel.Controls.Add(customLabelName);
            panel.Controls.Add(pictureBoxCoins);
            panel.Controls.Add(labelBetAmount);
            panel.CornerRadius = 1;
            panel.Dock = DockStyle.Fill;
            panel.GradientAngle = 45F;
            panel.GradientColor1 = Color.Azure;
            panel.GradientColor2 = Color.SlateGray;
            panel.Location = new Point(0, 0);
            panel.Name = "panel";
            panel.Opacity = 180;
            panel.Size = new Size(162, 109);
            panel.TabIndex = 27;
            panel.MouseClick += panel_MouseClick;
            panel.MouseEnter += panel_MouseEnter;
            panel.MouseLeave += panel_MouseLeave;
            // 
            // customLabelName
            // 
            customLabelName.AutoSize = true;
            customLabelName.Font = new Font("Space Mono", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            customLabelName.ForeColor = Color.White;
            customLabelName.GlowColor = Color.Black;
            customLabelName.GlowSize = 6;
            customLabelName.Location = new Point(9, 9);
            customLabelName.Name = "customLabelName";
            customLabelName.Size = new Size(36, 17);
            customLabelName.TabIndex = 27;
            customLabelName.Text = "None";
            // 
            // ColorUserControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel);
            Name = "ColorUserControl";
            Size = new Size(162, 109);
            ((System.ComponentModel.ISupportInitialize)pictureBoxCoins).EndInit();
            panel.ResumeLayout(false);
            panel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private CustomControls.CustomLabel labelBetAmount;
        private PictureBox pictureBoxCoins;
        private CustomControls.CustomPanel panel;
        private CustomControls.CustomLabel customLabelName;
    }
}
