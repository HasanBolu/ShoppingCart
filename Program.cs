using System;
using System.Collections.Generic;

namespace ShoppingCart
{
    class Program
    {
        static void Main(string[] args)
        {
            InitializeProgram();
            
        }

        public static void InitializeProgram()
        {
            var food = new Category("food");
            var technology = new Category("technology");
            var textile = new Category("textile");

            List<Category> categories = new List<Category>();
            categories.Add(food);
            categories.Add(technology);
            categories.Add(textile);

            List<Product> products = new List<Product>()
            {
                new Product("pc", 3000.00, technology),
                new Product("apple", 2.00, food),
                new Product("t-shirt", 40.00, textile),
            };

            List<Campaign> campaigns = new List<Campaign>()
            {
                new Campaign(food, 20.0, 3, DiscountType.Rate),
                new Campaign(food, 50.0, 5, DiscountType.Rate),
                new Campaign(food, 5.0, 5, DiscountType.Amount),
                new Campaign(technology, 20.0, 3, DiscountType.Rate),
                new Campaign(technology, 50.0, 5, DiscountType.Rate),
                new Campaign(technology, 5.0, 5, DiscountType.Amount),
            };

            List<Coupon> coupons = new List<Coupon>()
            {
                new Coupon(100.00, 10.00, DiscountType.Rate),
                new Coupon(800.00, 150.00, DiscountType.Amount)
            };
        }
        
    }
}
