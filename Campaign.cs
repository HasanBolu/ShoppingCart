using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingCart
{
    class Campaign
    {
        public Campaign(Category category, double discountAmount, int productCount, DiscountType discountType)
        {
            this.Category = category;
            this.DiscountAmount = discountAmount;
            this.ProductCount = productCount;
            this.DiscountType = discountType;
        }

        public Category Category { get; set; }

        public double DiscountAmount { get; set; }

        public int ProductCount { get; set; }

        public DiscountType DiscountType { get; set; }
        
    }
}
