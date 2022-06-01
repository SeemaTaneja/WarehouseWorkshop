using System;
namespace WarehouseWorkshop
{

    public class Warehouse
    {
        public Dictionary<Item, int> ItemsInStock = new Dictionary<Item, int>();
        // List<int> Transaction = new List<int>();
        // public int Account { get; }
        public Warehouse(Dictionary<Item, int> initialStock)
        {
            ItemsInStock = initialStock;
        }
        //     public void SellItem(Item item, int account)
        //     {
        //         ItemsInStock.Remove(item, account);
        //     }
        //     public void BuyItem(Item item, int account)
        //     {
        //         ItemsInStock.Add(item);
        //     }
    }

}