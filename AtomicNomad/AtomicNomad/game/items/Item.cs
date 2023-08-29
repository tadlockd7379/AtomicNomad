namespace AtomicNomad.game.items
{
    public class Item
    {
        public readonly string ID;
        public readonly string Description;

        public Item(string id, string description)
        {
            ID = id;
            Description = description;
        }
    }
}
