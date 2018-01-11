﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using System.Diagnostics;

namespace Budget_game
{
    class turretsclass
    {

        public static List<Projectile> Projectiles = new List<Projectile>();

        public static void UpdateProjectiles(Form form)
        {
            List<Projectile> projectilesToRemove = new List<Projectile>();

            foreach(Projectile projectile in Projectiles)
            {
                if (projectile.UpdateProjectile(form) != null)
                    projectilesToRemove.Add(projectile);
            }

            foreach(Projectile projectile in projectilesToRemove)
            {
                form.Controls.Remove(projectile);
            }
        }

        public static void Turret_spawn(Form form, Point location)
        {
            bool Has_spawned = false;
            if (Has_spawned == false)
            {
                int Tilesize = (32);
                Point curpoint = new Point(500, 300);
                Turrets cannon = new Turrets();
                cannon.Size = new Size(Tilesize, Tilesize);
                cannon.Location = new Point(curpoint.X, curpoint.Y);
                cannon.Image = Image.FromFile("../../Sprites/Tower1.png");
                cannon.Turret_range = 150;


                cannon.ShootingTimer = new Stopwatch();
                cannon.ShootingTimer.Start();

                form.Controls.Add(cannon);
                cannon.BringToFront();
                Has_spawned = true;
            }
        }

        public static void CreateProjectile(Form form, Monster enemy, Turrets turret)
        {
            Projectile projectile = new Projectile();

            projectile.targetPoint = enemy.Location;
            projectile.Location = turret.Location;
            projectile.targetMonster = enemy;
            projectile.Damage = turret.Damage;

            form.Controls.Add(projectile);

            projectile.BringToFront();

            Projectiles.Add(projectile);

            turret.ShootingTimer.Start();
        }

        public static void Turret_shoot(Form form, List<Monster> monsters)
        {
            foreach (Monster monster in monsters)
            {
                
                foreach (Turrets turret in form.Controls.Find("Tower", true))
                {
                    if(monster.IsAlive)
                    {
                        if (turret.Location.X - monster.Location.X < turret.Turret_range &&
                            monster.Location.X - turret.Location.X > -turret.Turret_range &&
                            turret.Location.Y - monster.Location.Y < turret.Turret_range &&
                            monster.Location.Y - turret.Location.Y > -turret.Turret_range)
                        {
                            if(turret.ShootingTimer.ElapsedMilliseconds <= turret.Turret_shooting_speed)
                                continue;

                            turret.ShootingTimer.Restart();

                            CreateProjectile(form, monster, turret);

                           // monster.TakeDamage(form, 30);
                        }
                    }

                }
            }
       
        }
    }
}
