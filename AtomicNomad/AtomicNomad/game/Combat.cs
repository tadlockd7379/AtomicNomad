using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using static AtomicNomad.game.MOBs;

namespace AtomicNomad.game
{
    class Combat
    {
        bool active;
        LivingEntity[] enemies;

        public Combat(LivingEntity[] enemies)
        {
            this.enemies = enemies;
            this.active = true;

            Console.WriteLine("Combat started with " + enemies.Length + " enemies.");

            ListEnemies();

            // temporary automatic test combat
            while (active)
            {
                foreach (LivingEntity enemy in enemies)
                {
                    Thread.Sleep(500);
                    if (enemy.hp > 0 && Game.player.hp > 0)
                    {

                        bool attack = Game.player.Attack(enemy.attackPower);
                        if (attack == false)
                        {
                            Console.WriteLine("Attack missed on " + enemy.ID);
                        }
                        else
                        {
                            double damage = Game.player.attackPower;
                            enemy.hp -= damage;
                            Console.WriteLine($"{enemy.ID} ({enemy.hp}/{enemy.maxHp} HP) from slashing damage");
                            if (enemy.hp < 0)
                            {
                                Console.WriteLine("Killed " + enemy.ID);
                            }
                            else
                            {
                                bool attackPlayer = Game.player.Attack(enemy.attackPower);
                                if (attackPlayer == false)
                                {
                                    Console.WriteLine("Attack missed on " + Game.player.ID);
                                }
                                else
                                {
                                    Game.player.hp -= enemy.attackPower;
                                    Console.WriteLine($"{Game.player.ID} ({Game.player.hp}/{Game.player.maxHp} HP)");
                                    if (Game.player.hp < 0)
                                    {
                                        Console.WriteLine("You Died!");
                                        this.active = false;
                                    }
                                }
                            }
                        }
                    }
                }
            }

            void ListEnemies()
            {
                foreach (LivingEntity enemy in enemies)
                {
                    Console.WriteLine($"{enemy.ID} ({enemy.hp}/{enemy.maxHp} hp) / {enemy.attackPower} ATK");
                }
            }
        }
    }
}
