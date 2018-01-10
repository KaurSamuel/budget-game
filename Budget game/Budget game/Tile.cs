using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

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
        public string Turret_Name = "Tower";
        public int Turret_range;        
        public Turrets()
        {

        }
    }
}
