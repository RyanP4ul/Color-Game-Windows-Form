namespace ColorGame
{
    partial class TransactionUserControl
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
            pictureBoxTransactionType = new PictureBox();
            labelTransactionType = new Label();
            labelVia = new Label();
            labelTransactionDate = new Label();
            labelAmount = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBoxTransactionType).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxTransactionType
            // 
            pictureBoxTransactionType.Image = Properties.Resources.TransactionCashOut;
            pictureBoxTransactionType.Location = new Point(12, 15);
            pictureBoxTransactionType.Name = "pictureBoxTransactionType";
            pictureBoxTransactionType.Size = new Size(58, 50);
            pictureBoxTransactionType.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxTransactionType.TabIndex = 0;
            pictureBoxTransactionType.TabStop = false;
            // 
            // labelTransactionType
            // 
            labelTransactionType.AutoSize = true;
            labelTransactionType.Font = new Font("Space Mono", 9.749999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelTransactionType.Location = new Point(79, 19);
            labelTransactionType.Name = "labelTransactionType";
            labelTransactionType.Size = new Size(73, 20);
            labelTransactionType.TabIndex = 1;
            labelTransactionType.Text = "Cash Out";
            // 
            // labelVia
            // 
            labelVia.AutoSize = true;
            labelVia.Font = new Font("Space Mono", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelVia.ForeColor = SystemColors.AppWorkspace;
            labelVia.Location = new Point(155, 20);
            labelVia.Name = "labelVia";
            labelVia.Size = new Size(71, 17);
            labelVia.TabIndex = 2;
            labelVia.Text = "Via GCash";
            // 
            // labelTransactionDate
            // 
            labelTransactionDate.AutoSize = true;
            labelTransactionDate.Font = new Font("Space Mono", 8.249999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelTransactionDate.Location = new Point(79, 41);
            labelTransactionDate.Name = "labelTransactionDate";
            labelTransactionDate.Size = new Size(133, 16);
            labelTransactionDate.TabIndex = 3;
            labelTransactionDate.Text = "2025-05-29 • 14:32";
            // 
            // labelAmount
            // 
            labelAmount.Font = new Font("Space Mono", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelAmount.ForeColor = Color.FromArgb(22, 163, 74);
            labelAmount.Location = new Point(378, 24);
            labelAmount.Name = "labelAmount";
            labelAmount.Size = new Size(121, 30);
            labelAmount.TabIndex = 4;
            labelAmount.Text = "+5,000";
            labelAmount.TextAlign = ContentAlignment.MiddleRight;
            // 
            // TransactionUserControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(labelAmount);
            Controls.Add(labelTransactionDate);
            Controls.Add(labelVia);
            Controls.Add(labelTransactionType);
            Controls.Add(pictureBoxTransactionType);
            Name = "TransactionUserControl";
            Size = new Size(512, 78);
            ((System.ComponentModel.ISupportInitialize)pictureBoxTransactionType).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBoxTransactionType;
        private Label labelTransactionType;
        private Label labelVia;
        private Label labelTransactionDate;
        private Label labelAmount;
    }
}
