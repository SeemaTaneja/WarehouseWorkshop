using System;
namespace WarehouseWorkshop
{
    class Program
    {
        public static void Main(string[] args)
        {
            Item apple = new Item("Apple", 0.5M, "groceries");
            Item orange = new Item("Orange", 1.5M, "groceries");
            Item ps4 = new Item("Game", 5, "entertainment");
            Item color = new Item("Colors", 2, "stationary");
            Item book = new Item("Mathbook", 8, "stationary");
            Warehouse warehouse = new Warehouse(
                new Dictionary<Item, int>
                {
                    {apple, 20},
                    {orange, 10},
                    {ps4, 5},
                    {color, 15},
                    {book, 35},
                }
            );
            Console.WriteLine("Initial stock");
            foreach (Item item in warehouse.ItemsInStock.Keys)
            {
                Console.WriteLine($"There are {warehouse.ItemsInStock[item]} of item \"{item.Name}\" at £{item.Price} each");
            }
        }
    }
}
