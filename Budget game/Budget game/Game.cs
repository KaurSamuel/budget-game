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

            SetStyle(ControlStyles.SupportsTransparentBackColor, true);

            this.BackColor = Color.Transparent;
            this.TransparencyKey = Color.Transparent;

            InitializeValues();
            
            Terrain.GenerateTerrain(this);

            engine = new Engine(this);

            engineTimer = new Timer();
            engineTimer.Enabled = true;
            engineTimer.Interval = 30;
            engineTimer.Tick += new EventHandler(Frame);
        }



        int count1 = 2;
        int count2 = 2;
        int count3 = 2;
        int count4 = 2;

        int upgrade1 = 500;
        int upgrade2 = 850;
        int upgrade3 = 1200;
        int upgrade4 = 2250;

        void Frame(object sender, EventArgs e)
        {
            engine.Update();
            Game_Over();

            if (lblEnemiesLeft.Text == "0" && !btnStart.Enabled)
            {
                btnStart.Enabled = true;
                Engine.CurLevel++;
                var a = Engine.CurLevel;
                this.Controls["lblLevel"].Text = Engine.CurLevel.ToString();
            }
            if (Player.Gold >= upgrade1 && count1 <= 5)
                btnUpgradeTower1.Enabled = true;
            else
                btnUpgradeTower1.Enabled = false;

            if (Player.Gold >= upgrade2 && count2 <= 5)
                btnUpgradeTower2.Enabled = true;
            else
                btnUpgradeTower2.Enabled = false;

            if (Player.Gold >= upgrade3 && count3 <= 5)
                btnUpgradeTower3.Enabled = true;
            else
                btnUpgradeTower3.Enabled = false;

            if (Player.Gold >= upgrade4 && count4 <= 5)
                btnUpgradeTower4.Enabled = true;
            else
                btnUpgradeTower4.Enabled = false;
        }

        private void btnUpgradeTower1_Click(object sender, EventArgs e)
        {
            btnUpgradeTower1.Enabled = false;

            Player.Gold = Player.Gold - upgrade1;
            upgrade1 += 200;
            this.Controls["btnUpgradeTower1"].Text = "Tier " + count1 + " Upgrade " + upgrade1 + "gp";
            Turrets.UpdateUpgrade(this, 1, 20);

            count1++;
            if (count1 == 6)
            {
                btnUpgradeTower1.Text = "Fully upgraded!";
            }
        }

        private void btnUpgradeTower2_Click(object sender, EventArgs e)
        {
            btnUpgradeTower2.Enabled = false;


            Player.Gold = Player.Gold - upgrade2;
            upgrade2 += 400;
            this.Controls["btnUpgradeTower2"].Text = "Tier " + count2 + " Upgrade " + upgrade2 + "gp";
            Turrets.UpdateUpgrade(this, 2, 40);

            count2++;
            if (count2 == 6)
            {
                btnUpgradeTower2.Text = "Fully upgraded!";
            }
        }

        private void btnUpgradeTower3_Click(object sender, EventArgs e)
        {
            btnUpgradeTower3.Enabled = false;


            Player.Gold = Player.Gold - upgrade2;
            upgrade3 += 600;
            this.Controls["btnUpgradeTower3"].Text = "Tier " + count3 + " Upgrade " + upgrade3 + "gp";
            Turrets.UpdateUpgrade(this, 3, 64);

            count3++;
            if (count3 == 6)
            {
                btnUpgradeTower3.Text = "Fully upgraded!";
            }
        }

        private void btnUpgradeTower4_Click(object sender, EventArgs e)
        {
            btnUpgradeTower4.Enabled = false;


            Player.Gold = Player.Gold - upgrade2;
            upgrade4 += 800;
            this.Controls["btnUpgradeTower4"].Text = "Tier " + count4 + " Upgrade " + upgrade4 + "gp";
            Turrets.UpdateUpgrade(this, 4, 30);

            count4++;
            if (count4 == 6)
            {
                btnUpgradeTower4.Text = "Fully upgraded!";
            }
        }



        private void Game_Load(object sender, EventArgs e)
        {
            //Me teeme nii, et kui klikid toweri peale, siis tekib button kust saad upgradeda.
            /*
            cmbUpgradesTower1.Items.Add("Tier 1 Upgrade = 50gp");
            cmbUpgradesTower1.Items.Add("Tier 2 Upgrade = 100gp");
            cmbUpgradesTower1.Items.Add("Tier 3 Upgrade = 200gp");
            cmbUpgradesTower1.Items.Add("Tier 4 Upgrade = 400gp");
            cmbUpgradesTower2.Items.Add("Tier 1 Upgrade = 50gp");
            cmbUpgradesTower2.Items.Add("Tier 2 Upgrade = 100gp");
            cmbUpgradesTower2.Items.Add("Tier 3 Upgrade = 200gp");
            cmbUpgradesTower2.Items.Add("Tier 4 Upgrade = 400gp");
            cmbUpgradesTower3.Items.Add("Tier 1 Upgrade = 50gp");
            cmbUpgradesTower3.Items.Add("Tier 2 Upgrade = 100gp");
            cmbUpgradesTower3.Items.Add("Tier 3 Upgrade = 200gp");
            cmbUpgradesTower3.Items.Add("Tier 4 Upgrade = 400gp");
            cmbUpgradesTower4.Items.Add("Tier 1 Upgrade = 50gp");
            cmbUpgradesTower4.Items.Add("Tier 2 Upgrade = 100gp");
            cmbUpgradesTower4.Items.Add("Tier 3 Upgrade = 200gp");
            cmbUpgradesTower4.Items.Add("Tier 4 Upgrade = 400gp");
            */
        }

        private void Game_Over()
        {
            if (Player.PlayerLivesLeft == 0)
            {
                lblGameOver.Text = "GAME OVER";
                lblGameOver.BringToFront();
                timer.Stop();
            }   
            else if (Player.PlayerLivesLeft < 0)
            {
                lblHitpoints.Text = "0";
                System.Threading.Thread.Sleep(4000);
                Application.Exit();

            }
        }

        int seconds = 0;
        int minutes = 0;
        private void timer_Tick(object sender, EventArgs e)
        {
            seconds++;
            minutes = (int)Math.Floor(seconds / 60.0);


            

            if ((seconds % 60).ToString().Length >= 2)
                lblTimer.Text = minutes.ToString() + ":" + (seconds % 60).ToString();
            else
                lblTimer.Text = minutes.ToString() + ":0" + (seconds % 60).ToString();


            //COUNT DOWN TIMER vvv
            /*
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
            */
        }
        int timercounter = 0;
        private void btnStart_Click(object sender, EventArgs e)
        {
            timercounter++;
            btnStart.Enabled = false;
            engine.StartRound();
            timer = new Timer();
            timer.Tick += (timer_Tick);
            timer.Enabled = true;
            timer.Interval = 1000;
            if (timercounter >= 2)
            {
                timer.Tick -= (timer_Tick);
            }
            if (lblEnemiesLeft.Text == "0")
            {
                engine.Update();
                btnStart.Enabled = true;
            }
            if (lblEnemiesLeft.Text != "0")
            {
                btnStart.Enabled = false;
            }
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

        private void lblGold_Click(object sender, EventArgs e)
        {

        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
        }

        private void btnCredits_Click(object sender, EventArgs e)
        {
            Credits crscreen = new Credits();
            crscreen.StartPosition = FormStartPosition.CenterParent;
            crscreen.ShowDialog(this);

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void lblTimer_Click(object sender, EventArgs e)
        {

        }
    }
}
