using ColorGame.CustomControls;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace ColorGame
{
    public static class Utils
    {

        public static readonly Dictionary<string, Image> CacheImages = new Dictionary<string, Image>();
        public static string BASE_DIRECTORY = Path.Combine(AppDomain.CurrentDomain.BaseDirectory);

        public static Form OverlayForm (Form parent) => new Form
        {
            StartPosition = FormStartPosition.Manual,
            ShowInTaskbar = false,
            FormBorderStyle = FormBorderStyle.None,
            BackColor = Color.Black,
            Opacity = 0.5,
            Size = parent.Size,
            Location = parent.Location,
            Owner = parent
        };

        public static Image LoadImage(string imageName)
        {
            var imageDirectory = $"{BASE_DIRECTORY}\\Images\\{imageName}";

            if (File.Exists(imageDirectory))
            {
                if (CacheImages.TryGetValue(imageName, out var image)) return image;

                var newImage = Image.FromFile(imageDirectory);

                CacheImages.Add(imageName, newImage);

                return newImage;
            }
            else
            {
                throw new FileNotFoundException($"Image file not found: {imageName}");
            }

        }

        public static void SoundPlay(string path) => new SoundPlayer($"{BASE_DIRECTORY}\\Sounds\\{path}").Play();
        public static void PlayButtonSound() => SoundPlay("ClickSound.wav");
        public static void PlayCoinSound() => SoundPlay("Coins.wav");

        public static CustomLabel CreateCustomLabel(float fontSize, Point point, string text, int glowSize, Control? parent = null)
        {
            var customLabel = new CustomLabel();

            customLabel.AutoSize = true;
            customLabel.Font = new Font("Space Mono", fontSize);
            customLabel.Location = point;
            customLabel.ForeColor = Color.White;
            customLabel.Text = text;
            customLabel.BackColor = Color.Transparent;
            customLabel.GlowColor = Color.Black;
            customLabel.GlowSize = 6;

            if (parent != null) customLabel.Parent = parent;

            return customLabel;
        }

    }
}
