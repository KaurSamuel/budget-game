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
        static int TileSize = 32;

        static int MapWidth = 16;
        static int MapHeight = 16;

        private static void GenerateRoad(Form form)
        {
            Random rnd = new Random();
            Point curPoint = new Point(0, MapHeight / 2);
            int tileCount = 0;

            while (true)
            {
                int side = rnd.Next(0, 101);

                if (side < 60) // RIGHT 
                    curPoint = new Point(curPoint.X + 1, curPoint.Y);

                else if (side < 80) //UP
                    if (curPoint.Y >= 0)
                        curPoint = new Point(curPoint.X, curPoint.Y + 1);
                    else
                        return;

                else if (side < 100)//DOWN
                    if (curPoint.Y <= MapHeight)
                        curPoint = new Point(curPoint.X, curPoint.Y - 1);
                    else
                        return;

                Tile control = new Tile();
                control.Size = new Size(TileSize, TileSize);
                control.Location = new Point(curPoint.X * TileSize, curPoint.Y * TileSize);
                control.Image = Image.FromFile("../../resources/road.png");
                control.Name = "Road" + tileCount;
                form.Controls.Add(control);
                control.BringToFront();

                tileCount++;

                if (curPoint.X == MapWidth - 1)
                    break;
            }

            //Adds first tile
            Tile firstTile = new Tile();
            firstTile.Size = new Size(TileSize, TileSize);
            firstTile.Location = new Point(0, MapHeight * TileSize / 2);
            firstTile.Image = Image.FromFile("../../resources/road.png");
            form.Controls.Add(firstTile);
            firstTile.BringToFront();
        }

        private static void GenerateMap(Form form)
        {
            int tileCount = 0;

            for (int i = 0; i < MapWidth; i++)
            {
                for (int j = 0; j < MapHeight; j++)
                {
                    Tile control = new Tile();
                    control.Size = new Size(TileSize, TileSize);
                    control.Name = "Terrain" + tileCount;
                    control.Location = new Point(i * TileSize, j * TileSize);
                    control.Image = Image.FromFile("../../resources/test.jpg");

                    form.Controls.Add(control);
                    tileCount++;
                }
            }
        }

        public static void GenerateTerrain(Form form)
        {
            GenerateMap(form);
            GenerateRoad(form);
        }
    }
}
