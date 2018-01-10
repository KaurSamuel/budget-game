using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Budget_game
{
    static class Player
    {
        public static int MaxLives = 10;
        public static int StartingCoins = 100;
        public static int PlayerLivesLeft { get; set; }
        public static int Gold { get; set; } = StartingCoins;
        public static int Level { get; set; }

        public static void Reset()
        {
            PlayerLivesLeft = MaxLives;
        }

        public static void UpdateCoins(Form form)
        {
            form.Controls["lblGold"].Text = Gold.ToString();
        }

        public static void Died(Form form)
        {
            Label label = new Label();

            label.Text = "You Died";
            label.Font = new System.Drawing.Font("Playbill", 80);
            label.Location = new System.Drawing.Point(400, 200);
            label.Size = new System.Drawing.Size(300, 200);
            label.BackColor = System.Drawing.Color.Transparent;
            
            form.Controls.Add(label);

            label.BringToFront();
        }
    }
}
