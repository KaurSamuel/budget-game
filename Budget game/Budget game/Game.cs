using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Budget_game
{
    class Game
    {
        List<Monster> monsters = new List<Monster>();
        int numMonsters = 10;

        public Game(Form1 form)
        {
            for (int i = 0; i < numMonsters; i++)
            {
                Monster monster = new Monster(form);

                monster.movementSpeed = 1;

                monsters.Add(monster);
            }
        }

        private void UpdateMonsters()
        {
            foreach(Monster monster in monsters)
            {
                monster.MoveMonster();
            }
        }

        public void Update()
        {
            UpdateMonsters();
        }

    }
}
