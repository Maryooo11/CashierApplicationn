using System;

namespace ItemNamespace
{
    class DiscountedItem : Item
    {
        private double item_discount;

        public DiscountedItem(string name, double price, double discount)
            : base(name, price)
        {
            item_discount = discount * 0.01;
        }

        public override double getTotalPrice(int quantity)
        {
            double discountedPrice =
                item_price - (item_price * item_discount);

            return discountedPrice * quantity;
        }
    }
}