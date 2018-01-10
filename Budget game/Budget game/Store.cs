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
        public static void UpdateBuyable(Form form)
        {
            for(int i = 1; i < 5; i++)
            {
                Control curControl = form.Controls["StoreTurret" + i.ToString() + "Price"];
                if (Int32.Parse(curControl.Text) <= Player.Gold)
                {
                    curControl.BackColor = System.Drawing.Color.Green;
                }

                else 
                {
                    curControl.BackColor = System.Drawing.Color.Red;
                }
            }
        }
    }
}
