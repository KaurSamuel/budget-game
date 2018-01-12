using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace Budget_game
{
    class Terrain
    {
        public static int TileSize = 32;
        public static int numRoadTiles = 1;

        public static int CurLevel { get; set; }

        public static int MapWidth = 32;
        public static int MapHeight = 16;

        private static void GenerateRoad(Form form)
        {
            Random rnd = new Random();
            Point curPoint = new Point(0, MapHeight / 2);
            bool isPrevVertical = false;
            int prevSide = 0;
            bool addLastTile = true;

            //Adds first tile
            Tile firstTile = new Tile();
            firstTile.Name = "road0";
            firstTile.Size = new Size(TileSize, TileSize);
            firstTile.Location = new Point(0, (MapHeight * TileSize) / 2);
            firstTile.Image = Image.FromFile("../../Sprites/roadUP.png");
            form.Controls.Add(firstTile);
            firstTile.BringToFront();
            numRoadTiles++;

            while (true)
            {
                int side = rnd.Next(0, 101);

                if (side < 7) // RIGHT 
                {
                    if (isPrevVertical)
                    {
                        if (curPoint.X >= MapWidth - 2)
                        {
                            break;
                        }

                        curPoint = new Point(curPoint.X + 1, curPoint.Y);

                        Tile sideControl = new Tile();
                        sideControl.Size = new Size(TileSize, TileSize);
                        sideControl.Location = new Point(curPoint.X * TileSize, curPoint.Y * TileSize);
                        sideControl.Image = Image.FromFile("../../Sprites/roadUP.png");
                        sideControl.Name = "Road" + numRoadTiles;
                        form.Controls.Add(sideControl);
                        sideControl.BringToFront();

                        numRoadTiles++;


                    }
                    curPoint = new Point(curPoint.X + 1, curPoint.Y);
                    prevSide = 0;
                    isPrevVertical = false;
                }


                else if (side < 50) //UP
                    if (curPoint.Y <= MapHeight - 3)
                    {
                        if (prevSide == 2)
                            continue;

                        curPoint = new Point(curPoint.X, curPoint.Y + 1);
                        isPrevVertical = true;
                        prevSide = 1;
                    }

                    else
                        continue;

                else if (side < 100)//DOWN
                    if (curPoint.Y >= 3)
                    {
                        if (prevSide == 1)
                            continue;

                        curPoint = new Point(curPoint.X, curPoint.Y - 1);
                        isPrevVertical = true;
                        prevSide = 2;
                    }

                    else
                        continue;

                Tile control = new Tile();
                control.Size = new Size(TileSize, TileSize);
                control.Location = new Point(curPoint.X * TileSize, curPoint.Y * TileSize);
                control.Image = Image.FromFile("../../Sprites/roadUP.png");
                control.Name = "Road" + numRoadTiles;
                form.Controls.Add(control);
                control.BringToFront();

                numRoadTiles++;

                if (curPoint.X >= MapWidth - 2)
                {
                    break;
                }
            }

            PictureBox house = new PictureBox();
            house.Image = System.Drawing.Image.FromFile("../../Sprites/castle.png");
            house.SizeMode = PictureBoxSizeMode.AutoSize;
            house.Location = new Point(curPoint.X * TileSize - 32, curPoint.Y * TileSize);
            form.Controls.Add(house);
            house.BringToFront();

        }

        private static void GenerateMap(Form form)
        {
            Random rnd = new Random();
            int tileCount = 0;

            for (int i = 0; i < MapWidth; i++)
            {
                for (int j = 0; j < MapHeight; j++)
                { 

                    Tile control = new Tile();
                    control.Size = new Size(TileSize, TileSize);
                    control.Name = "Terrain" + tileCount;
                    control.Location = new Point(i * TileSize, j * TileSize);
                    control.Image = Image.FromFile("../../Sprites/grass.png");

                    int chance = rnd.Next(0, 101);
                    if (chance < 50)
                        control.Image = Image.FromFile("../../Sprites/grass.png");
                    else if (chance < 60)
                        control.Image = Image.FromFile("../../Sprites/water.png");
                    else if (chance < 80)
                        control.Image = Image.FromFile("../../Sprites/sand.png");
                    

                    form.Controls.Add(control);
                    tileCount++;
                }
            }
        }

        public static void GenerateTerrain(Form form)
        {
            GenerateMap(form);
            GenerateRoad(form);

            CurLevel++;
            form.Controls["lblLevel"].Text = CurLevel.ToString();
        }
    }
}
