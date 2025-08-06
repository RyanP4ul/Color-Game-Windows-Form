namespace ColorGame.Forms
{
    partial class WalletForm
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
            labelSubCurrentBalance = new Label();
            labelCurrentBalance = new Label();
            customPanelPaymentMethod = new ColorGame.CustomControls.CustomPanel();
            labelChangePaymentMethod = new Label();
            labelConversion = new Label();
            labelCurrentPaymentMethod = new Label();
            customPictureBoxPayment = new ColorGame.CustomControls.CustomPictureBox();
            labelPaymentMethod = new Label();
            labelGameWallet = new Label();
            labelSubGameWallet = new Label();
            label9 = new Label();
            btnWithdraw = new ColorGame.CustomControls.CustomButton();
            btnDeposit = new ColorGame.CustomControls.CustomButton();
            labelTransactionHistory = new Label();
            customPanelTransaactionHistory = new ColorGame.CustomControls.CustomPanel();
            panel1 = new Panel();
            flowLayoutPanelTransactionHistory = new FlowLayoutPanel();
            label11 = new Label();
            pictureBoxCoins = new PictureBox();
            labelLastTransaction = new Label();
            pictureBoxClose = new PictureBox();
            customPanelPaymentMethod.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)customPictureBoxPayment).BeginInit();
            customPanelTransaactionHistory.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxCoins).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxClose).BeginInit();
            SuspendLayout();
            // 
            // labelSubCurrentBalance
            // 
            labelSubCurrentBalance.AutoSize = true;
            labelSubCurrentBalance.BackColor = Color.Transparent;
            labelSubCurrentBalance.Font = new Font("Space Mono", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelSubCurrentBalance.ForeColor = SystemColors.ControlDarkDark;
            labelSubCurrentBalance.Location = new Point(142, 81);
            labelSubCurrentBalance.Name = "labelSubCurrentBalance";
            labelSubCurrentBalance.Size = new Size(113, 17);
            labelSubCurrentBalance.TabIndex = 0;
            labelSubCurrentBalance.Text = "Current Balance";
            // 
            // labelCurrentBalance
            // 
            labelCurrentBalance.Font = new Font("Space Mono", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelCurrentBalance.Location = new Point(151, 98);
            labelCurrentBalance.Name = "labelCurrentBalance";
            labelCurrentBalance.Size = new Size(173, 28);
            labelCurrentBalance.TabIndex = 1;
            labelCurrentBalance.Text = "25,000";
            labelCurrentBalance.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // customPanelPaymentMethod
            // 
            customPanelPaymentMethod.BackColor = Color.Transparent;
            customPanelPaymentMethod.BorderColor = Color.FromArgb(240, 241, 242);
            customPanelPaymentMethod.BorderThickness = 0F;
            customPanelPaymentMethod.Controls.Add(labelChangePaymentMethod);
            customPanelPaymentMethod.Controls.Add(labelConversion);
            customPanelPaymentMethod.Controls.Add(labelCurrentPaymentMethod);
            customPanelPaymentMethod.Controls.Add(customPictureBoxPayment);
            customPanelPaymentMethod.Controls.Add(labelPaymentMethod);
            customPanelPaymentMethod.CornerRadius = 8;
            customPanelPaymentMethod.GradientAngle = 45F;
            customPanelPaymentMethod.GradientColor1 = Color.White;
            customPanelPaymentMethod.GradientColor2 = Color.White;
            customPanelPaymentMethod.Location = new Point(31, 161);
            customPanelPaymentMethod.Name = "customPanelPaymentMethod";
            customPanelPaymentMethod.Opacity = 180;
            customPanelPaymentMethod.Size = new Size(577, 118);
            customPanelPaymentMethod.TabIndex = 2;
            // 
            // labelChangePaymentMethod
            // 
            labelChangePaymentMethod.AutoSize = true;
            labelChangePaymentMethod.Font = new Font("Space Mono", 9.749999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelChangePaymentMethod.ForeColor = SystemColors.MenuHighlight;
            labelChangePaymentMethod.Location = new Point(491, 11);
            labelChangePaymentMethod.Name = "labelChangePaymentMethod";
            labelChangePaymentMethod.Size = new Size(73, 20);
            labelChangePaymentMethod.TabIndex = 4;
            labelChangePaymentMethod.Text = "Change >";
            // 
            // labelConversion
            // 
            labelConversion.AutoSize = true;
            labelConversion.Font = new Font("Space Mono", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelConversion.ForeColor = SystemColors.ControlDark;
            labelConversion.Location = new Point(83, 73);
            labelConversion.Name = "labelConversion";
            labelConversion.Size = new Size(246, 17);
            labelConversion.TabIndex = 3;
            labelConversion.Text = "Conversion: 1 PHP = 50 Game Wallet";
            // 
            // labelCurrentPaymentMethod
            // 
            labelCurrentPaymentMethod.AutoSize = true;
            labelCurrentPaymentMethod.Font = new Font("Space Mono", 11.249999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelCurrentPaymentMethod.Location = new Point(78, 46);
            labelCurrentPaymentMethod.Name = "labelCurrentPaymentMethod";
            labelCurrentPaymentMethod.Size = new Size(55, 22);
            labelCurrentPaymentMethod.TabIndex = 2;
            labelCurrentPaymentMethod.Text = "GCash";
            // 
            // customPictureBoxPayment
            // 
            customPictureBoxPayment.BackColor = Color.Transparent;
            customPictureBoxPayment.GlowColor = Color.Transparent;
            customPictureBoxPayment.GlowSize = 6;
            customPictureBoxPayment.Image = Properties.Resources.RoundedGCash;
            customPictureBoxPayment.Location = new Point(16, 46);
            customPictureBoxPayment.Name = "customPictureBoxPayment";
            customPictureBoxPayment.Opacity = 100;
            customPictureBoxPayment.Size = new Size(56, 50);
            customPictureBoxPayment.TabIndex = 1;
            customPictureBoxPayment.TabStop = false;
            // 
            // labelPaymentMethod
            // 
            labelPaymentMethod.AutoSize = true;
            labelPaymentMethod.Font = new Font("Space Mono", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelPaymentMethod.Location = new Point(16, 16);
            labelPaymentMethod.Name = "labelPaymentMethod";
            labelPaymentMethod.Size = new Size(150, 24);
            labelPaymentMethod.TabIndex = 0;
            labelPaymentMethod.Text = "Payment Method";
            // 
            // labelGameWallet
            // 
            labelGameWallet.Font = new Font("Space Mono", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelGameWallet.ForeColor = Color.FromArgb(202, 138, 4);
            labelGameWallet.Location = new Point(358, 98);
            labelGameWallet.Name = "labelGameWallet";
            labelGameWallet.Size = new Size(188, 28);
            labelGameWallet.TabIndex = 4;
            labelGameWallet.Text = "1,000";
            labelGameWallet.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // labelSubGameWallet
            // 
            labelSubGameWallet.AutoSize = true;
            labelSubGameWallet.Font = new Font("Space Mono", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelSubGameWallet.ForeColor = SystemColors.ControlDarkDark;
            labelSubGameWallet.Location = new Point(352, 81);
            labelSubGameWallet.Name = "labelSubGameWallet";
            labelSubGameWallet.Size = new Size(85, 17);
            labelSubGameWallet.TabIndex = 3;
            labelSubGameWallet.Text = "Game Wallet";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Space Mono", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(203, 19);
            label9.Name = "label9";
            label9.Size = new Size(204, 40);
            label9.TabIndex = 5;
            label9.Text = "Game Wallet";
            // 
            // btnWithdraw
            // 
            btnWithdraw.BackColor = Color.Transparent;
            btnWithdraw.CornerRadius = 4;
            btnWithdraw.EnableHover = false;
            btnWithdraw.FlatAppearance.BorderSize = 0;
            btnWithdraw.FlatStyle = FlatStyle.Flat;
            btnWithdraw.Font = new Font("Space Mono", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnWithdraw.ForeColor = Color.White;
            btnWithdraw.GlowColor = Color.Black;
            btnWithdraw.GlowSize = 8;
            btnWithdraw.GradientAngle = 45F;
            btnWithdraw.GradientColor1 = Color.SteelBlue;
            btnWithdraw.GradientColor2 = Color.CornflowerBlue;
            btnWithdraw.HoverOverlayColor = Color.FromArgb(80, 255, 255, 255);
            btnWithdraw.Location = new Point(31, 295);
            btnWithdraw.Name = "btnWithdraw";
            btnWithdraw.Size = new Size(285, 53);
            btnWithdraw.TabIndex = 6;
            btnWithdraw.Text = "Withdraw";
            btnWithdraw.UseVisualStyleBackColor = false;
            btnWithdraw.Click += btnWithdraw_Click;
            // 
            // btnDeposit
            // 
            btnDeposit.BackColor = Color.Transparent;
            btnDeposit.CornerRadius = 4;
            btnDeposit.EnableHover = false;
            btnDeposit.FlatAppearance.BorderSize = 0;
            btnDeposit.FlatStyle = FlatStyle.Flat;
            btnDeposit.Font = new Font("Space Mono", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDeposit.ForeColor = Color.White;
            btnDeposit.GlowColor = Color.Black;
            btnDeposit.GlowSize = 8;
            btnDeposit.GradientAngle = 45F;
            btnDeposit.GradientColor1 = Color.FromArgb(21, 128, 61);
            btnDeposit.GradientColor2 = Color.YellowGreen;
            btnDeposit.HoverOverlayColor = Color.FromArgb(80, 255, 255, 255);
            btnDeposit.Location = new Point(323, 295);
            btnDeposit.Name = "btnDeposit";
            btnDeposit.Size = new Size(285, 53);
            btnDeposit.TabIndex = 7;
            btnDeposit.Text = "Deposit";
            btnDeposit.UseVisualStyleBackColor = false;
            btnDeposit.Click += btnDeposit_Click;
            // 
            // labelTransactionHistory
            // 
            labelTransactionHistory.AutoSize = true;
            labelTransactionHistory.Font = new Font("Space Mono", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTransactionHistory.Location = new Point(16, 14);
            labelTransactionHistory.Name = "labelTransactionHistory";
            labelTransactionHistory.Size = new Size(240, 28);
            labelTransactionHistory.TabIndex = 8;
            labelTransactionHistory.Text = "Transaction History";
            // 
            // customPanelTransaactionHistory
            // 
            customPanelTransaactionHistory.BackColor = Color.Transparent;
            customPanelTransaactionHistory.BorderColor = Color.FromArgb(240, 241, 242);
            customPanelTransaactionHistory.BorderThickness = 2F;
            customPanelTransaactionHistory.Controls.Add(panel1);
            customPanelTransaactionHistory.Controls.Add(labelTransactionHistory);
            customPanelTransaactionHistory.CornerRadius = 8;
            customPanelTransaactionHistory.GradientAngle = 45F;
            customPanelTransaactionHistory.GradientColor1 = Color.White;
            customPanelTransaactionHistory.GradientColor2 = Color.White;
            customPanelTransaactionHistory.Location = new Point(31, 368);
            customPanelTransaactionHistory.Name = "customPanelTransaactionHistory";
            customPanelTransaactionHistory.Opacity = 180;
            customPanelTransaactionHistory.Size = new Size(577, 245);
            customPanelTransaactionHistory.TabIndex = 9;
            // 
            // panel1
            // 
            panel1.Controls.Add(flowLayoutPanelTransactionHistory);
            panel1.Location = new Point(16, 54);
            panel1.Name = "panel1";
            panel1.Size = new Size(548, 188);
            panel1.TabIndex = 11;
            // 
            // flowLayoutPanelTransactionHistory
            // 
            flowLayoutPanelTransactionHistory.Dock = DockStyle.Fill;
            flowLayoutPanelTransactionHistory.Location = new Point(0, 0);
            flowLayoutPanelTransactionHistory.Name = "flowLayoutPanelTransactionHistory";
            flowLayoutPanelTransactionHistory.Size = new Size(548, 188);
            flowLayoutPanelTransactionHistory.TabIndex = 10;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.Transparent;
            label11.Font = new Font("Arial", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(122, 101);
            label11.Name = "label11";
            label11.Size = new Size(34, 34);
            label11.TabIndex = 10;
            label11.Text = "₱";
            // 
            // pictureBoxCoins
            // 
            pictureBoxCoins.BackColor = Color.Transparent;
            pictureBoxCoins.Image = Properties.Resources.Currency;
            pictureBoxCoins.Location = new Point(330, 104);
            pictureBoxCoins.Name = "pictureBoxCoins";
            pictureBoxCoins.Size = new Size(25, 25);
            pictureBoxCoins.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxCoins.TabIndex = 51;
            pictureBoxCoins.TabStop = false;
            // 
            // labelLastTransaction
            // 
            labelLastTransaction.AutoSize = true;
            labelLastTransaction.BackColor = Color.Transparent;
            labelLastTransaction.Font = new Font("Space Mono", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelLastTransaction.ForeColor = SystemColors.AppWorkspace;
            labelLastTransaction.Location = new Point(162, 136);
            labelLastTransaction.Name = "labelLastTransaction";
            labelLastTransaction.Size = new Size(267, 17);
            labelLastTransaction.TabIndex = 52;
            labelLastTransaction.Text = "Last updated: May 30, 2025 - 10:45 AM";
            // 
            // pictureBoxClose
            // 
            pictureBoxClose.Image = Properties.Resources.Close;
            pictureBoxClose.Location = new Point(604, 11);
            pictureBoxClose.Name = "pictureBoxClose";
            pictureBoxClose.Size = new Size(26, 23);
            pictureBoxClose.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxClose.TabIndex = 53;
            pictureBoxClose.TabStop = false;
            pictureBoxClose.Click += pictureBoxClose_Click;
            // 
            // WalletForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(244, 245, 246);
            ClientSize = new Size(643, 625);
            Controls.Add(pictureBoxClose);
            Controls.Add(labelLastTransaction);
            Controls.Add(pictureBoxCoins);
            Controls.Add(label11);
            Controls.Add(customPanelTransaactionHistory);
            Controls.Add(btnDeposit);
            Controls.Add(btnWithdraw);
            Controls.Add(label9);
            Controls.Add(labelGameWallet);
            Controls.Add(labelSubGameWallet);
            Controls.Add(customPanelPaymentMethod);
            Controls.Add(labelCurrentBalance);
            Controls.Add(labelSubCurrentBalance);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "WalletForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "WalletForm";
            Load += WalletForm_Load;
            customPanelPaymentMethod.ResumeLayout(false);
            customPanelPaymentMethod.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)customPictureBoxPayment).EndInit();
            customPanelTransaactionHistory.ResumeLayout(false);
            customPanelTransaactionHistory.PerformLayout();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBoxCoins).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxClose).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelSubCurrentBalance;
        private Label labelCurrentBalance;
        private CustomControls.CustomPanel customPanelPaymentMethod;
        private Label labelCurrentPaymentMethod;
        private CustomControls.CustomPictureBox customPictureBoxPayment;
        private Label labelPaymentMethod;
        private Label labelChangePaymentMethod;
        private Label labelConversion;
        private Label labelGameWallet;
        private Label labelSubGameWallet;
        private Label label9;
        private CustomControls.CustomButton btnWithdraw;
        private CustomControls.CustomButton btnDeposit;
        private Label labelTransactionHistory;
        private CustomControls.CustomPanel customPanelTransaactionHistory;
        private Label label11;
        private PictureBox pictureBoxCoins;
        private Label labelLastTransaction;
        private FlowLayoutPanel flowLayoutPanelTransactionHistory;
        private Panel panel1;
        private PictureBox pictureBoxClose;
    }
}