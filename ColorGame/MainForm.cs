using ColorGame.Forms;
using System.Media;

namespace ColorGame
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            MaximizeBox = false;
            MinimizeBox = false;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            Utils.PlayButtonSound();
            new GameForm().Show();
            this.Hide();
        }

        private void btnExit_Click(object sender, EventArgs e) => Application.Exit();

        private void btnHelp_Click(object sender, EventArgs e)
        {
            Utils.PlayButtonSound();

            var modal = new HelpForm();

            var overlay = Utils.OverlayForm(this);

            overlay.Show();
            modal.ShowInTaskbar = false;
            modal.StartPosition = FormStartPosition.CenterParent;
            modal.ShowDialog(this);

            overlay.Close();
        }

        private void btnWallet_Click(object sender, EventArgs e)
        {
            new WalletForm().Show();
            this.Hide();
        }
    }
}
