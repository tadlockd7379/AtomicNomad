namespace AtomicNomad.game.items.weapons
{
    abstract class Weapon : Item
    {
        public int minDamage;
        public int maxDamage;

        public Weapon(string id, string description) : base(id, description) {}

        public abstract void Attack();
    }
}
