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
        public Movie(int productId, string title, decimal price, string category)
            : base(productId, title, price, null, category)
        {
   
        }

        public Movie(int productId,string title, decimal price, string imageUrl, string director, short released, string category) 
            : base(productId, title, price, imageUrl, category) 
        {
            this.Director = director;
            this.Released = released;
        }
    }
}