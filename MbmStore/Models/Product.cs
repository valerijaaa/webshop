using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MbmStore.Models
{
    public abstract class Product
    {
        //properties
        public int ProductId { get; set; }
        public string Title { get; set; }
        public decimal Price { get; set; }
        public string ImageUrl { get; set; }

        //constructors
        public Product()
        {
        }

        public Product(string title, decimal price, string imageUrl)
        {
            Title = title;
            Price = price;
            ImageUrl = imageUrl;
        }
    }

   

}