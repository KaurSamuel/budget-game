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

        public static void GenerateTerrain(Form form)
        {
            int tileCount = 0;

            for (int i = 0; i < MapWidth; i++)
            {
                for (int j = 0; j < MapHeight; j++)
                {
                    Tile control = new Tile();
                    control.Name = "Tile" + tileCount.ToString();
                    control.Size = new Size(TileSize, TileSize);
                    control.Location = new Point(MapWidth * TileSize, MapHeight * TileSize);
                    control.Image = Image.FromFile("../../resources/test.jpg");

                    form.Controls.Add(control);
                    tileCount++;
                }
            }
        }
    }
}
