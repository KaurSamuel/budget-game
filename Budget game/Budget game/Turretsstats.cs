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
        public Turrets(int type)
        {
            Turret_shooting_speed = 3000;

            switch (type)
            {
                case 1:
                    Turret_shooting_speed = 3000;
                    Turret_range = 20;
                    Damage = 30;
                    break;
                case 2:
                    Turret_shooting_speed = 6000;
                    Turret_range = 30;
                    Damage = 20;
                    break;
                case 3:
                    Turret_shooting_speed = 1500;
                    Turret_range = 50;
                    Damage = 45;
                    break;
                case 4:
                    Turret_shooting_speed = 4500;
                    Turret_range = 150;
                    Damage = 150;
                    break;

            }
        }
    }
}
