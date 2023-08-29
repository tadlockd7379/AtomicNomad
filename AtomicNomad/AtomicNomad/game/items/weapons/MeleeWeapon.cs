using System;
using AtomicNomad.game.items.weapons;

namespace AtomicNomad.game.items
{
     class MeleeWeapon : Weapon
    {
        public MeleeWeapon(string id, string description, int[] damage) : base(id, description)
        {
            Damage = damage;
        }

        public override void Attack()
        {
            int damage = Game.RNG.RandomIntBetween(Damage[0], Damage[1]);
            Console.WriteLine($"You hit dummy with {ID} and did {damage} damage!");
        }
    }
}
