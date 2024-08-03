using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn_App
{
    public class Product
    {
        public string Name { get; set; }
        public int Price { get; set; }
        public int Quantity { get; set; }

        public Product(string name, int price, int quantity = 1)
        {
            Name = name;
            Price = price;
            Quantity = quantity;
        }
    }

    public class Category
    {
        public string Name { get; set; }
        public List<Product> Products { get; set; }

        public Category(string name)
        {
            Name = name;
            Products = new List<Product>();
        }
    }
}
