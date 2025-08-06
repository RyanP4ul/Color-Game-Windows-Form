using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ColorGame.GameForm;

namespace ColorGame.Models
{
    public class Cube
    {
        public PictureBox CubeBox { get; set; }
        public float PosX { get; set; }
        public float PosY { get; set; }
        public float VelocityX { get; set; }
        public float VelocityY { get; set; }
        public float Rotation { get; set; }
        public float AngularVelocity { get; set; }
        public bool HasLanded { get; set; }
        public string FinalColor { get; set; }
        public double Chance { get; set; }
        public bool IsSpecial { get; set; }
        public CubeCollider Collider { get; set; }
    }
}
