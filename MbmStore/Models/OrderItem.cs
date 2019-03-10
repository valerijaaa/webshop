using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MbmStore.Models
{
    public class OrderItem
    {
        //properties
        public int OrderItemId { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public decimal TotalPrice { get { return TotalPrice; } }
        public int Quantity { get; set; }


        //constructors

        public OrderItem(Product product, int quantity) 
        {
            this.Product = product;
            this.Quantity = quantity;
        }



    }
}