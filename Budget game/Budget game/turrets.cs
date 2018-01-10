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
        public void Turret_spawn(Form form)
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
                cannon.Turret_range = 150;
                form.Controls.Add(cannon);
                cannon.BringToFront();
                Has_spawned = true;
            }
        }

        public void Turret_shoot(Form form, List<Monster> monsters)
        {
            foreach (Monster monster in monsters)
            {
                
                foreach (Turrets turret in form.Controls.Find("Tower1", true))
                {
                    if (monster.Location.X > turret.Location.X)
                    {
                        form.Controls.Remove(monster);
                        if (monster.Location.X - turret.Location.X < 100)
                        {

                            form.Controls.Remove(monster);
                            if (monster.Location.Y -turret.Location.Y < 100)
                            {
                                form.Controls.Remove(monster);
                            }

                        }
                    }
                    else
                    {
                        if (turret.Location.X - monster.Location.X < 100)
                        {

                            form.Controls.Remove(monster);
                            if (turret.Location.Y - monster.Location.Y < 100)
                            {
                                form.Controls.Remove(monster);
                            }
                        }
                    }
                }
            }
       
        }
    }
}
