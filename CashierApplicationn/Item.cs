using System;

namespace ItemNamespace
{
    abstract class Item
    {
        protected string item_name;
        protected double item_price;

        public Item(string name, double price)
        {
            item_name = name;
            item_price = price;
        }

        public abstract double getTotalPrice(int quantity);
    }
}