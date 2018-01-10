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
        int numMonsters = 10;
        Timer monsterTimer;
        int curMonsters = 0;
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

        public void Update()
        {
            UpdateMonsters();
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


            Monster.NumMonsters++;

            if (curMonsters >= numMonsters)
                monsterTimer.Stop();
        }
        
        public void Update(Form form)
        {
            UpdateMonsters();
            UpdateTurrets(form);
        }

        private void UpdateTurrets(Form form)
        {
            
            turretsclass turret = new turretsclass();
            turret.Turret_spawn(form);
            turret.Turret_shoot(form, monsters);
        }
    }
}
