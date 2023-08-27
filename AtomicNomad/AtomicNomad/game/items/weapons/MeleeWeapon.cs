using System;
using System.Linq;
using AtomicNomad.game.items.weapons;
using Newtonsoft.Json.Linq;

namespace AtomicNomad.game.items
{
     class MeleeWeapon : Weapon
    {
        public MeleeWeapon(string id, string description, int minDamage, int maxDamage) : base(id, description)
        {
            this.minDamage = minDamage;
            this.maxDamage = maxDamage;
        }

        public override void Attack()
        {
            int damage = Game.rng.randomIntBetween(minDamage, maxDamage);
            Console.WriteLine($"You hit dummy with {id} and did {damage} damage!");
        }

        public static MeleeWeapon FromData(string id, JToken data)
        {
            string description = data.SelectToken("description").ToString();
            JToken damage = data.SelectToken("damage");
            int minDamage = int.Parse(damage.First().ToString());
            int maxDamage = int.Parse(damage.Last().ToString());

            return new MeleeWeapon(id, description, minDamage, maxDamage);
        }
    }
}
