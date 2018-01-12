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
        public static int StartingCoins = 4000;
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
    }

}
