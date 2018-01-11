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
            engineTimer.Interval = 1;
            engineTimer.Tick += new EventHandler(Frame);

            
        }

        void Frame(object sender, EventArgs e)
        {
            engine.Update();
            Game_Over();
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
        int counter01 = 0;
        int counter02 = 0;
        int counter03 = 0;
        int counter04 = 0;

        private void btnUpgradeTower1_Click(object sender, EventArgs e)
        {
            if (counter01 >= 1)
                btnUpgradeTower1.Enabled = false;
                if (Player.Gold >= 100)
                {
                    btnUpgradeTower1.Enabled = true;
                    counter01++;
                    btnUpgradeTower1.Text = "Tier 2 Upgrade 300gp";
                    Player.Gold = Player.Gold - 100;
                if (counter01 >= 2)
                {
                    //Player.Gold = Player.Gold - 100;
                    btnUpgradeTower1.Enabled = false;
                    if (Player.Gold >= 300)
                    {
                        btnUpgradeTower1.Enabled = true;
                        //counter01++;
                        btnUpgradeTower1.Text = "Tier 3 Upgrade 600gp";
                        Player.Gold = Player.Gold - 200;
                        if (counter01 >= 3)
                        {
                            //Player.Gold = Player.Gold - 200;
                            btnUpgradeTower1.Enabled = false;
                            if (Player.Gold >= 600)
                            {
                                btnUpgradeTower1.Enabled = true;
                                Player.Gold = Player.Gold - 300;
                                //counter01++;
                                btnUpgradeTower1.Text = "Tier 4 Upgrade 1000gp";
                                if (counter01 >= 4)
                                {
                                    //Player.Gold = Player.Gold - 300;
                                    btnUpgradeTower1.Enabled = false;
                                    if (Player.Gold >= 1000)
                                    {
                                        btnUpgradeTower1.Enabled = false;
                                        Player.Gold = Player.Gold - 400;
                                        //counter01++;
                                        btnUpgradeTower1.Text = "Fully upgraded";
                                        if (counter01 >= 5)
                                        {
                                            //Player.Gold = Player.Gold - 400;
                                            btnUpgradeTower1.Enabled = false;
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }   

        }

        private void btnUpgradeTower2_Click(object sender, EventArgs e)
        {

            if (counter02 >= 1)
                btnUpgradeTower2.Enabled = false;
            if (Player.Gold >= 150)
            {
                btnUpgradeTower2.Enabled = true;
                counter02++;
                btnUpgradeTower2.Text = "Tier 2 Upgrade 450gp";
                Player.Gold = Player.Gold - 150;
                if (counter02 >= 2)
                {
                    //Player.Gold = Player.Gold - 100;
                    btnUpgradeTower2.Enabled = false;
                    if (Player.Gold >= 450)
                    {
                        btnUpgradeTower2.Enabled = true;
                        //counter01++;
                        btnUpgradeTower2.Text = "Tier 3 Upgrade 1100gp";
                        Player.Gold = Player.Gold - 300;
                        if (counter02 >= 3)
                        {
                            //Player.Gold = Player.Gold - 200;
                            btnUpgradeTower2.Enabled = false;
                            if (Player.Gold >= 1100)
                            {
                                btnUpgradeTower2.Enabled = true;
                                Player.Gold = Player.Gold - 450;
                                //counter01++;
                                btnUpgradeTower2.Text = "Tier 4 Upgrade 1500gp";
                                if (counter02 >= 4)
                                {
                                    //Player.Gold = Player.Gold - 300;
                                    btnUpgradeTower2.Enabled = false;
                                    if (Player.Gold >= 1500)
                                    {
                                        btnUpgradeTower2.Enabled = false;
                                        Player.Gold = Player.Gold - 600;
                                        //counter01++;
                                        btnUpgradeTower2.Text = "Fully upgraded";
                                        if (counter02 >= 5)
                                        {
                                            //Player.Gold = Player.Gold - 400;
                                            btnUpgradeTower2.Enabled = false;
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        private void btnUpgradeTower3_Click(object sender, EventArgs e)
        {
            if (counter03 >= 1)
                btnUpgradeTower3.Enabled = false;
            if (Player.Gold >= 200)
            {
                btnUpgradeTower2.Enabled = true;
                counter03++;
                btnUpgradeTower3.Text = "Tier 2 Upgrade 600gp";
                Player.Gold = Player.Gold - 200;
                if (counter03 >= 2)
                {
                    //Player.Gold = Player.Gold - 100;
                    btnUpgradeTower3.Enabled = false;
                    if (Player.Gold >= 600)
                    {
                        btnUpgradeTower3.Enabled = true;
                        //counter01++;
                        btnUpgradeTower3.Text = "Tier 3 Upgrade 1200gp";
                        Player.Gold = Player.Gold - 400;
                        if (counter03 >= 3)
                        {
                            //Player.Gold = Player.Gold - 200;
                            btnUpgradeTower3.Enabled = false;
                            if (Player.Gold >= 1200)
                            {
                                btnUpgradeTower3.Enabled = true;
                                Player.Gold = Player.Gold - 600;
                                //counter01++;
                                btnUpgradeTower3.Text = "Tier 4 Upgrade 2000gp";
                                if (counter03 >= 4)
                                {
                                    //Player.Gold = Player.Gold - 300;
                                    btnUpgradeTower3.Enabled = false;
                                    if (Player.Gold >= 2000)
                                    {
                                        btnUpgradeTower3.Enabled = false;
                                        Player.Gold = Player.Gold - 800;
                                        //counter01++;
                                        btnUpgradeTower3.Text = "Fully upgraded";
                                        if (counter03 >= 5)
                                        {
                                            //Player.Gold = Player.Gold - 400;
                                            btnUpgradeTower3.Enabled = false;
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }

        }

        private void btnUpgradeTower4_Click(object sender, EventArgs e)
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



        //Experimental
        private static void DisposeMethod()
        {
            var form = new Game();
            form.Show();
            form.Close();
            // the GC calls below will do NOTHING, because you still have a reference to the form!
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            GC.WaitForPendingFinalizers();

            // another thing to not: calling ShowDialog will NOT get Dispose called on your form when you close it
            var form2 = new Game();
            DialogResult r = form2.ShowDialog();
            // you MUST manually call dispose after calling ShowDialog! Otherwise Dispose will never get called.
            form2.Dispose();

            // as for grids, this will ALSO result in never releasing the form in memory, because the GridControl has a reference to the Form itself (look at the auto-generated designer code)
            var form3 = new Game();
            form3.ShowDialog();
            // note that if you're planning on actually using your datagrid after calling dispose on the form, you're going to have problems, since calling Dipose() on the form will also call dispose on all the child controls
            form3.Dispose();
            form3 = null;
        }
    }
}
