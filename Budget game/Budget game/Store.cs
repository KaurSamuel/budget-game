using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;
using System.Diagnostics;

namespace Budget_game
{
    class Store
    {
        public static int curControlCount = 0;
        public static Turrets curControl = new Turrets(0);

        public Store()
        {

        }

        public static void UpdateBuyable(Form form)
        {
            for(int i = 1; i < 5; i++)
            {
                Control curControl = form.Controls["StoreTurret" + i.ToString() + "Price"];
                if (Int32.Parse(curControl.Text.Substring(0, 3)) <= Player.Gold)
                {
                    curControl.BackColor = System.Drawing.Color.Green;
                }

                else 
                {
                    curControl.BackColor = System.Drawing.Color.Red;
                }
            }
        }

        public static void Buy(Form form, string controlName)
        {

            var money = form.Controls[controlName + "Price"].Text;
            if (Int32.Parse(money.Substring(0, 3)) <= Player.Gold)
            {
                curControl = form.Controls["BoughtTurret"] as Turrets;

                Player.Gold -= Int32.Parse(money.Substring(0, 3));

                curControl.Image = (form.Controls[controlName] as PictureBox).Image;
                curControl.Show();
                curControl.Enabled = true;

                curControlCount = (int)Char.GetNumericValue(controlName[11]);

            }
        }

        public static void Purchased()
        {

        }

        public static void Place(Form form)
        {
            System.Drawing.Point newPos = new System.Drawing.Point();

            if (curControl.Visible)
            {
                System.Drawing.Point mousePos = form.PointToClient(Cursor.Position);

                newPos.X = (mousePos.X / 32) * 32;
                newPos.Y = (mousePos.Y / 32) * 32;

                curControl.Location = newPos;
                curControl.BringToFront();

                if (curControl.Location.X < 32 * 32 && curControl.Location.Y < (16 * 32))
                {
                    Turrets newTurret = new Turrets(curControlCount);
                    newTurret.ShootingTimer = new Stopwatch();
                    newTurret.ShootingTimer.Start();

                    newTurret.Location = newPos;

                    form.Controls.Add(newTurret);
                    newTurret.BringToFront();

                    curControl.Enabled = false;
                    curControl.Visible = false;
                }
            }
        }

        private static void Form_MouseClick(object sender, MouseEventArgs e)
        {
            throw new NotImplementedException();
        }

        public static void UpdateTurretBought(Form form)
        {
            System.Drawing.Point newPos = new System.Drawing.Point();

            if (curControl.Visible)
            {
                System.Drawing.Point mousePos = form.PointToClient(Cursor.Position);

                newPos.X = (mousePos.X / 32) * 32;
                newPos.Y = (mousePos.Y / 32) * 32;

                curControl.Location = newPos;
                curControl.BringToFront();
            }
        }
    }
}
