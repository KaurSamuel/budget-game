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
        public static int numMonsters = 10;
        Timer monsterTimer;
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
            foreach(Turrets turret in form.Controls.Find("Tower"), false)
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

        }

        public void StartRound()
        {
            monsterTimer = new Timer();
            monsterTimer.Enabled = true;
            monsterTimer.Interval = 2000;
            monsterTimer.Tick += new EventHandler(SpawnMobs);
        }


        public void SpawnMobs(object sender, EventArgs e)
        {
            Monster monster = new Monster(form);

            monster.movementSpeed = 1;

            monsters.Add(monster);

            curMonsters++;

            if (curMonsters >= numMonsters)
                monsterTimer.Stop();
        }

        private void UpdateTurrets(Form form)
        {
            turretsclass.Turret_shoot(form, monsters);
        }
    }
}
