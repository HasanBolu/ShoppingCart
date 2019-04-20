using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShoppingCart
{
    class DeliveryCostCalculator
    {
        public double CostPerDelivery { get; set; }

        public double CostPerProduct { get; set; }

        public double FixedDeliveryCost { get; set; }

        public DeliveryCostCalculator(double costPerDelivery, double costPerProduct, double fixedCost = 2.99)
        {
            this.CostPerDelivery = costPerDelivery;
            this.CostPerProduct = costPerDelivery;
            this.FixedDeliveryCost = fixedCost;
        }


        public double CalculateFor(Cart cart)
        {
            int categoryCount = cart.Basket.GroupBy(c => c.Product.Category.Title).Count();
            int productCount = cart.Basket.Count();

            return (categoryCount * CostPerDelivery) + (productCount * CostPerProduct) + this.FixedDeliveryCost;
        }
    }
}
