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

        public Engine(Form form)
        {
            for (int i = 0; i < numMonsters; i++)
            {
                Monster monster = new Monster(form);

                monster.movementSpeed = 1;

                monsters.Add(monster);
            }

        }

        private void UpdateMonsters(Form form)
        {

            foreach(Monster monster in monsters)
            {

                    monster.MoveMonster(form);

                
            }

        }
        
        public void Update(Form form)
        {
            UpdateMonsters(form);
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
