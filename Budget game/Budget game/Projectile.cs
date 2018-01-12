using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Budget_game
{
    class Projectile : Control
    {
        public Point targetPoint;
        public int speed = 5;
        public Monster targetMonster;
        public int Damage = 0;

        public Projectile()
        {
            Size = new Size(24, 24);
            SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            this.BackColor = Color.Transparent;
            
        }

        public Projectile UpdateProjectile(Form form)
        {
            Point delta = new Point(Location.X - targetPoint.X, Location.Y - targetPoint.Y);
            Point newPoint = new Point(Location.X, Location.Y);

            if (delta.X <= 4 && delta.X >= -4)
            {
                if(delta.Y <= 4 && delta.Y >= -4)
                {
                    form.Controls.Remove(this);
                    targetMonster.TakeDamage(form, Damage);
                    return this;
                }
                    
            }
                
            if (delta.X >= 0)
            {
                newPoint.X -= speed;
            }

            else if (delta.X < 0)
            {
                newPoint.X += speed;
            }

            if (delta.Y >= 0)
            {
                newPoint.Y -= speed;
            }

            else if (delta.Y < 0)
            {
                newPoint.Y += speed;
            }

            Location = newPoint;

            return null;
        }

        protected override void OnPaintBackground(PaintEventArgs e)
        {
            e.Graphics.FillRectangle(Brushes.Transparent, e.ClipRectangle);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            Pen pen = new Pen(Brushes.DeepSkyBlue);

            e.Graphics.FillRectangle(Brushes.Transparent, e.ClipRectangle);
            e.Graphics.FillEllipse(Brushes.Black, 0, 0, 24, 24);
        }

    }
}
