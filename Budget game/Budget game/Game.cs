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


        //See meetod peaks tegema turreti peale clickides buttoni kust saad turretit upgradeda.
        private void TurretUpgrade_Click(Form form, EventArgs e, object sender)
        {

            //this.BoughtTurret
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
