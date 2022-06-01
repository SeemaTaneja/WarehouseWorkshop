namespace WarehouseWorkshop
{
    public class Basket
    {
        public Dictionary<Item, int> Contents { get; } = new Dictionary<Item, int>();

        public void AddItem(Item item, int amount)
        {
            if (Contents.ContainsKey(item))
            {
                Contents[item] += amount;
            }
            else
            {
                Contents.Add(item, amount);
            }
        }
        public void RemoveItem(Item item, int amount)
        {
            if (Contents.ContainsKey(item))
            {
                if (amount > Contents[item])
                {
                    throw new ArgumentOutOfRangeException("Attempted to remove more items than are present in the basket");
                }
                Contents[item] -= amount;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Item to be removed is not present in the basket");
            }

        }
    }
}

}