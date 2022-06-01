using WarehouseWorkshop.Transactions;
namespace WarehouseWorkshop
{

    public class Warehouse
    {
        public Dictionary<Item, int> ItemsInStock = new Dictionary<Item, int>();
        public List<Transaction> Transactions { get; } = new List<Transaction>();
        public Account Account { get; } = new Account();
        public Warehouse(Dictionary<Item, int> initialStock)
        {
            ItemsInStock = initialStock;
        }
        public void SellItems(Dictionary<Item, int> items, Account buyer, string modeOfPayment)
        {
            foreach (Item item in items.Keys)
            {
                if (!ItemsInStock.ContainsKey(item))
                {
                    throw new ArgumentOutOfRangeException("Attempted to buy an item that warhouse doesnot have stock");
                }
                if (ItemsInStock[item] < items[item])
                {
                    throw new ArgumentOutOfRangeException("Attempted to buy more of an item that warehouse has in stock ");
                }
            }
            decimal total = 0;

            foreach (Item item in items.Keys)
            {
                ItemsInStock[item] -= items[item];
                total += item.Price * items[item];
            }
            Account.Amount += total;
            buyer.Amount -= total;

            Transaction transaction = new Transaction
            (
                items,
                DateTime.Now,
                buyer,
                Account,
                modeOfPayment
            );
            Transactions.Add(transaction);
        }
    }

}