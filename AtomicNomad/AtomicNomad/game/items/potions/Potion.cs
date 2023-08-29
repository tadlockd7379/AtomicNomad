namespace AtomicNomad.game.items.potions
{
    abstract class Potion : Item
    {
        public Potion(string id, string description) : base(id, description) { }

        public abstract void Use();
    }
}
