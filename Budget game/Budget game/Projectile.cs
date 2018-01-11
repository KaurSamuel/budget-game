using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Budget_game
{
    class Projectile : PictureBox
    {
        public Point targetPoint;
        public int speed = 3;
        
        public Projectile()
        {
            Size = new Size(24, 6);
        }

        public void UpdateProjectile(Form form)
        {
            Point delta = new Point(Location.X - targetPoint.X, Location.Y - targetPoint.Y);
            Point newPoint = new Point(Location.X, Location.Y);

            if (delta.X < 300 && delta.X > 0)
            {
                newPoint.X -= speed;
            }

            if (delta.X > -300 && delta.X < 0)
            {
                newPoint.X += speed;
            }

            if (delta.Y < 300 && delta.Y > 0)
            {
                newPoint.Y -= speed;
            }

            if (delta.Y > -300 && delta.Y < 0)
            {
                newPoint.Y += speed;
            }

            Location = newPoint;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            e.Graphics.FillRectangle(Brushes.Black, 0, 0, 24, 12);
        }

    }
}
