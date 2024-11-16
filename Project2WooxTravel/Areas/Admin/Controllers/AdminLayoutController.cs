using Project2WooxTravel.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Project2WooxTravel.Entities;
using Project2WooxTravel.Context;
using System.Data.Entity;
using Project2WooxTravel.ViewModel;
using System.Web.Security;

namespace Project2WooxTravel.Areas.Admin.Controllers
{
    public class AdminLayoutController : Controller
    {
        TravelContext Context = new TravelContext();
        public ActionResult Index()
        {
            return View();
        }

        public PartialViewResult PartialHead()
        {
            return PartialView();
        }
        public PartialViewResult PartialSidebar()
        {
            return PartialView();
        }
        public PartialViewResult PartialNavbar()
        {
            var a = Session["x"];
            var email = Context.admins.Where(x => x.UserName == a).Select(y => y.Email).FirstOrDefault();
            var messages = Context.Messages.Where(x => x.ReceiverMail == email).Take(5).ToList();
            var destinations = Context.Destinations.OrderByDescending(d => d.DestinationId).Take(4).ToList();
            var adminInfo = Context.admins.FirstOrDefault(x => x.UserName == a);
            var viewModel = new MessageDestinationViewModel
            {
                Messages = messages,
                Destinations = destinations,
                AdminInfo = adminInfo


            };




            return PartialView(viewModel);

        }
        public PartialViewResult PartialFooter()
        {
            return PartialView();
        }
        public PartialViewResult PartialScript()
        {
            return PartialView();
        }

        
    }
}