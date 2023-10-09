using AtomicNomad.game;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtomicNomad.game
{
    public class LivingEntity : GameObject
    {
        public double maxHp;
        public double hp;
        public double attackPower;
        public GameObject[] inventory;

        public LivingEntity(string id, string description, double hp, double attackPower) : base(id, description)
        {
            this.maxHp = hp;
            this.hp = hp;
            this.attackPower = attackPower;
        }

        public bool Attack(double defenseToBeat)
        {
            int roll = Game.RNG.RandomIntBetween(1, 24);
            if (roll < defenseToBeat) return false;
            return true;
        }
    }
}
