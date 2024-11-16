using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Project2WooxTravel.Context;
using Project2WooxTravel.Entities;

namespace Project2WooxTravel.Areas.Admin.Controllers
{
    [Authorize]
    public class ProfileController : Controller
    {
        TravelContext context = new TravelContext();
        public ActionResult Index()
        {
            var a = Session["x"];
            var values = context.admins.Where(x => x.UserName == a).FirstOrDefault();
            return View(values);
        }
    }
}