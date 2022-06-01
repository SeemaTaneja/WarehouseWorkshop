using System;
namespace WarehouseWorkshop
{
    public class Item
    {
        public string Name { get;}
        public decimal Price { get; private set;}
        public string Category { get;}
        public Item(string name, decimal price, string category)
        {
            Name = name;
            Price = price;
            Category = category;
        }
        public override string ToString()
        {
            return $"{Name}\n{Price}\n{Category}";
        }
    }


}