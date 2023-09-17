namespace AtomicNomad.game.items.RoomData
{
    abstract class RoomData : GameObject
    {
        public RoomData(string id, string description) : base(id, description) { }

        public abstract void Use();
    }
}