﻿using MbmStore.Infrastructure;
using MbmStore.ViewModels;
using System.Linq;
using System.Web.Mvc;

namespace MbmStore.Controllers
{
    public class CatalogueController : Controller
    {
        public int PageSize = 4;
        // GET: Catalogue
        public ActionResult Index(string category, int page = 1)
        {
            ProductsListViewModel model = new ProductsListViewModel
            {
                Products = Repository.Products
                .Where(p => category == null || p.Category.ToLower() == category.ToLower())
                .OrderBy(p => p.ProductId)
                .Skip((page - 1) * PageSize)
                .Take(PageSize),

                PagingInfo = new PagingInfo
                {
                    CurrentPage = page,
                    ItemsPerPage = PageSize,
                    TotalItems = category == null ?
                    Repository.Products.Count() :
                    Repository.Products.Where(e => e.Category ==category).Count()
                },
            CurrentCategory = category
            };

            return View(model);
        }
    }
}