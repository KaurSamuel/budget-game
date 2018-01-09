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
        public Monster(Form form)
        {
            this.Image = System.Drawing.Image.FromFile("../../Sprites/Tower1.png");
            this.BringToFront();
            Size = new System.Drawing.Size(32, 32);
            form.Controls.Add(this);
        }

        public void MoveMonster()
        {
            Location = new System.Drawing.Point(Location.X + movementSpeed, Location.Y);
        }

        public int movementSpeed { get; set; }
        public int MaximumHealth { get; set; }
        public int CurrentHealth { get; set; }
        public int Gold { get; set; }
    }
}
