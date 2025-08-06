using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColorGame.Models
{
    public class CubeCollider
    {
        public RectangleF Bounds { get; set; }
        public Cube ParentCube { get; set; }

        public CubeCollider(Cube parent, float x, float y, float width, float height)
        {
            ParentCube = parent;
            Bounds = new RectangleF(x, y, width, height);
        }

        public void UpdatePosition(float x, float y) => Bounds = new RectangleF(x, y, Bounds.Width, Bounds.Height);
        public bool Intersects(CubeCollider other) => Bounds.IntersectsWith(other.Bounds);

        public void HandleCollision(CubeCollider other)
        {
            // Calculate collision normal (direction from this to other)
            float dx = (other.Bounds.X + other.Bounds.Width / 2) - (Bounds.X + Bounds.Width / 2);
            float dy = (other.Bounds.Y + other.Bounds.Height / 2) - (Bounds.Y + Bounds.Height / 2);
            float distance = (float)Math.Sqrt(dx * dx + dy * dy);

            if (distance == 0) return; // Prevent division by zero

            dx /= distance;
            dy /= distance;

            // Calculate relative velocity
            float relativeVelocityX = other.ParentCube.VelocityX - ParentCube.VelocityX;
            float relativeVelocityY = other.ParentCube.VelocityY - ParentCube.VelocityY;

            // Calculate impulse along the collision normal
            float impulse = -(1 + Configuration.COLLISION_ELASTICITY) * (relativeVelocityX * dx + relativeVelocityY * dy);
            impulse /= 2; // Divide by 2 since we're applying to both objects

            // Apply impulse
            if (!ParentCube.HasLanded)
            {
                ParentCube.VelocityX -= impulse * dx * Configuration.COLLISION_RESPONSE_FORCE;
                ParentCube.VelocityY -= impulse * dy * Configuration.COLLISION_RESPONSE_FORCE;
            }

            if (!other.ParentCube.HasLanded)
            {
                other.ParentCube.VelocityX += impulse * dx * Configuration.COLLISION_RESPONSE_FORCE;
                other.ParentCube.VelocityY += impulse * dy * Configuration.COLLISION_RESPONSE_FORCE;
            }

            // Position correction to prevent sticking
            float penetration = (Bounds.Width / 2 + other.Bounds.Width / 2) - distance;
            if (penetration > 0)
            {
                float correctionX = penetration * dx * 0.5f;
                float correctionY = penetration * dy * 0.5f;

                if (!ParentCube.HasLanded)
                {
                    ParentCube.PosX -= correctionX;
                    ParentCube.PosY -= correctionY;
                }

                if (!other.ParentCube.HasLanded)
                {
                    other.ParentCube.PosX += correctionX;
                    other.ParentCube.PosY += correctionY;
                }

                UpdatePosition(ParentCube.PosX, ParentCube.PosY);
                other.UpdatePosition(other.ParentCube.PosX, other.ParentCube.PosY);
            }
        }
    }
}
