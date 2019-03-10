using MbmStore.Infrastructure;
using MbmStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MbmStore.Controllers
{
    public class CatalogueController : Controller
    {
        // GET: Catalogue
        public ActionResult Index()
        {

            ViewBag.Products = Repository.Products;


            return View();
        }
    }
}