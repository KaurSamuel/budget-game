using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Diagnostics;

namespace Budget_game
{
    class Tile : PictureBox
    {
        public Tile()
        {
            
        }
    }

 
    class Turrets : PictureBox
    {
        public int Turret_shooting_speed;
        public int Turret_range;
        public Stopwatch ShootingTimer;
        public Monster targetMonster;
        public int Damage;
        public int turType;

        public static int upgrade1 = 0;
        public static int upgrade2 = 0;
        public static int upgrade3 = 0;
        public static int upgrade4 = 0;

        public static void UpdateUpgrade(Form form, int turType, int value)
        {
            foreach (Turrets turret in form.Controls.Find("Tower", false))
            {
                switch(turType)
                {
                    case 1:
                        turret.Damage += value;
                        upgrade1 += value;
                        break;
                    case 2:
                        turret.Turret_shooting_speed -= value;
                        upgrade2 += value;
                        break;
                    case 3:
                        turret.Damage += value;
                        upgrade3 += value;
                        break;
                    case 4:
                        turret.Turret_range += value;
                        upgrade4 += value;
                        break;
                }
            }
        }

        public Turrets(int type)
        {
            switch (type)
            {
                case 1:
                    Turret_shooting_speed = 2000;
                    Turret_range = 128;
                    Damage = 30 + upgrade1;
                    this.Image = Image.FromFile("../../Sprites/Tower1.png");
                    Size = new Size(32, 32);
                    break;
                case 2:
                    Turret_shooting_speed = 200 - upgrade2;
                    Turret_range = 40;
                    Damage = 4;
                    this.Image = Image.FromFile("../../Sprites/Tower2.png");
                    Size = new Size(32, 32);
                    break;
                case 3:
                    Turret_shooting_speed = 2800;
                    Turret_range = 200;
                    Damage = 60 + upgrade3;
                    this.Image = Image.FromFile("../../Sprites/Tower3.png");
                    Size = new Size(32, 32);
                    break;
                case 4:
                    Turret_shooting_speed = 4500;
                    Turret_range = 500 + upgrade4;
                    Damage = 140;
                    this.Image = Image.FromFile("../../Sprites/Tower4.png");
                    Size = new Size(32, 32);
                    break;
            }

            turType = type;
            Name = "Tower";
        }
    }
}
