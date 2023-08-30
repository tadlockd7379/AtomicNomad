using System;

namespace AtomicNomad.game.items.weapons
{
    class RangedWeapon : Weapon
    {
        public readonly string ProjectileID;

        public RangedWeapon(string id, string description, int[] damage, string projectile) : base(id, description)
        {
            Damage = damage;
            ProjectileID = projectile;
        }

        public override void Attack()
        {
            GameObject projectile = Game.Items.Miscellaneous[ProjectileID];
            // make sure the player has it

            int damage = Game.RNG.RandomIntBetween(Damage[0], Damage[1]);

            Console.WriteLine($"You shot dummy with {ID} using {projectile.ID} and did {damage} damage!");
        }
    }
}
