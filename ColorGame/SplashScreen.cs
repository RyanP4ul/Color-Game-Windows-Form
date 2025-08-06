using ColorGame.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ColorGame
{
    public partial class SplashScreen : Form
    {
        public SplashScreen()
        {
            MinimizeBox = false;
            MaximizeBox = false;
            InitializeComponent();
        }

        private async void SplashScreen_Load(object sender, EventArgs e)
        {
            await Task.Delay(200);
            await RetrieveAllImages();
            await Task.Delay(1000);

            Hide();

            new MainForm().Show();
        }

        private async Task RetrieveAllImages()
        {
            labelLoading.Text = "Loading images...";

            var folderPath = Path.Combine(Utils.BASE_DIRECTORY, "Images");

            await Task.Run(() =>
            {
                var imageFiles = Directory.GetFiles(folderPath).Where(f => f.EndsWith(".png", StringComparison.OrdinalIgnoreCase) || f.EndsWith(".jpeg", StringComparison.OrdinalIgnoreCase)).ToArray();

                foreach (var imageFile in imageFiles)
                {
                    var imageName = Path.GetFileName(imageFile);

                    try
                    {
                        System.Diagnostics.Debug.WriteLine($"Loading image: {imageName}");

                        Utils.LoadImage(imageName);
                    }
                    catch (FileNotFoundException)
                    {
                        Close();
                        break;
                    }
                }
            });
        }

    }
}
