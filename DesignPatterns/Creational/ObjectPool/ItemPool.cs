namespace DesignPatterns.Creational.ObjectPool
{
    internal class ItemPool
    {
        private readonly IReadOnlyCollection<Item> _items;
        public ItemPool(int count)
        {
            _items = Enumerable.Range(0, count).Select(_ => new Item()).ToArray();
        }

        public Item? Acquire()
        {
            var item = _items.FirstOrDefault(i => !i.IsVisible);
            if (item != null)
            {
                item.IsVisible = true;
            }
            return item;
        }
    }
}
