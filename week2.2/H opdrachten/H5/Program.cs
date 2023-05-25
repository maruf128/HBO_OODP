using System;

namespace ShoppingCart
{
    class ShopItem
    {
        // stell de variables vast
        public string ID { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }

        // constructor
        public ShopItem(string id, string name, double price)
        {
            ID = id;
            Name = name;
            Price = price;
        }
    }
}


namespace ShoppingCart
{
    class GroupedShopItem
    {
        // stel de variables vast
        public ShopItem Item { get; set; }
        public int Quantity { get; set; }

        // constructor
        public GroupedShopItem(ShopItem item)
        {
            Item = item;
            Quantity = 1;
        }
    }
}

namespace ShoppingCart
{
    class ShoppingCart
    {
        // stel de list vast via de groupedshopitems
        public List<GroupedShopItem> Groceries { get; set; }

        public void ShoppingCart()
        {
            // maak een nieuwe list
            Groceries = new List<GroupedShopItem>();
        }

        public void AddItem(ShopItem item)
        {
            // indien hij er in zit voeg je er een extra van toe anders add je hem
            GroupedShopItem groupedItem = FindItem(item);
            if (groupedItem != null)
            {
                groupedItem.Quantity++;
            }
            else
            {
                Groceries.Add(new GroupedShopItem(item));
            }
        }

        public GroupedShopItem FindItem(ShopItem item)
        {
            foreach (var groupedItem in Groceries)
            {
                // zoek naar een item en indien je hem vind return die anders return je null
                if (groupedItem.Item.ID == item.ID)
                {
                    return groupedItem;
                }
            }
            return null;
        }

        public string Contents()
        {
            // maak de string hier aan voor iedere item op basis van hoe codegrade het wilt
            string contents = "";
            foreach (var groupedItem in Groceries)
            {
                contents += groupedItem.Item.Name + " x " + groupedItem.Quantity + Environment.NewLine;
            }
            return contents;
        }

        public double TotalPrice()
        {
            // maak een double aan
            double total = 0;
            // voor iedere item pak je de prijs en de aantal en dan tel je dan zo op en return je dat
            foreach (var groupedItem in Groceries)
            {
                total += groupedItem.Item.Price * groupedItem.Quantity;
            }
            return total;
        }
    }
}

