using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Budget_game
{
    class Monster : PictureBox
    {
        public Monster()
        {
            this.Image = System.Drawing.Image.FromFile("../../Sprites/Tower1.png");
        }

        public void MoveMonster()
        {
            Location. += movementSpeed;
        }

        public int movementSpeed { get; set; }
        public int MaximumHealth { get; set; }
        public int CurrentHealth { get; set; }
        public int Gold { get; set; }
    }
}
