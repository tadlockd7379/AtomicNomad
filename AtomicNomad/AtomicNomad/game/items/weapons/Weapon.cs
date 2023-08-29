namespace AtomicNomad.game.items.weapons
{
    abstract class Weapon : Item
    {
        public int[] Damage;

        public Weapon(string id, string description) : base(id, description) {}

        public abstract void Attack();
    }
}
