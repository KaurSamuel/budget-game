using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace Budget_game
{
    class turretsclass
    {
        public static void Turret_spawn(Form form, Point location)
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
                cannon.Turret_shooting_speed = 10;
                cannon.Turret_range = 150;
                form.Controls.Add(cannon);
                cannon.BringToFront();
                Has_spawned = true;
            }
        }

        public static void Turret_shoot(Form form, List<Monster> monsters)
        {
            foreach (Monster monster in monsters)
            {
                
                foreach (Turrets turret in form.Controls.Find("Tower", true))
                {
                    if(monster.IsAlive)
                    {
                        if (turret.Location.X - monster.Location.X < 150 &&
                            monster.Location.X - turret.Location.X > -150 &&
                            turret.Location.Y - monster.Location.Y < 150 &&
                            monster.Location.Y - turret.Location.Y > -150)
                        {
                            monster.TakeDamage(form, 30);
                        }
                    }

                }
            }
       
        }
    }
}
