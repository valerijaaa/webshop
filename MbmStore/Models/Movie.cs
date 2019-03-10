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
        public Movie(string title, decimal price)
            : base(title, price, null)
        {
            this.Title = title;
            this.Price = price;
   
        }
        public Movie(string title, decimal price, string imageUrl, string director, short released) 
            : base(title, price, imageUrl) 
        {
            this.Director = director;
            this.Released = released;
        }
    }
}