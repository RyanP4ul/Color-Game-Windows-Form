namespace ColorGame.Forms
{
    partial class TransactionForm
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            labelTransactionType = new Label();
            labelPaymentMethod = new Label();
            labelAmount = new Label();
            labelGameCoinsToReceived = new Label();
            labelTotal = new Label();
            pictureBoxClose = new PictureBox();
            btnCancel = new ColorGame.CustomControls.CustomButton();
            btnConfirm = new ColorGame.CustomControls.CustomButton();
            ((System.ComponentModel.ISupportInitialize)pictureBoxClose).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Space Mono", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(18, 18);
            label1.Name = "label1";
            label1.Size = new Size(250, 24);
            label1.TabIndex = 0;
            label1.Text = "Authenticate Transaction";
            // 
            // label2
            // 
            label2.Font = new Font("Space Mono", 9.749999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(75, 85, 99);
            label2.Location = new Point(33, 86);
            label2.Name = "label2";
            label2.Size = new Size(164, 23);
            label2.TabIndex = 1;
            label2.Text = "Transaction Type";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            label3.Font = new Font("Space Mono", 9.749999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(75, 85, 99);
            label3.Location = new Point(33, 120);
            label3.Name = "label3";
            label3.Size = new Size(164, 23);
            label3.TabIndex = 2;
            label3.Text = "Payment Method";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            label4.Font = new Font("Space Mono", 9.749999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(75, 85, 99);
            label4.Location = new Point(33, 156);
            label4.Name = "label4";
            label4.Size = new Size(164, 23);
            label4.TabIndex = 3;
            label4.Text = "Amount";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            label5.Font = new Font("Space Mono", 9.749999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(75, 85, 99);
            label5.Location = new Point(33, 192);
            label5.Name = "label5";
            label5.Size = new Size(219, 23);
            label5.TabIndex = 4;
            label5.Text = "Game Coins to Received";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            label6.BorderStyle = BorderStyle.Fixed3D;
            label6.Location = new Point(33, 231);
            label6.Name = "label6";
            label6.Size = new Size(435, 3);
            label6.TabIndex = 5;
            // 
            // label7
            // 
            label7.Font = new Font("Space Mono", 9.749999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(33, 246);
            label7.Name = "label7";
            label7.Size = new Size(219, 23);
            label7.TabIndex = 6;
            label7.Text = "Total";
            label7.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // labelTransactionType
            // 
            labelTransactionType.Font = new Font("Arial", 9.75F);
            labelTransactionType.ForeColor = Color.Black;
            labelTransactionType.Location = new Point(304, 86);
            labelTransactionType.Name = "labelTransactionType";
            labelTransactionType.Size = new Size(164, 23);
            labelTransactionType.TabIndex = 7;
            labelTransactionType.Text = "Withdraw";
            labelTransactionType.TextAlign = ContentAlignment.MiddleRight;
            // 
            // labelPaymentMethod
            // 
            labelPaymentMethod.Font = new Font("Arial", 9.75F);
            labelPaymentMethod.ForeColor = Color.FromArgb(55, 99, 235);
            labelPaymentMethod.Location = new Point(304, 120);
            labelPaymentMethod.Name = "labelPaymentMethod";
            labelPaymentMethod.Size = new Size(164, 23);
            labelPaymentMethod.TabIndex = 8;
            labelPaymentMethod.Text = "GCash";
            labelPaymentMethod.TextAlign = ContentAlignment.MiddleRight;
            // 
            // labelAmount
            // 
            labelAmount.Font = new Font("Arial", 9.75F);
            labelAmount.ForeColor = Color.Black;
            labelAmount.Location = new Point(304, 156);
            labelAmount.Name = "labelAmount";
            labelAmount.Size = new Size(164, 23);
            labelAmount.TabIndex = 9;
            labelAmount.Text = "₱100";
            labelAmount.TextAlign = ContentAlignment.MiddleRight;
            // 
            // labelGameCoinsToReceived
            // 
            labelGameCoinsToReceived.Font = new Font("Arial", 9.75F);
            labelGameCoinsToReceived.ForeColor = Color.FromArgb(202, 138, 4);
            labelGameCoinsToReceived.Location = new Point(304, 192);
            labelGameCoinsToReceived.Name = "labelGameCoinsToReceived";
            labelGameCoinsToReceived.Size = new Size(164, 23);
            labelGameCoinsToReceived.TabIndex = 10;
            labelGameCoinsToReceived.Text = "0";
            labelGameCoinsToReceived.TextAlign = ContentAlignment.MiddleRight;
            // 
            // labelTotal
            // 
            labelTotal.Font = new Font("Arial", 9.75F);
            labelTotal.ForeColor = Color.Black;
            labelTotal.Location = new Point(304, 246);
            labelTotal.Name = "labelTotal";
            labelTotal.Size = new Size(164, 23);
            labelTotal.TabIndex = 11;
            labelTotal.Text = "₱0";
            labelTotal.TextAlign = ContentAlignment.MiddleRight;
            // 
            // pictureBoxClose
            // 
            pictureBoxClose.Image = Properties.Resources.Close;
            pictureBoxClose.Location = new Point(458, 12);
            pictureBoxClose.Name = "pictureBoxClose";
            pictureBoxClose.Size = new Size(26, 23);
            pictureBoxClose.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxClose.TabIndex = 55;
            pictureBoxClose.TabStop = false;
            pictureBoxClose.Click += pictureBoxClose_Click;
            pictureBoxClose.MouseEnter += pictureBoxClose_MouseEnter;
            pictureBoxClose.MouseLeave += pictureBoxClose_MouseLeave;
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
            btnCancel.Location = new Point(33, 367);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(140, 35);
            btnCancel.TabIndex = 57;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnConfirm
            // 
            btnConfirm.BackColor = Color.Transparent;
            btnConfirm.CornerRadius = 5;
            btnConfirm.EnableHover = false;
            btnConfirm.FlatAppearance.BorderSize = 0;
            btnConfirm.FlatStyle = FlatStyle.Flat;
            btnConfirm.Font = new Font("Space Mono", 9.749999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnConfirm.ForeColor = Color.White;
            btnConfirm.GlowColor = Color.Black;
            btnConfirm.GlowSize = 8;
            btnConfirm.GradientAngle = 45F;
            btnConfirm.GradientColor1 = Color.SteelBlue;
            btnConfirm.GradientColor2 = Color.CornflowerBlue;
            btnConfirm.HoverOverlayColor = Color.FromArgb(80, 255, 255, 255);
            btnConfirm.Location = new Point(328, 367);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(140, 35);
            btnConfirm.TabIndex = 56;
            btnConfirm.Text = "Apply";
            btnConfirm.UseVisualStyleBackColor = false;
            btnConfirm.Click += btnConfirm_Click;
            // 
            // TransactionForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(498, 426);
            Controls.Add(btnCancel);
            Controls.Add(btnConfirm);
            Controls.Add(pictureBoxClose);
            Controls.Add(labelTotal);
            Controls.Add(labelGameCoinsToReceived);
            Controls.Add(labelAmount);
            Controls.Add(labelPaymentMethod);
            Controls.Add(labelTransactionType);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "TransactionForm";
            Text = "TransactionForm";
            ((System.ComponentModel.ISupportInitialize)pictureBoxClose).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label labelTransactionType;
        private Label labelPaymentMethod;
        private Label labelAmount;
        private Label labelGameCoinsToReceived;
        private Label labelTotal;
        private PictureBox pictureBoxClose;
        private CustomControls.CustomButton btnCancel;
        private CustomControls.CustomButton btnConfirm;
    }
}