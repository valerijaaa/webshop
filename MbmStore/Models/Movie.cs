using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MbmStore.Models
{
    public class Movie : Product
    {
   
        // properties
        //auto-implemented property. Used when no additional logic is required in the property accessors.
        public string Director { get; set; }
        public short Released { get; set; }



        // constructors
        public Movie(int productId, string title, decimal price)
            : base(productId, title, price, null)
        {
            this.ProductId = ProductId;
            this.Title = title;
            this.Price = price;
   
        }
        public Movie(int productId,string title, decimal price, string imageUrl, string director, short released) 
            : base(productId, title, price, imageUrl) 
        {
            this.ProductId = productId;
            this.Director = director;
            this.Released = released;
        }
    }
}