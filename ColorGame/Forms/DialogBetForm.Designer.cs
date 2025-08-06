namespace ColorGame.Forms
{
    partial class DialogBetForm
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
            customLabel1 = new ColorGame.CustomControls.CustomLabel();
            btnQuickSelect1 = new ColorGame.CustomControls.CustomButton();
            textBoxAmount = new TextBox();
            btnQuickSelect2 = new ColorGame.CustomControls.CustomButton();
            btnQuickSelect4 = new ColorGame.CustomControls.CustomButton();
            btnQuickSelect3 = new ColorGame.CustomControls.CustomButton();
            btnQuickSelect5 = new ColorGame.CustomControls.CustomButton();
            btnQuickSelect6 = new ColorGame.CustomControls.CustomButton();
            btnQuickSelect7 = new ColorGame.CustomControls.CustomButton();
            customLabel2 = new ColorGame.CustomControls.CustomLabel();
            labelQuick = new ColorGame.CustomControls.CustomLabel();
            btnApply = new ColorGame.CustomControls.CustomButton();
            btnCancel = new ColorGame.CustomControls.CustomButton();
            btnRemoveBet = new ColorGame.CustomControls.CustomButton();
            btnClose = new PictureBox();
            labelCurrentBalance = new Label();
            ((System.ComponentModel.ISupportInitialize)btnClose).BeginInit();
            SuspendLayout();
            // 
            // customLabel1
            // 
            customLabel1.AutoSize = true;
            customLabel1.BackColor = Color.Transparent;
            customLabel1.Font = new Font("Space Mono", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            customLabel1.ForeColor = Color.Black;
            customLabel1.GlowColor = Color.Transparent;
            customLabel1.GlowSize = 1;
            customLabel1.Location = new Point(21, 20);
            customLabel1.Name = "customLabel1";
            customLabel1.Size = new Size(216, 28);
            customLabel1.TabIndex = 0;
            customLabel1.Text = "Select Bet Amount";
            // 
            // btnQuickSelect1
            // 
            btnQuickSelect1.BackColor = Color.Transparent;
            btnQuickSelect1.CornerRadius = 5;
            btnQuickSelect1.EnableHover = false;
            btnQuickSelect1.FlatAppearance.BorderSize = 0;
            btnQuickSelect1.FlatStyle = FlatStyle.Flat;
            btnQuickSelect1.Font = new Font("Space Mono", 9.749999F);
            btnQuickSelect1.ForeColor = Color.Black;
            btnQuickSelect1.GlowColor = Color.Black;
            btnQuickSelect1.GlowSize = 0;
            btnQuickSelect1.GradientAngle = 45F;
            btnQuickSelect1.GradientColor1 = Color.WhiteSmoke;
            btnQuickSelect1.GradientColor2 = Color.FromArgb(229, 231, 235);
            btnQuickSelect1.HoverOverlayColor = Color.FromArgb(80, 255, 255, 255);
            btnQuickSelect1.Location = new Point(21, 207);
            btnQuickSelect1.Name = "btnQuickSelect1";
            btnQuickSelect1.Size = new Size(140, 35);
            btnQuickSelect1.TabIndex = 1;
            btnQuickSelect1.Tag = "Bet";
            btnQuickSelect1.Text = "500";
            btnQuickSelect1.UseVisualStyleBackColor = false;
            btnQuickSelect1.Click += btnQuickSelect1_Click;
            btnQuickSelect1.MouseLeave += btnQuickSelect1_MouseLeave;
            btnQuickSelect1.MouseHover += btnQuickSelect1_MouseHover;
            // 
            // textBoxAmount
            // 
            textBoxAmount.BorderStyle = BorderStyle.FixedSingle;
            textBoxAmount.Font = new Font("Space Mono", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxAmount.Location = new Point(21, 106);
            textBoxAmount.Multiline = true;
            textBoxAmount.Name = "textBoxAmount";
            textBoxAmount.Size = new Size(451, 42);
            textBoxAmount.TabIndex = 2;
            textBoxAmount.Text = "0";
            textBoxAmount.TextChanged += textBoxAmount_TextChanged;
            textBoxAmount.KeyPress += textBoxAmount_KeyPress;
            // 
            // btnQuickSelect2
            // 
            btnQuickSelect2.BackColor = Color.Transparent;
            btnQuickSelect2.CornerRadius = 5;
            btnQuickSelect2.EnableHover = false;
            btnQuickSelect2.FlatAppearance.BorderSize = 0;
            btnQuickSelect2.FlatStyle = FlatStyle.Flat;
            btnQuickSelect2.Font = new Font("Space Mono", 9.749999F);
            btnQuickSelect2.ForeColor = Color.Black;
            btnQuickSelect2.GlowColor = Color.Black;
            btnQuickSelect2.GlowSize = 0;
            btnQuickSelect2.GradientAngle = 45F;
            btnQuickSelect2.GradientColor1 = Color.WhiteSmoke;
            btnQuickSelect2.GradientColor2 = Color.FromArgb(229, 231, 235);
            btnQuickSelect2.HoverOverlayColor = Color.FromArgb(80, 255, 255, 255);
            btnQuickSelect2.Location = new Point(176, 207);
            btnQuickSelect2.Name = "btnQuickSelect2";
            btnQuickSelect2.Size = new Size(140, 35);
            btnQuickSelect2.TabIndex = 3;
            btnQuickSelect2.Tag = "Bet";
            btnQuickSelect2.Text = "1,000";
            btnQuickSelect2.UseVisualStyleBackColor = false;
            btnQuickSelect2.Click += btnQuickSelect2_Click;
            btnQuickSelect2.MouseLeave += btnQuickSelect2_MouseLeave;
            btnQuickSelect2.MouseHover += btnQuickSelect2_MouseHover;
            // 
            // btnQuickSelect4
            // 
            btnQuickSelect4.BackColor = Color.Transparent;
            btnQuickSelect4.CornerRadius = 5;
            btnQuickSelect4.EnableHover = false;
            btnQuickSelect4.FlatAppearance.BorderSize = 0;
            btnQuickSelect4.FlatStyle = FlatStyle.Flat;
            btnQuickSelect4.Font = new Font("Space Mono", 9.749999F);
            btnQuickSelect4.ForeColor = Color.Black;
            btnQuickSelect4.GlowColor = Color.Black;
            btnQuickSelect4.GlowSize = 8;
            btnQuickSelect4.GradientAngle = 45F;
            btnQuickSelect4.GradientColor1 = Color.WhiteSmoke;
            btnQuickSelect4.GradientColor2 = Color.FromArgb(229, 231, 235);
            btnQuickSelect4.HoverOverlayColor = Color.FromArgb(80, 255, 255, 255);
            btnQuickSelect4.Location = new Point(21, 254);
            btnQuickSelect4.Name = "btnQuickSelect4";
            btnQuickSelect4.Size = new Size(140, 35);
            btnQuickSelect4.TabIndex = 4;
            btnQuickSelect4.Tag = "Bet";
            btnQuickSelect4.Text = "10,000";
            btnQuickSelect4.UseVisualStyleBackColor = false;
            btnQuickSelect4.MouseClick += btnQuickSelect4_MouseClick;
            btnQuickSelect4.MouseLeave += btnQuickSelect4_MouseLeave;
            btnQuickSelect4.MouseHover += btnQuickSelect4_MouseHover;
            // 
            // btnQuickSelect3
            // 
            btnQuickSelect3.BackColor = Color.Transparent;
            btnQuickSelect3.CornerRadius = 5;
            btnQuickSelect3.EnableHover = false;
            btnQuickSelect3.FlatAppearance.BorderSize = 0;
            btnQuickSelect3.FlatStyle = FlatStyle.Flat;
            btnQuickSelect3.Font = new Font("Space Mono", 9.749999F);
            btnQuickSelect3.ForeColor = Color.Black;
            btnQuickSelect3.GlowColor = Color.Black;
            btnQuickSelect3.GlowSize = 8;
            btnQuickSelect3.GradientAngle = 45F;
            btnQuickSelect3.GradientColor1 = Color.WhiteSmoke;
            btnQuickSelect3.GradientColor2 = Color.FromArgb(229, 231, 235);
            btnQuickSelect3.HoverOverlayColor = Color.FromArgb(80, 255, 255, 255);
            btnQuickSelect3.Location = new Point(332, 207);
            btnQuickSelect3.Name = "btnQuickSelect3";
            btnQuickSelect3.Size = new Size(140, 35);
            btnQuickSelect3.TabIndex = 5;
            btnQuickSelect3.Tag = "Bet";
            btnQuickSelect3.Text = "5,000";
            btnQuickSelect3.UseVisualStyleBackColor = false;
            btnQuickSelect3.Click += btnQuickSelect3_Click;
            btnQuickSelect3.MouseLeave += btnQuickSelect3_MouseLeave;
            btnQuickSelect3.MouseHover += btnQuickSelect3_MouseHover;
            // 
            // btnQuickSelect5
            // 
            btnQuickSelect5.BackColor = Color.Transparent;
            btnQuickSelect5.CornerRadius = 5;
            btnQuickSelect5.EnableHover = false;
            btnQuickSelect5.FlatAppearance.BorderSize = 0;
            btnQuickSelect5.FlatStyle = FlatStyle.Flat;
            btnQuickSelect5.Font = new Font("Space Mono", 9.749999F);
            btnQuickSelect5.ForeColor = Color.Black;
            btnQuickSelect5.GlowColor = Color.Black;
            btnQuickSelect5.GlowSize = 8;
            btnQuickSelect5.GradientAngle = 45F;
            btnQuickSelect5.GradientColor1 = Color.WhiteSmoke;
            btnQuickSelect5.GradientColor2 = Color.FromArgb(229, 231, 235);
            btnQuickSelect5.HoverOverlayColor = Color.FromArgb(80, 255, 255, 255);
            btnQuickSelect5.Location = new Point(176, 254);
            btnQuickSelect5.Name = "btnQuickSelect5";
            btnQuickSelect5.Size = new Size(140, 35);
            btnQuickSelect5.TabIndex = 6;
            btnQuickSelect5.Tag = "Bet";
            btnQuickSelect5.Text = "20,000";
            btnQuickSelect5.UseVisualStyleBackColor = false;
            btnQuickSelect5.Click += btnQuickSelect5_Click;
            btnQuickSelect5.MouseLeave += btnQuickSelect5_MouseLeave;
            btnQuickSelect5.MouseHover += btnQuickSelect5_MouseHover;
            // 
            // btnQuickSelect6
            // 
            btnQuickSelect6.BackColor = Color.Transparent;
            btnQuickSelect6.CornerRadius = 5;
            btnQuickSelect6.EnableHover = false;
            btnQuickSelect6.FlatAppearance.BorderSize = 0;
            btnQuickSelect6.FlatStyle = FlatStyle.Flat;
            btnQuickSelect6.Font = new Font("Space Mono", 9.749999F);
            btnQuickSelect6.ForeColor = Color.Black;
            btnQuickSelect6.GlowColor = Color.Black;
            btnQuickSelect6.GlowSize = 8;
            btnQuickSelect6.GradientAngle = 45F;
            btnQuickSelect6.GradientColor1 = Color.WhiteSmoke;
            btnQuickSelect6.GradientColor2 = Color.FromArgb(229, 231, 235);
            btnQuickSelect6.HoverOverlayColor = Color.FromArgb(80, 255, 255, 255);
            btnQuickSelect6.Location = new Point(332, 254);
            btnQuickSelect6.Name = "btnQuickSelect6";
            btnQuickSelect6.Size = new Size(140, 35);
            btnQuickSelect6.TabIndex = 7;
            btnQuickSelect6.Tag = "Bet";
            btnQuickSelect6.Text = "30,000";
            btnQuickSelect6.UseVisualStyleBackColor = false;
            btnQuickSelect6.MouseClick += btnQuickSelect6_MouseClick;
            btnQuickSelect6.MouseLeave += btnQuickSelect6_MouseLeave;
            btnQuickSelect6.MouseHover += btnQuickSelect6_MouseHover;
            // 
            // btnQuickSelect7
            // 
            btnQuickSelect7.BackColor = Color.Transparent;
            btnQuickSelect7.CornerRadius = 5;
            btnQuickSelect7.EnableHover = false;
            btnQuickSelect7.FlatAppearance.BorderSize = 0;
            btnQuickSelect7.FlatStyle = FlatStyle.Flat;
            btnQuickSelect7.Font = new Font("Space Mono", 9.749999F);
            btnQuickSelect7.ForeColor = Color.Black;
            btnQuickSelect7.GlowColor = Color.Black;
            btnQuickSelect7.GlowSize = 8;
            btnQuickSelect7.GradientAngle = 45F;
            btnQuickSelect7.GradientColor1 = Color.WhiteSmoke;
            btnQuickSelect7.GradientColor2 = Color.FromArgb(229, 231, 235);
            btnQuickSelect7.HoverOverlayColor = Color.FromArgb(80, 255, 255, 255);
            btnQuickSelect7.Location = new Point(21, 301);
            btnQuickSelect7.Name = "btnQuickSelect7";
            btnQuickSelect7.Size = new Size(140, 35);
            btnQuickSelect7.TabIndex = 8;
            btnQuickSelect7.Tag = "Bet";
            btnQuickSelect7.Text = "50,000";
            btnQuickSelect7.UseVisualStyleBackColor = false;
            btnQuickSelect7.MouseClick += btnQuickSelect7_MouseClick;
            btnQuickSelect7.MouseLeave += btnQuickSelect7_MouseLeave;
            btnQuickSelect7.MouseHover += btnQuickSelect7_MouseHover;
            // 
            // customLabel2
            // 
            customLabel2.AutoSize = true;
            customLabel2.Font = new Font("Space Mono", 11.249999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            customLabel2.ForeColor = Color.Black;
            customLabel2.GlowColor = Color.Transparent;
            customLabel2.GlowSize = 1;
            customLabel2.Location = new Point(21, 72);
            customLabel2.Name = "customLabel2";
            customLabel2.Size = new Size(136, 22);
            customLabel2.TabIndex = 10;
            customLabel2.Text = "Custom Amount!";
            // 
            // labelQuick
            // 
            labelQuick.AutoSize = true;
            labelQuick.Font = new Font("Space Mono", 11.249999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelQuick.ForeColor = Color.Black;
            labelQuick.GlowColor = Color.Transparent;
            labelQuick.GlowSize = 1;
            labelQuick.Location = new Point(21, 173);
            labelQuick.Name = "labelQuick";
            labelQuick.Size = new Size(127, 22);
            labelQuick.TabIndex = 11;
            labelQuick.Text = "Quick Select!";
            // 
            // btnApply
            // 
            btnApply.BackColor = Color.Transparent;
            btnApply.CornerRadius = 5;
            btnApply.EnableHover = false;
            btnApply.FlatAppearance.BorderSize = 0;
            btnApply.FlatStyle = FlatStyle.Flat;
            btnApply.Font = new Font("Space Mono", 9.749999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnApply.ForeColor = Color.White;
            btnApply.GlowColor = Color.Black;
            btnApply.GlowSize = 8;
            btnApply.GradientAngle = 45F;
            btnApply.GradientColor1 = Color.DarkOrange;
            btnApply.GradientColor2 = Color.Salmon;
            btnApply.HoverOverlayColor = Color.FromArgb(80, 255, 255, 255);
            btnApply.Location = new Point(332, 388);
            btnApply.Name = "btnApply";
            btnApply.Size = new Size(140, 35);
            btnApply.TabIndex = 12;
            btnApply.Text = "Apply";
            btnApply.UseVisualStyleBackColor = false;
            btnApply.Click += btnApply_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.Transparent;
            btnCancel.CornerRadius = 5;
            btnCancel.EnableHover = false;
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Space Mono", 9.749999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancel.ForeColor = Color.Black;
            btnCancel.GlowColor = Color.Black;
            btnCancel.GlowSize = 15;
            btnCancel.GradientAngle = 45F;
            btnCancel.GradientColor1 = Color.WhiteSmoke;
            btnCancel.GradientColor2 = Color.FromArgb(229, 231, 235);
            btnCancel.HoverOverlayColor = Color.FromArgb(80, 255, 255, 255);
            btnCancel.Location = new Point(21, 388);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(140, 35);
            btnCancel.TabIndex = 13;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnRemoveBet
            // 
            btnRemoveBet.BackColor = Color.Transparent;
            btnRemoveBet.CornerRadius = 5;
            btnRemoveBet.EnableHover = false;
            btnRemoveBet.FlatAppearance.BorderSize = 0;
            btnRemoveBet.FlatStyle = FlatStyle.Flat;
            btnRemoveBet.Font = new Font("Space Mono", 9.749999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRemoveBet.ForeColor = Color.White;
            btnRemoveBet.GlowColor = Color.Black;
            btnRemoveBet.GlowSize = 15;
            btnRemoveBet.GradientAngle = 45F;
            btnRemoveBet.GradientColor1 = Color.BurlyWood;
            btnRemoveBet.GradientColor2 = Color.LightCoral;
            btnRemoveBet.HoverOverlayColor = Color.FromArgb(80, 255, 255, 255);
            btnRemoveBet.Location = new Point(176, 388);
            btnRemoveBet.Name = "btnRemoveBet";
            btnRemoveBet.Size = new Size(140, 35);
            btnRemoveBet.TabIndex = 14;
            btnRemoveBet.Text = "Remove Bet";
            btnRemoveBet.UseVisualStyleBackColor = false;
            btnRemoveBet.Click += btnRemoveBet_Click;
            // 
            // btnClose
            // 
            btnClose.Image = Properties.Resources.Close;
            btnClose.Location = new Point(458, 12);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(26, 23);
            btnClose.SizeMode = PictureBoxSizeMode.StretchImage;
            btnClose.TabIndex = 15;
            btnClose.TabStop = false;
            btnClose.Click += btnClose_Click;
            btnClose.MouseEnter += btnClose_MouseEnter;
            btnClose.MouseLeave += btnClose_MouseLeave;
            // 
            // labelCurrentBalance
            // 
            labelCurrentBalance.AutoSize = true;
            labelCurrentBalance.Location = new Point(348, 77);
            labelCurrentBalance.Name = "labelCurrentBalance";
            labelCurrentBalance.Size = new Size(124, 15);
            labelCurrentBalance.TabIndex = 16;
            labelCurrentBalance.Text = "Current Balance: 1,000";
            // 
            // DialogBetForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(498, 438);
            Controls.Add(labelCurrentBalance);
            Controls.Add(btnClose);
            Controls.Add(btnRemoveBet);
            Controls.Add(btnCancel);
            Controls.Add(btnApply);
            Controls.Add(labelQuick);
            Controls.Add(customLabel2);
            Controls.Add(btnQuickSelect7);
            Controls.Add(btnQuickSelect6);
            Controls.Add(btnQuickSelect5);
            Controls.Add(btnQuickSelect3);
            Controls.Add(btnQuickSelect4);
            Controls.Add(btnQuickSelect2);
            Controls.Add(textBoxAmount);
            Controls.Add(btnQuickSelect1);
            Controls.Add(customLabel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "DialogBetForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DialogBetForm";
            Load += DialogBetForm_Load;
            ((System.ComponentModel.ISupportInitialize)btnClose).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CustomControls.CustomLabel customLabel1;
        private CustomControls.CustomButton btnQuickSelect1;
        private TextBox textBoxAmount;
        private CustomControls.CustomButton btnQuickSelect2;
        private CustomControls.CustomButton btnQuickSelect4;
        private CustomControls.CustomButton btnQuickSelect3;
        private CustomControls.CustomButton btnQuickSelect5;
        private CustomControls.CustomButton btnQuickSelect6;
        private CustomControls.CustomButton btnQuickSelect7;
        private CustomControls.CustomLabel customLabel2;
        private CustomControls.CustomLabel labelQuick;
        private CustomControls.CustomButton btnApply;
        private CustomControls.CustomButton btnCancel;
        private CustomControls.CustomButton btnRemoveBet;
        private PictureBox btnClose;
        private Label labelCurrentBalance;
    }
}