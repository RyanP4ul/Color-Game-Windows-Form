using ColorGame.CustomControls;
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
    public partial class BetHistoryListItem : UserControl
    {

        public BetHistoryListItem()
        {
            InitializeComponent();
        }

        public void Init(IList<Cube> cubes, int number, int resultBetAmount)
        {
            labelNumber.Text = $"Game #{number + 1}";

            var cubeCount = 0;
            var offsetX = labelNumber.Location.X;    

            foreach (var cube in cubes)
            {
                var color = new CustomPanel();
                color.GradientColor1 = GetColor(cube.FinalColor);
                color.GradientColor2 = GetColor(cube.FinalColor);
                color.Size = new Size(25, 20);
                color.Location = new Point(offsetX + (cubeCount * 30), 30);
                color.CornerRadius = 1;
                color.BorderColor = Color.Black;
                color.BorderThickness = 0;
                color.Parent = customPanel1;
                customPanel1.Controls.Add(color);
                cubeCount++;
            }

            labelResultBetAmount.Location = new Point(offsetX + (cubeCount * 30), labelResultBetAmount.Location.Y);

            // IM TIRED THIS SHIT!

            //color1.GradientColor1 = GetColor(cubes[0].FinalColor);
            //color1.GradientColor2 = GetColor(cubes[0].FinalColor);

            //color2.GradientColor1 = GetColor(cubes[1].FinalColor);
            //color2.GradientColor2 = GetColor(cubes[1].FinalColor);

            //color3.GradientColor1 = GetColor(cubes[2].FinalColor);
            //color3.GradientColor2 = GetColor(cubes[2].FinalColor);

            if (resultBetAmount > 0) {
                labelResultBetAmount.Text = $"+{resultBetAmount:N0}";
                labelResultBetAmount.ForeColor = Color.Green;
            }
            else if (resultBetAmount < 0)
            {
                labelResultBetAmount.Text = $"{resultBetAmount:N0}";
                labelResultBetAmount.ForeColor = Color.Red;
            }
        }

        private Color GetColor(string colorName)
        {
            return colorName switch
            {
                "Red" => Color.Red,
                "Green" => Color.Green,
                "Blue" => Color.Blue,
                "Yellow" => Color.Yellow,
                "Pink" => Color.Pink,
                "Orange" => Color.Orange,
                "Purple" => Color.Purple,
                "Cyan" => Color.Cyan,
                "Brown" => Color.Brown,
                "Black" => Color.Black,
                "White" => Color.White,
                "Gray" => Color.Gray,
                _ => Color.Gray,
            };
        }

    }
}
