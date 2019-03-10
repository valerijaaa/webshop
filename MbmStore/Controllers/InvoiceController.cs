using MbmStore.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MbmStore.Controllers
{
    public class InvoiceController : Controller
    {
        // GET: Invoice
        public ActionResult Index()
        {

            ViewBag.Invoices = Repository.Invoices;
            return View();
        }
    }
}