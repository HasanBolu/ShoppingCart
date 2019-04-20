using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingCart
{
    class Product
    {
        public Product(string name, double cost, Category category)
        {
            this.Name = name;
            this.Cost = cost;
            this.Category = category;
        }

        public string Name { get; set; }

        public double Cost { get; set; }

        public Category Category { get; set; }
    }
}
