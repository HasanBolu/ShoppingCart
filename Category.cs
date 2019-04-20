using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingCart
{
    class Category
    {
        public Category(string title)
        {
            this.Id = new Random().Next();
            this.Title = title;
            this.ParentId = 0;
        }

        public int Id { get; set; }

        public string Title { get; set; }

        public int ParentId { get; set; }
    }
}
