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
        public int Turret_shooting_speed = 3000;
        public string Turret_Name = "Tower";
        public int Turret_range;
        public Stopwatch ShootingTimer;
        public Turrets()
        {
            
        }
    }
}
