using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EssentialsCSharp.Models
{
    public class Product
    {
        public string Name { get; set; }
        public decimal? Price { get; set; }
        public Product RelatedProduct { get; set; }
        public static Product[] GetProducts()
        {
            Product kayak = new Product
            {
                Name = "Kayak",
                Price = 275M
            };
            Product lifejacket = new Product
            {
                Name = "Lifejacket",
                Price = 48.95M
            };
            Product jacket = new Product
            {
                Name = "jacket",
                Price = null,
                RelatedProduct = kayak
            };


            return new Product[] { kayak, lifejacket, jacket, null };
        }
    }
}
