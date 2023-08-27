namespace AtomicNomad.game.items
{
    class Item
    {
        public readonly string id;
        public readonly string description;

        /// <summary>
        /// Create a generic Item.
        /// </summary>
        /// <param name="id">Item ID/Name. Uses this to grab the data from the data files.</param>
        /// <param name="description">Item Description. This is what the user sees.</param>
        public Item(string id, string description)
        {
            this.id = id;
            this.description = description;
        }
    }
}
