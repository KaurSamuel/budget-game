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

        public static int upgrade1 = 0;
        public static int upgrade2 = 0;
        public static int upgrade3 = 0;
        public static int upgrade4 = 0;

        public Turrets(int type)
        {
            switch (type)
            {
                case 1:
                    Turret_shooting_speed = 3000;
                    Turret_range = 90;
                    Damage = 30 + upgrade1;
                    this.Image = Image.FromFile("../../Sprites/Tower1.png");
                    Size = new Size(32, 32);
                    break;
                case 2:
                    Turret_shooting_speed = 200 - upgrade2;
                    Turret_range = 40;
                    Damage = 5;
                    this.Image = Image.FromFile("../../Sprites/Tower2.png");
                    Size = new Size(32, 32);
                    break;
                case 3:
                    Turret_shooting_speed = 2800;
                    Turret_range = 200;
                    Damage = 45 + upgrade3;
                    this.Image = Image.FromFile("../../Sprites/Tower3.png");
                    Size = new Size(32, 32);
                    break;
                case 4:
                    Turret_shooting_speed = 4500;
                    Turret_range = 500 + upgrade4;
                    Damage = 100;
                    this.Image = Image.FromFile("../../Sprites/Tower4.png");
                    Size = new Size(32, 32);
                    break;
            }

            Name = "Tower";
        }
    }
}
