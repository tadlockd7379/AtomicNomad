namespace AtomicNomad.game.items
{
    public class GameObject
    {
        public readonly string ID;
        public readonly string Description;

        public GameObject(string id, string description)
        {
            ID = id;
            Description = description;
        }
    }
}
