﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Budget_game
{
    class Monster : PictureBox
    {
        public Monster(Form form)
        {
            Image = System.Drawing.Image.FromFile("../../Sprites/Monster1.png");
            Size = new System.Drawing.Size(32, 32);
            curTile = 0;
            form.Controls.Add(this);
            Location = new System.Drawing.Point(0, Terrain.MapHeight * Terrain.TileSize / 2);
            BringToFront();
            TargetPos = form.Controls.Find("road0", false)[0].Location;
            
        }

        public void Attack()
        {

        }

        public void MoveMonster(Form form)
        {

            int a = Terrain.numRoadTiles;
            if (curTile + 1 >= Terrain.numRoadTiles)
            {
                Attack();
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

        System.Drawing.Point TargetPos { get; set; }
        public int movementSpeed { get; set; }
        public int MaximumHealth { get; set; }
        public int CurrentHealth { get; set; }
        public int Gold { get; set; }
        public int curTile { get; set; }
    }
}
