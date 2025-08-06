namespace ColorGame.Forms
{
    partial class WithdrawAndDepositForm
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
            pictureBoxClose = new PictureBox();
            labelTransactionType = new Label();
            customLabel2 = new ColorGame.CustomControls.CustomLabel();
            textBoxAmount = new TextBox();
            btnQuickSelect1 = new ColorGame.CustomControls.CustomButton();
            btnQuickSelect2 = new ColorGame.CustomControls.CustomButton();
            btnQuickSelect3 = new ColorGame.CustomControls.CustomButton();
            btnQuickSelect6 = new ColorGame.CustomControls.CustomButton();
            btnQuickSelect5 = new ColorGame.CustomControls.CustomButton();
            btnQuickSelect4 = new ColorGame.CustomControls.CustomButton();
            label11 = new Label();
            pictureBoxPaymentMethod = new PictureBox();
            labelPaymentMethod = new ColorGame.CustomControls.CustomLabel();
            labelMin = new ColorGame.CustomControls.CustomLabel();
            labelAvailable = new ColorGame.CustomControls.CustomLabel();
            labelMaxAmount = new Label();
            labelApproximately = new ColorGame.CustomControls.CustomLabel();
            btnAction = new ColorGame.CustomControls.CustomButton();
            ((System.ComponentModel.ISupportInitialize)pictureBoxClose).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxPaymentMethod).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxClose
            // 
            pictureBoxClose.Image = Properties.Resources.Close;
            pictureBoxClose.Location = new Point(458, 12);
            pictureBoxClose.Name = "pictureBoxClose";
            pictureBoxClose.Size = new Size(26, 23);
            pictureBoxClose.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxClose.TabIndex = 54;
            pictureBoxClose.TabStop = false;
            pictureBoxClose.Click += pictureBoxClose_Click;
            pictureBoxClose.MouseEnter += pictureBoxClose_MouseEnter;
            pictureBoxClose.MouseLeave += pictureBoxClose_MouseLeave;
            // 
            // labelTransactionType
            // 
            labelTransactionType.AutoSize = true;
            labelTransactionType.Font = new Font("Space Mono", 11.249999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTransactionType.Location = new Point(18, 18);
            labelTransactionType.Name = "labelTransactionType";
            labelTransactionType.Size = new Size(82, 22);
            labelTransactionType.TabIndex = 55;
            labelTransactionType.Text = "Withdraw";
            // 
            // customLabel2
            // 
            customLabel2.AutoSize = true;
            customLabel2.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            customLabel2.ForeColor = Color.Black;
            customLabel2.GlowColor = Color.Transparent;
            customLabel2.GlowSize = 1;
            customLabel2.Location = new Point(18, 81);
            customLabel2.Name = "customLabel2";
            customLabel2.Size = new Size(27, 15);
            customLabel2.TabIndex = 58;
            customLabel2.Text = "Via:";
            // 
            // textBoxAmount
            // 
            textBoxAmount.BorderStyle = BorderStyle.FixedSingle;
            textBoxAmount.Font = new Font("Space Mono", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxAmount.Location = new Point(58, 106);
            textBoxAmount.Multiline = true;
            textBoxAmount.Name = "textBoxAmount";
            textBoxAmount.Size = new Size(414, 42);
            textBoxAmount.TabIndex = 57;
            textBoxAmount.Text = "0";
            textBoxAmount.TextChanged += textBoxAmount_TextChanged;
            textBoxAmount.KeyPress += textBoxAmount_KeyPress;
            // 
            // btnQuickSelect1
            // 
            btnQuickSelect1.BackColor = Color.Transparent;
            btnQuickSelect1.CornerRadius = 5;
            btnQuickSelect1.EnableHover = false;
            btnQuickSelect1.FlatAppearance.BorderSize = 0;
            btnQuickSelect1.FlatStyle = FlatStyle.Flat;
            btnQuickSelect1.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnQuickSelect1.ForeColor = Color.Black;
            btnQuickSelect1.GlowColor = Color.Black;
            btnQuickSelect1.GlowSize = 0;
            btnQuickSelect1.GradientAngle = 45F;
            btnQuickSelect1.GradientColor1 = Color.WhiteSmoke;
            btnQuickSelect1.GradientColor2 = Color.FromArgb(229, 231, 235);
            btnQuickSelect1.HoverOverlayColor = Color.FromArgb(80, 255, 255, 255);
            btnQuickSelect1.Location = new Point(18, 231);
            btnQuickSelect1.Name = "btnQuickSelect1";
            btnQuickSelect1.Size = new Size(140, 35);
            btnQuickSelect1.TabIndex = 56;
            btnQuickSelect1.Tag = "Bet";
            btnQuickSelect1.Text = "₱500";
            btnQuickSelect1.UseVisualStyleBackColor = false;
            btnQuickSelect1.Click += btnQuickSelect1_Click;
            // 
            // btnQuickSelect2
            // 
            btnQuickSelect2.BackColor = Color.Transparent;
            btnQuickSelect2.CornerRadius = 5;
            btnQuickSelect2.EnableHover = false;
            btnQuickSelect2.FlatAppearance.BorderSize = 0;
            btnQuickSelect2.FlatStyle = FlatStyle.Flat;
            btnQuickSelect2.Font = new Font("Arial", 9.75F);
            btnQuickSelect2.ForeColor = Color.Black;
            btnQuickSelect2.GlowColor = Color.Black;
            btnQuickSelect2.GlowSize = 0;
            btnQuickSelect2.GradientAngle = 45F;
            btnQuickSelect2.GradientColor1 = Color.WhiteSmoke;
            btnQuickSelect2.GradientColor2 = Color.FromArgb(229, 231, 235);
            btnQuickSelect2.HoverOverlayColor = Color.FromArgb(80, 255, 255, 255);
            btnQuickSelect2.Location = new Point(176, 231);
            btnQuickSelect2.Name = "btnQuickSelect2";
            btnQuickSelect2.Size = new Size(140, 35);
            btnQuickSelect2.TabIndex = 59;
            btnQuickSelect2.Tag = "Bet";
            btnQuickSelect2.Text = "₱1,000";
            btnQuickSelect2.UseVisualStyleBackColor = false;
            btnQuickSelect2.Click += btnQuickSelect2_Click;
            // 
            // btnQuickSelect3
            // 
            btnQuickSelect3.BackColor = Color.Transparent;
            btnQuickSelect3.CornerRadius = 5;
            btnQuickSelect3.EnableHover = false;
            btnQuickSelect3.FlatAppearance.BorderSize = 0;
            btnQuickSelect3.FlatStyle = FlatStyle.Flat;
            btnQuickSelect3.Font = new Font("Arial", 9.75F);
            btnQuickSelect3.ForeColor = Color.Black;
            btnQuickSelect3.GlowColor = Color.Black;
            btnQuickSelect3.GlowSize = 0;
            btnQuickSelect3.GradientAngle = 45F;
            btnQuickSelect3.GradientColor1 = Color.WhiteSmoke;
            btnQuickSelect3.GradientColor2 = Color.FromArgb(229, 231, 235);
            btnQuickSelect3.HoverOverlayColor = Color.FromArgb(80, 255, 255, 255);
            btnQuickSelect3.Location = new Point(332, 231);
            btnQuickSelect3.Name = "btnQuickSelect3";
            btnQuickSelect3.Size = new Size(140, 35);
            btnQuickSelect3.TabIndex = 60;
            btnQuickSelect3.Tag = "Bet";
            btnQuickSelect3.Text = "₱2,000";
            btnQuickSelect3.UseVisualStyleBackColor = false;
            btnQuickSelect3.Click += btnQuickSelect3_Click;
            // 
            // btnQuickSelect6
            // 
            btnQuickSelect6.BackColor = Color.Transparent;
            btnQuickSelect6.CornerRadius = 5;
            btnQuickSelect6.EnableHover = false;
            btnQuickSelect6.FlatAppearance.BorderSize = 0;
            btnQuickSelect6.FlatStyle = FlatStyle.Flat;
            btnQuickSelect6.Font = new Font("Arial", 9.75F);
            btnQuickSelect6.ForeColor = Color.Black;
            btnQuickSelect6.GlowColor = Color.Black;
            btnQuickSelect6.GlowSize = 0;
            btnQuickSelect6.GradientAngle = 45F;
            btnQuickSelect6.GradientColor1 = Color.WhiteSmoke;
            btnQuickSelect6.GradientColor2 = Color.FromArgb(229, 231, 235);
            btnQuickSelect6.HoverOverlayColor = Color.FromArgb(80, 255, 255, 255);
            btnQuickSelect6.Location = new Point(332, 281);
            btnQuickSelect6.Name = "btnQuickSelect6";
            btnQuickSelect6.Size = new Size(140, 35);
            btnQuickSelect6.TabIndex = 63;
            btnQuickSelect6.Tag = "Bet";
            btnQuickSelect6.Text = "₱10,000";
            btnQuickSelect6.UseVisualStyleBackColor = false;
            btnQuickSelect6.Click += btnQuickSelect6_Click;
            // 
            // btnQuickSelect5
            // 
            btnQuickSelect5.BackColor = Color.Transparent;
            btnQuickSelect5.CornerRadius = 5;
            btnQuickSelect5.EnableHover = false;
            btnQuickSelect5.FlatAppearance.BorderSize = 0;
            btnQuickSelect5.FlatStyle = FlatStyle.Flat;
            btnQuickSelect5.Font = new Font("Arial", 9.75F);
            btnQuickSelect5.ForeColor = Color.Black;
            btnQuickSelect5.GlowColor = Color.Black;
            btnQuickSelect5.GlowSize = 0;
            btnQuickSelect5.GradientAngle = 45F;
            btnQuickSelect5.GradientColor1 = Color.WhiteSmoke;
            btnQuickSelect5.GradientColor2 = Color.FromArgb(229, 231, 235);
            btnQuickSelect5.HoverOverlayColor = Color.FromArgb(80, 255, 255, 255);
            btnQuickSelect5.Location = new Point(176, 281);
            btnQuickSelect5.Name = "btnQuickSelect5";
            btnQuickSelect5.Size = new Size(140, 35);
            btnQuickSelect5.TabIndex = 62;
            btnQuickSelect5.Tag = "Bet";
            btnQuickSelect5.Text = "₱5,000";
            btnQuickSelect5.UseVisualStyleBackColor = false;
            btnQuickSelect5.Click += btnQuickSelect5_Click;
            // 
            // btnQuickSelect4
            // 
            btnQuickSelect4.BackColor = Color.Transparent;
            btnQuickSelect4.CornerRadius = 5;
            btnQuickSelect4.EnableHover = false;
            btnQuickSelect4.FlatAppearance.BorderSize = 0;
            btnQuickSelect4.FlatStyle = FlatStyle.Flat;
            btnQuickSelect4.Font = new Font("Arial", 9.75F);
            btnQuickSelect4.ForeColor = Color.Black;
            btnQuickSelect4.GlowColor = Color.Black;
            btnQuickSelect4.GlowSize = 0;
            btnQuickSelect4.GradientAngle = 45F;
            btnQuickSelect4.GradientColor1 = Color.WhiteSmoke;
            btnQuickSelect4.GradientColor2 = Color.FromArgb(229, 231, 235);
            btnQuickSelect4.HoverOverlayColor = Color.FromArgb(80, 255, 255, 255);
            btnQuickSelect4.Location = new Point(18, 281);
            btnQuickSelect4.Name = "btnQuickSelect4";
            btnQuickSelect4.Size = new Size(140, 35);
            btnQuickSelect4.TabIndex = 61;
            btnQuickSelect4.Tag = "Bet";
            btnQuickSelect4.Text = "₱3,000";
            btnQuickSelect4.UseVisualStyleBackColor = false;
            btnQuickSelect4.Click += btnQuickSelect4_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.Transparent;
            label11.Font = new Font("Arial", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(18, 111);
            label11.Name = "label11";
            label11.Size = new Size(34, 34);
            label11.TabIndex = 64;
            label11.Text = "₱";
            // 
            // pictureBoxPaymentMethod
            // 
            pictureBoxPaymentMethod.Image = Properties.Resources.GCash;
            pictureBoxPaymentMethod.Location = new Point(387, 83);
            pictureBoxPaymentMethod.Name = "pictureBoxPaymentMethod";
            pictureBoxPaymentMethod.Size = new Size(20, 17);
            pictureBoxPaymentMethod.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxPaymentMethod.TabIndex = 66;
            pictureBoxPaymentMethod.TabStop = false;
            // 
            // labelPaymentMethod
            // 
            labelPaymentMethod.FlatStyle = FlatStyle.Popup;
            labelPaymentMethod.Font = new Font("Space Mono", 11.249999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelPaymentMethod.ForeColor = Color.FromArgb(37, 99, 235);
            labelPaymentMethod.GlowColor = Color.Transparent;
            labelPaymentMethod.GlowSize = 1;
            labelPaymentMethod.Location = new Point(410, 81);
            labelPaymentMethod.Name = "labelPaymentMethod";
            labelPaymentMethod.Size = new Size(63, 22);
            labelPaymentMethod.TabIndex = 67;
            labelPaymentMethod.Text = "GCash";
            labelPaymentMethod.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelMin
            // 
            labelMin.AutoSize = true;
            labelMin.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelMin.ForeColor = Color.Black;
            labelMin.GlowColor = Color.Transparent;
            labelMin.GlowSize = 1;
            labelMin.Location = new Point(18, 177);
            labelMin.Name = "labelMin";
            labelMin.Size = new Size(51, 15);
            labelMin.TabIndex = 68;
            labelMin.Text = "Min ₱50";
            // 
            // labelAvailable
            // 
            labelAvailable.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelAvailable.ForeColor = Color.Black;
            labelAvailable.GlowColor = Color.Transparent;
            labelAvailable.GlowSize = 1;
            labelAvailable.Location = new Point(18, 195);
            labelAvailable.Name = "labelAvailable";
            labelAvailable.Size = new Size(181, 23);
            labelAvailable.TabIndex = 69;
            labelAvailable.Text = "Available game coins: ₱100";
            // 
            // labelMaxAmount
            // 
            labelMaxAmount.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelMaxAmount.Location = new Point(279, 174);
            labelMaxAmount.Name = "labelMaxAmount";
            labelMaxAmount.Size = new Size(193, 23);
            labelMaxAmount.TabIndex = 71;
            labelMaxAmount.Text = "Max: ₱50,000 per transaction";
            labelMaxAmount.TextAlign = ContentAlignment.MiddleRight;
            // 
            // labelApproximately
            // 
            labelApproximately.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelApproximately.ForeColor = Color.FromArgb(202, 138, 4);
            labelApproximately.GlowColor = Color.Transparent;
            labelApproximately.GlowSize = 1;
            labelApproximately.Location = new Point(18, 153);
            labelApproximately.Name = "labelApproximately";
            labelApproximately.Size = new Size(259, 17);
            labelApproximately.TabIndex = 72;
            labelApproximately.Text = " You'll spend approximately 0 game coins";
            // 
            // btnAction
            // 
            btnAction.BackColor = Color.Transparent;
            btnAction.CornerRadius = 5;
            btnAction.EnableHover = false;
            btnAction.FlatAppearance.BorderSize = 0;
            btnAction.FlatStyle = FlatStyle.Flat;
            btnAction.Font = new Font("Space Mono", 9.749999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAction.ForeColor = Color.White;
            btnAction.GlowColor = Color.Black;
            btnAction.GlowSize = 8;
            btnAction.GradientAngle = 45F;
            btnAction.GradientColor1 = Color.MediumSeaGreen;
            btnAction.GradientColor2 = Color.MediumSeaGreen;
            btnAction.HoverOverlayColor = Color.FromArgb(80, 255, 255, 255);
            btnAction.Location = new Point(333, 369);
            btnAction.Name = "btnAction";
            btnAction.Size = new Size(140, 35);
            btnAction.TabIndex = 73;
            btnAction.Text = "Withdraw";
            btnAction.UseVisualStyleBackColor = false;
            btnAction.Click += btnAction_Click;
            // 
            // WithdrawAndDepositForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(498, 426);
            Controls.Add(btnAction);
            Controls.Add(labelApproximately);
            Controls.Add(labelMaxAmount);
            Controls.Add(labelAvailable);
            Controls.Add(labelMin);
            Controls.Add(labelPaymentMethod);
            Controls.Add(pictureBoxPaymentMethod);
            Controls.Add(label11);
            Controls.Add(btnQuickSelect6);
            Controls.Add(btnQuickSelect5);
            Controls.Add(btnQuickSelect4);
            Controls.Add(btnQuickSelect3);
            Controls.Add(btnQuickSelect2);
            Controls.Add(customLabel2);
            Controls.Add(textBoxAmount);
            Controls.Add(btnQuickSelect1);
            Controls.Add(labelTransactionType);
            Controls.Add(pictureBoxClose);
            FormBorderStyle = FormBorderStyle.None;
            Name = "WithdrawAndDepositForm";
            Text = "WithdrawForm";
            Load += WithdrawForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBoxClose).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxPaymentMethod).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBoxClose;
        private Label labelTransactionType;
        private CustomControls.CustomLabel customLabel2;
        private TextBox textBoxAmount;
        private CustomControls.CustomButton btnQuickSelect1;
        private CustomControls.CustomButton btnQuickSelect2;
        private CustomControls.CustomButton btnQuickSelect3;
        private CustomControls.CustomButton btnQuickSelect6;
        private CustomControls.CustomButton btnQuickSelect5;
        private CustomControls.CustomButton btnQuickSelect4;
        private Label label11;
        private PictureBox pictureBoxPaymentMethod;
        private CustomControls.CustomLabel labelPaymentMethod;
        private CustomControls.CustomLabel labelMin;
        private CustomControls.CustomLabel labelAvailable;
        private Label labelMaxAmount;
        private CustomControls.CustomLabel labelApproximately;
        private CustomControls.CustomButton btnAction;
    }
}