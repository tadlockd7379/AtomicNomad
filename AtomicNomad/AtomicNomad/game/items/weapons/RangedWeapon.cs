using Newtonsoft.Json.Linq;
using System;
using System.Linq;

namespace AtomicNomad.game.items.weapons
{
    class RangedWeapon : Weapon
    {
        string projectile; // will eventually take an Item class for the projectile to fire

        public RangedWeapon(string id, string description, int minDamage, int maxDamage, string projectile) : base(id, description)
        {
            this.minDamage = minDamage;
            this.maxDamage = maxDamage;
            this.projectile = projectile;
        }

        public override void Attack()
        {
            // check if player has the required material
            // remove the material if they have it, otherwise tell them they don't and let them try to attack again with something else

            int damage = Game.rng.randomIntBetween(minDamage, maxDamage);

            Console.WriteLine($"You shot dummy with {id} using {projectile} and did {damage} damage!");
        }

        public static RangedWeapon FromData(string id, JToken data)
        {
            string description = data.SelectToken("description").ToString();
            JToken damage = data.SelectToken("damage");
            int minDamage = int.Parse(damage.First().ToString());
            int maxDamage = int.Parse(damage.Last().ToString());
            string projectile = data.SelectToken("projectile").ToString();

            return new RangedWeapon(id, description, minDamage, maxDamage, projectile);
        }
    }
}
