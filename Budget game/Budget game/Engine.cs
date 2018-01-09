using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Budget_game
{
    class Engine
    {
        List<Monster> monsters = new List<Monster>();
        int numMonsters = 10;
        Stopwatch stopwatch = new Stopwatch();
        

        public Engine(Form1 form)
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
                if(Stopwatch.GetTimestamp() >= 1000)
                monster.MoveMonster();
            }
        }

        public void Update()
        {
            UpdateMonsters();
        }

    }
}
