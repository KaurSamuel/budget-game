using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Budget_game
{
    public partial class Game : Form
    {
        int count = 0;
        private int quick = 120;

        public Game()
        {
            InitializeComponent();

            Terrain.GenerateTerrain(this);
        }

        private void Game_Load(object sender, EventArgs e)
        {

        }

        private void timer_Tick(object sender, EventArgs e)
        {
            quick--;
            lblTimer.Text = quick / 60 + ":" + ((quick % 60) >= 10 ? (quick % 60).ToString() : "0" + (quick % 60));

            if(lblTimer.Text == "0:00")
                timer.Stop();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            count++;
            timer = new Timer();
            timer.Tick += (timer_Tick);
            timer.Enabled = true;
            timer.Interval = 1000;
            if (count >= 1)
            {
                btnStart.Enabled = false;
            }
        }
    }
}
