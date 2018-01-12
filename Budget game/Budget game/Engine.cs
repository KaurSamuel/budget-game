using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Windows.Forms;
using Budget_game;
using Budget_game.Properties;

namespace Budget_game
{
    class Engine
    {
        List<Monster> monsters = new List<Monster>();
        List<Monster> MonstersToSpawn = new List<Monster>();
        public static int numMonsters = 10;
        Timer monsterTimer;
        public static int CurLevel = 1;
        public static int curMonsters = 0;
        Form form;

        public Engine(Form _form)
        {
            form = _form;
        }

        private void UpdateMonsters()
        {

            foreach(Monster monster in monsters)
            {
                monster.MoveMonster(form);
            }

        }

        private void CheckTurrets()
        {
            //foreach(Turrets turret in form.Controls.Find("Tower"), false)
            {

            }

        }

        public void Update()
        {
            UpdateMonsters();

            UpdateTurrets(form);

            Monster.UpdateLabel(form);
            Player.UpdateCoins(form);
            Store.UpdateBuyable(form);
            Store.UpdateTurretBought(form);
            turretsclass.UpdateProjectiles(form);
        }

        public void StartRound()
        {
            System.Media.SoundPlayer sp = new System.Media.SoundPlayer(@"../../sound.wav");
            sp.PlayLooping();

            InitMobs(CurLevel);

            monsterTimer = new Timer();
            monsterTimer.Enabled = true;
            monsterTimer.Interval = 600;
            monsterTimer.Tick += new EventHandler(SpawnMobs);
        }

        public void InitMobs(int level)
        {
            string[] allLines = System.IO.File.ReadAllLines("../../levels/level" + level + ".txt");
            int monToRemove = 0;
            Monster.MonstersAlive = 0;

            foreach (string line in allLines)
            {
                Monster monster = new Monster(form);
                

                switch (line)
                {
                    case "0":
                        MonstersToSpawn.Add(null);
                        monster.Dispose();
                        monToRemove++;
                        continue;

                    case "1":
                        monster.MaximumHealth = 50;
                        monster.Gold = 20;
                        monster.movementSpeed = 2;
                        monster.Image = System.Drawing.Image.FromFile("../../Sprites/monster1.png");
                        break;
                    case "2":
                        monster.MaximumHealth = 100;
                        monster.Gold = 70;
                        monster.movementSpeed = 4;
                        monster.Image = System.Drawing.Image.FromFile("../../Sprites/monster2.png");
                        break;
                    case "3":
                        monster.MaximumHealth = 1200;
                        monster.Gold = 240;
                        monster.movementSpeed = 1;
                        monster.Image = System.Drawing.Image.FromFile("../../Sprites/monster3.png");
                        break;

                    case "4":
                        monster.MaximumHealth = 300;
                        monster.Gold = 40;
                        monster.movementSpeed = 2;
                        monster.Image = System.Drawing.Image.FromFile("../../Sprites/monster4.png");
                        break;

                    case "5":
                        monster.MaximumHealth = 150;
                        monster.Gold = 40;
                        monster.movementSpeed = 2;
                        monster.Image = System.Drawing.Image.FromFile("../../Sprites/monster5.png");
                        break;

                    default:
                        return;
                }

                monster.CurrentHealth = monster.MaximumHealth;

                monster.Visible = false;

                MonstersToSpawn.Add(monster);
            }

            Monster.MonstersAlive = MonstersToSpawn.Count - monToRemove;
        }

        public void SpawnMobs(object sender, EventArgs e)
        {
            if (MonstersToSpawn[0] == null)
            {
                MonstersToSpawn.RemoveAt(0);
                return;
            }

            MonstersToSpawn[0].Visible = true;

            monsters.Add(MonstersToSpawn[0]);

            MonstersToSpawn.RemoveAt(0);

            if (MonstersToSpawn.Count <= 0)
            {
                monsterTimer.Stop();
                return;
            }
                
        }

        private void UpdateTurrets(Form form)
        {
            turretsclass.Turret_shoot(form, monsters);
        }
    }
}
