using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingCart
{
    class Coupon
    {
        public Coupon(double minShoppingAmount, double discountAmount, DiscountType discountType)
        {
            this.MinShoppingAmount = minShoppingAmount;
            this.DiscountAmount = discountAmount;
            this.DiscountType = discountType;
        }

        public double MinShoppingAmount { get; set; }

        public double DiscountAmount { get; set; }

        public DiscountType DiscountType { get; set; }

    }
}
