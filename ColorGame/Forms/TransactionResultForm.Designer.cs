namespace ColorGame.Forms
{
    partial class TransactionResultForm
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
            components = new System.ComponentModel.Container();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            labelMessage1 = new Label();
            labelMessage2 = new Label();
            timer = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Success;
            pictureBox1.Location = new Point(205, 45);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(91, 75);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Space Mono", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(129, 135);
            label1.Name = "label1";
            label1.Size = new Size(252, 28);
            label1.TabIndex = 1;
            label1.Text = "Transaction Success!";
            // 
            // labelMessage1
            // 
            labelMessage1.AutoSize = true;
            labelMessage1.BackColor = Color.Transparent;
            labelMessage1.Font = new Font("Space Mono", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelMessage1.ForeColor = Color.DimGray;
            labelMessage1.Location = new Point(67, 172);
            labelMessage1.Name = "labelMessage1";
            labelMessage1.Size = new Size(379, 17);
            labelMessage1.TabIndex = 2;
            labelMessage1.Text = "Your withdraw of P1,000 via GCASh has been processed.";
            // 
            // labelMessage2
            // 
            labelMessage2.AutoSize = true;
            labelMessage2.BackColor = Color.Transparent;
            labelMessage2.Font = new Font("Space Mono", 9.749999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelMessage2.ForeColor = Color.FromArgb(202, 138, 4);
            labelMessage2.Location = new Point(88, 201);
            labelMessage2.Name = "labelMessage2";
            labelMessage2.Size = new Size(329, 20);
            labelMessage2.TabIndex = 3;
            labelMessage2.Text = "10,000 coins added to your game account!";
            // 
            // timer
            // 
            timer.Enabled = true;
            timer.Interval = 2000;
            timer.Tick += timer_Tick;
            // 
            // TransactionResultForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(498, 293);
            Controls.Add(labelMessage2);
            Controls.Add(labelMessage1);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "TransactionResultForm";
            Text = "TransactionResultForm";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label labelMessage1;
        private Label labelMessage2;
        private System.Windows.Forms.Timer timer;
    }
}