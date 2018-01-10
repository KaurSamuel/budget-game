using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace Budget_game
{
    class turrets
    {
        
        public void Turret_shoot(Form form)
        {
            bool Has_spawned = false;
            if (Has_spawned == false)
            {
                int Tilesize = (32);
                Point curpoint = new Point(500, 300);
                Turrets cannon = new Turrets();
                cannon.Size = new Size(Tilesize, Tilesize);
                cannon.Location = new Point(curpoint.X, curpoint.Y);
                cannon.Image = Image.FromFile("../../Sprites/Tower1.png");
                cannon.Name = "Tower1";
                cannon.Turret_shooting_speed = 10;
                cannon.Turret_range = 10;
                form.Controls.Add(cannon);
                cannon.BringToFront();
                Has_spawned = true;
            }
        }

    }
}
