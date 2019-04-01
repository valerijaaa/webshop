using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MbmStore.Models
{
    public class Book : Product
    {
        //properties
        public string Author { get; set; }
        public string Publisher { get; set; }
        public short Published { get; set; }
        public string ISBN { get; set; }

        //constructors
        public Book () : base()
        {
        }

        public Book (int productId, string author, string title, decimal price, short published, string publisher, string isbn, string imageUrl, string category)
            : base(productId, title, price, imageUrl, category)
        {
            ProductId = ProductId;
            Publisher = publisher;
            Author = author;
            Published = published;
            ISBN = isbn;
        }
    }
}