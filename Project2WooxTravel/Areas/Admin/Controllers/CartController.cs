using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Project2WooxTravel.Entities;
using Project2WooxTravel.Context;

namespace Project2WooxTravel.Areas.Admin.Controllers
{
    [Authorize]
    public class CartController : Controller
    {
        TravelContext context = new TravelContext();

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult CartList()
        {
            var a = Session["x"];
            var value = context.Carts.Where(x => x.User == a).ToList();

            return View(value);
        }
        public ActionResult UpdateCart(int id)
        {
            var value = context.Carts.Find(id);
            return View(value);
        }
        [HttpPost]
        public ActionResult UpdateCart(Cart cart)
        {
            var value = context.Carts.Find(cart.CartId);
            value.CartNumber = cart.CartNumber;
            value.Ccv = cart.Ccv;
            value.NameSurname = cart.NameSurname;
            value.ExpDate = cart.ExpDate;
            context.SaveChanges();
            return RedirectToAction("CartList", "Cart", "Admin");

        }
    }
}