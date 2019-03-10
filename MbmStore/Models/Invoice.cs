using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MbmStore.Models
{
    public class Invoice
    {
        //fields
        private List<OrderItem> orderItems;
        decimal totalPrice;

        //properties
        public int InvoiceId { get; set; }
        public DateTime OrderDate { get; set; }
        public decimal TotalPrice { get { return totalPrice; }}
        public List<OrderItem> OrderItems { get { return orderItems; } }
        public Customer Customer { get; set; }



        //constructors
        public Invoice(int invoiceId, DateTime orderDate, Customer customer)
        {
            this.InvoiceId = invoiceId;
            this.OrderDate = orderDate;
            this.Customer = customer;
            this.orderItems = new List<OrderItem>();
        }

        public void AddOrderItem(Product product, int quantity) 
        {
            orderItems.Add(new OrderItem(product, quantity));
            totalPrice = orderItems.Sum(o => o.Product.Price * o.Quantity);
        }
    }
}