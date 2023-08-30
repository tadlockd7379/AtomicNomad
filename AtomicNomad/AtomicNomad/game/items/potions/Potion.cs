namespace AtomicNomad.game.items.potions
{
    abstract class Potion : GameObject
    {
        public Potion(string id, string description) : base(id, description) { }

        public abstract void Use();
    }
}
