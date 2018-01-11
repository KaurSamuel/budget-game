using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Budget_game
{
    class Monster : PictureBox
    {
        System.Drawing.Point TargetPos { get; set; }
        public int movementSpeed { get; set; }
        public int MaximumHealth { get; set; }
        public int CurrentHealth { get; set; } = 50;
        public int Gold { get; set; } = 10;
        public static int MonstersAlive { get; set; } = Engine.numMonsters;
        public int curTile { get; set; }
        public bool IsAlive { get; set; } = true;
        Form form;


        public Monster(Form _form)
        {
            Image = System.Drawing.Image.FromFile("../../Sprites/Monster1.png");
            Size = new System.Drawing.Size(32, 32);
            curTile = 1;
            _form.Controls.Add(this);
            Name = "monster";
            Location = new System.Drawing.Point(0, Terrain.MapHeight * Terrain.TileSize / 2);
            BackColor = System.Drawing.Color.Transparent;
            BringToFront();
            TargetPos = _form.Controls.Find("road0", false)[0].Location;
            form = _form;
        }

        public static void UpdateLabel(Form form)
        {
            form.Controls["lblEnemiesLeft"].Text = MonstersAlive.ToString();
        }

        public void Attack(Form form)
        {
            if(!IsAlive)
            {
                return;
            }

            Player.PlayerLivesLeft--;
            form.Controls["lblHitpoints"].Text = Player.PlayerLivesLeft.ToString();

            form.Controls.Remove(this);
            IsAlive = false;

            Engine.numMonsters--;

            UpdateLabel(form);
        }

        public void TakeDamage(Form form, int damage)
        {
            CurrentHealth -= damage;

            if (CurrentHealth <= 0 && IsAlive)
            {
                IsAlive = false;
                form.Controls.Remove(this);
                Player.Gold += Gold;

                MonstersAlive--;
            }
            
        }
        protected override void OnPaint(PaintEventArgs pe)
        {
            CurrentHealth -= 1;
            SolidBrush redBrush = new SolidBrush(Color.Red);
            base.OnPaint(pe);
            pe.Graphics.FillRectangle(redBrush, 0, 27, CurrentHealth, 5);
           
        }

       

        public void MoveMonster(Form form)
        {
            if (curTile + 2 >= Terrain.numRoadTiles)
            {
                Attack(form);
                return;
            }

            if (TargetPos == Location)
            {
                curTile++;
                TargetPos = form.Controls.Find("road" + curTile, false)[0].Location;
            }
            
            System.Drawing.Point delta = new System.Drawing.Point();
            delta.X = Location.X - TargetPos.X;
            delta.Y = Location.Y - TargetPos.Y;

            if (delta.X < 0)
                Location = new System.Drawing.Point(Location.X + movementSpeed, Location.Y);
            else if (delta.X > 0)
                Location = new System.Drawing.Point(Location.X - movementSpeed, Location.Y);
            else if (delta.Y < 0)
                Location = new System.Drawing.Point(Location.X, Location.Y + movementSpeed);
            else if (delta.Y > 0)
                Location = new System.Drawing.Point(Location.X, Location.Y - movementSpeed);


        }


    }
}
