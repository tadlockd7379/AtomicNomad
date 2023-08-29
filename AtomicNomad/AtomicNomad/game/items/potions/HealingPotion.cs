using System;

namespace AtomicNomad.game.items.potions
{
    class HealingPotion : Potion
    {
        public double HealingAmount;

        public HealingPotion(string id, string description, double healingAmount) : base(id, description)
        {
            HealingAmount = healingAmount;
        }

        public override void Use()
        {
            Console.WriteLine($"Healed for {HealingAmount} using {ID}!");
        }
    }
}
