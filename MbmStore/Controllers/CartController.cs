using MbmStore.Infrastructure;
using MbmStore.Models;
using MbmStore.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MbmStore.Controllers
{
    public class CartController : Controller
    {
      
        public RedirectToRouteResult AddToCart(Cart cart, int productId, string returnUrl, int quantity)
        {
            Product product = Repository.Products.FirstOrDefault(p => p.ProductId == productId);
            if (product != null)
            {
                cart.AddItem(product, quantity); //adding 1 product
            }

            return RedirectToAction("Index", new { controller = returnUrl.Substring(1) });
        }




        public RedirectToRouteResult RemoveFromCart(Cart cart, int productId, string returnUrl)
        {
            Product product = Repository.Products
                .FirstOrDefault(p => p.ProductId == productId);
            if (product != null)
            {
                cart.RemoveItem(product);
            }
            return RedirectToAction("Index", new { returnUrl });
        }
        private Cart GetCart()
        {
            Cart cart = (Cart)Session["Cart"];
            
            if (cart == null)
            {
                cart = new Cart();
                Session["Cart"] = cart;
            }
            return cart;
        }

        public ViewResult Index(Cart cart,string returnUrl)
        {
            return View(new CartIndexViewModel
            {
                Cart = GetCart(),
                ReturnUrl = returnUrl
            });
        }
    }
}