using System;
namespace GroupedShopItem
{
    class GroupedShopItem
    {
        // stel de variables vast
        public ShopItemDetails Item { get; set; }
        public int Quantity { get; set; }

        // constructor
        public GroupedShopItem(ShopItemDetails item)
        {
            Item = item;
            Quantity = 1;
        }
    }
}