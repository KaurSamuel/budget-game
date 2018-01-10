using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Budget_game
{
    class Store
    {
        public static PictureBox curControl;

        public static void UpdateBuyable(Form form)
        {
            for(int i = 1; i < 5; i++)
            {
                Control curControl = form.Controls["StoreTurret" + i.ToString() + "Price"];
                if (Int32.Parse(curControl.Text.Substring(0, 3)) <= Player.Gold)
                {
                    curControl.BackColor = System.Drawing.Color.Green;
                }

                else 
                {
                    curControl.BackColor = System.Drawing.Color.Red;
                }
            }
        }

        public static void Buy(Form form, string controlName)
        {

            var money = form.Controls[controlName + "Price"].Text;
            if (Int32.Parse(money.Substring(0, 3)) <= Player.Gold)
            {
                curControl = form.Controls["BoughtTurret"] as PictureBox;

                Player.Gold -= Int32.Parse(money.Substring(0, 3));
                
                curControl.Image = (form.Controls[controlName] as PictureBox).Image;
                curControl.Show();
            }
        }

        public static void Purchased()
        {

        }

        public static void UpdateTurretBought(Form form)
        {
            if (curControl.Visible)
            {
                curControl.Location = Cursor.Position;
            }
        }
    }
}
