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
    public partial class Form1 : Form
    {
        Engine game;
        Timer gameTime;

        public Form1()
        {
            InitializeComponent();

            game = new Engine(this);

            Terrain.GenerateTerrain(this);

            gameTime = new Timer();
            gameTime.Enabled = true;
            gameTime.Interval = 50;

            gameTime.Tick += new EventHandler(Frame);

        }

        void Frame(object sender, EventArgs e)
        {
            game.Update();
        }
    }
}
