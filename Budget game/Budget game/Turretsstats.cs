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
        /*
        public Turrets()
        {
            Turrets tower1 = new Turrets();
            tower1.Turret_shooting_speed = 3000;
            tower1.Turret_range = 20;
            tower1.Damage = 30;

            Turrets tower2 = new Turrets();
            tower2.Turret_shooting_speed = 6000;
            tower2.Turret_range = 30;
            tower2.Damage = 20;

            Turrets tower3 = new Turrets();
            tower3.Turret_shooting_speed = 1500;
            tower3.Turret_range = 50;
            tower3.Damage = 45;

            Turrets tower4 = new Turrets();
            tower4.Turret_shooting_speed = 4500;
            tower4.Turret_range = 150;
            tower4.Damage = 150;
        }
        */
    }
}
