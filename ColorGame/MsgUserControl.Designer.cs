namespace ColorGame
{
    partial class MsgUserControl
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
            components = new System.ComponentModel.Container();
            popMsg = new ColorGame.CustomControls.CustomPictureBox();
            timerSlide = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)popMsg).BeginInit();
            SuspendLayout();
            // 
            // popMsg
            // 
            popMsg.BackColor = Color.Transparent;
            popMsg.Dock = DockStyle.Fill;
            popMsg.GlowColor = Color.Black;
            popMsg.GlowSize = 1;
            popMsg.Image = Properties.Resources.PopMsg;
            popMsg.Location = new Point(0, 0);
            popMsg.Name = "popMsg";
            popMsg.Opacity = 100;
            popMsg.Size = new Size(1225, 65);
            popMsg.TabIndex = 31;
            popMsg.TabStop = false;
            // 
            // timerSlide
            // 
            timerSlide.Enabled = true;
            timerSlide.Interval = 5;
            timerSlide.Tick += timerSlide_Tick;
            // 
            // MsgUserControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(popMsg);
            Name = "MsgUserControl";
            Size = new Size(1225, 65);
            ((System.ComponentModel.ISupportInitialize)popMsg).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private CustomControls.CustomPictureBox popMsg;
        private System.Windows.Forms.Timer timerSlide;
    }
}
