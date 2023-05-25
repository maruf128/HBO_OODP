using System;
namespace ShopItem
{
    class ShopItemDetails
    {
        // stell de variables vast
        public string ID { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }

        // constructor
        public ShopItemDetails(string id, string name, double price)
        {
            ID = id;
            Name = name;
            Price = price;
        }
    }
}