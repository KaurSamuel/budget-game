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
        Engine engine;
        Timer engineTimer;

        void InitializeValues()
        {
            Player.Reset();
            Controls["lblHitpoints"].Text = Player.PlayerLivesLeft.ToString();
            Controls["lblEnemiesLeft"].Text = 10.ToString();
        }

        public Game()
        {
            InitializeComponent();

            InitializeValues();

            Terrain.GenerateTerrain(this);

            engine = new Engine(this);

            engineTimer = new Timer();
            engineTimer.Enabled = true;
            engineTimer.Interval = 10;
            engineTimer.Tick += new EventHandler(Frame);

            
        }

        void Frame(object sender, EventArgs e)
        {
            engine.Update();
            Game_Over();
        }

        private void Game_Load(object sender, EventArgs e)
        {

        }

        private void Game_Over()
        {
            if (Player.PlayerLivesLeft == 0)
            {
                lblGameOver.Text = "GAME OVER";
                lblGameOver.BringToFront();
                timer.Stop();
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            quick--;
            lblTimer.Text = quick / 60 + ":" + ((quick % 60) >= 10 ? (quick % 60).ToString() : "0" + (quick % 60));

            if(lblTimer.Text == "0:00")
            {
                timer.Stop();
                if (count <= 1)
                   {
                    //Transparency ei tööta Windows Formsil.
                    //Road on Game Overi peal.

                    //lblGameOver.BackColor = Color.Transparent;
                    //lblGameOver.BackColor = SystemColors.Control;
                    lblGameOver.Text = "GAME OVER";
                    }
            }
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

            engine.StartRound();
        }


        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void cmbUpgradesTower4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void StoreTurret1_Click(object sender, EventArgs e)
        {
            Store.Buy(this, "StoreTurret1");
        }

        private void StoreTurret2_Click(object sender, EventArgs e)
        {
            Store.Buy(this, "StoreTurret2");
        }

        private void StoreTurret3_Click(object sender, EventArgs e)
        {
            Store.Buy(this, "StoreTurret3");
        }

        private void StoreTurret4_Click(object sender, EventArgs e)
        {
            Store.Buy(this, "StoreTurret4");
        }


        private void BoughtTurret_Click(object sender, EventArgs e)
        {
            Store.Place(this);
        }
    }
}
