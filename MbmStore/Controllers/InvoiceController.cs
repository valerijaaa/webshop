using MbmStore.Infrastructure;
using MbmStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MbmStore.Controllers
{
    public class InvoiceController : Controller
    {
        private List<SelectListItem> ListOfCustomers;
        // GET: Invoice
        public ActionResult Index()
        {
           
          

            ViewBag.CustomerId = ListOfCustomers;
            ViewBag.Invoices = Repository.Invoices;
            return View();
        }

    [HttpPost]
    public ActionResult Index(int? CustomerId)
        {
            ViewBag.CustomerId = ListOfCustomers;
            if (CustomerId != null)
            {
                ViewBag.Invoices = Repository.Invoices
                    .Where(invoice => invoice.Customer.CustomerId == CustomerId);
            }
            return View();
        }


        public InvoiceController()
        {
            //declaring the list
            List<SelectListItem> customers = new List<SelectListItem>();

            //generating the dropdown list
            foreach (Invoice invoice in Repository.Invoices)
            {
                customers.Add(new SelectListItem
                {
                    Text = invoice.Customer.Firstname + " " + invoice.Customer.Lastname,
                    Value = invoice.Customer.CustomerId.ToString()
                });
            }

            //removing duplicate entries with same ID from a IEnumerable
            customers = customers
                .GroupBy(customer => customer.Value)
                .Select(customer => customer.First())
                .OrderBy(customer => customer.Text)
                .ToList<SelectListItem>();

            ListOfCustomers = customers;
        }
    
    }




}