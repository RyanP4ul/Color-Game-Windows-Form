namespace ColorGame
{
    partial class BetHistoryListItem
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
            labelResultBetAmount = new Label();
            labelNumber = new ColorGame.CustomControls.CustomLabel();
            customPanel1 = new ColorGame.CustomControls.CustomPanel();
            customPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // labelResultBetAmount
            // 
            labelResultBetAmount.AutoSize = true;
            labelResultBetAmount.Font = new Font("Space Mono", 11.249999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelResultBetAmount.ForeColor = Color.Red;
            labelResultBetAmount.Location = new Point(107, 29);
            labelResultBetAmount.Name = "labelResultBetAmount";
            labelResultBetAmount.Size = new Size(55, 22);
            labelResultBetAmount.TabIndex = 1;
            labelResultBetAmount.Text = "-1000";
            // 
            // labelNumber
            // 
            labelNumber.AutoSize = true;
            labelNumber.BackColor = Color.Transparent;
            labelNumber.ForeColor = Color.Black;
            labelNumber.GlowColor = Color.Cyan;
            labelNumber.GlowSize = 1;
            labelNumber.Location = new Point(12, 8);
            labelNumber.Name = "labelNumber";
            labelNumber.Size = new Size(54, 15);
            labelNumber.TabIndex = 0;
            labelNumber.Text = "Game #1";
            // 
            // customPanel1
            // 
            customPanel1.BackColor = Color.Transparent;
            customPanel1.BorderColor = Color.FromArgb(130, 84, 55);
            customPanel1.BorderThickness = 2F;
            customPanel1.Controls.Add(labelResultBetAmount);
            customPanel1.Controls.Add(labelNumber);
            customPanel1.CornerRadius = 1;
            customPanel1.Dock = DockStyle.Fill;
            customPanel1.GradientAngle = 45F;
            customPanel1.GradientColor1 = Color.FromArgb(238, 140, 55);
            customPanel1.GradientColor2 = Color.FromArgb(255, 204, 51);
            customPanel1.Location = new Point(0, 0);
            customPanel1.Name = "customPanel1";
            customPanel1.Opacity = 180;
            customPanel1.Size = new Size(238, 57);
            customPanel1.TabIndex = 41;
            // 
            // BetHistoryListItem
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(customPanel1);
            Name = "BetHistoryListItem";
            Size = new Size(238, 57);
            customPanel1.ResumeLayout(false);
            customPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Label labelResultBetAmount;
        private CustomControls.CustomLabel labelNumber;
        private CustomControls.CustomPanel customPanel1;
    }
}
