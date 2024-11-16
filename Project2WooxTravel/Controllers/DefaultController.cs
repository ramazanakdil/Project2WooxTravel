using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PagedList;
using Project2WooxTravel.Context;
using Project2WooxTravel.Entities;
using PagedList;
using PagedList.Mvc;

namespace Project2WooxTravel.Controllers
{
    public class DefaultController : Controller
    {
        TravelContext context = new TravelContext();
        public ActionResult Index()
        {
            return View();
        }

        public PartialViewResult PartialHead()
        {
            return PartialView();
        }
        public PartialViewResult PartialScript()
        {
            return PartialView();
        }
        public PartialViewResult PartialNavbar()
        {
            return PartialView();
        }
        public PartialViewResult PartialBanner()
        {
            var last4 = context.Destinations.OrderByDescending(x => x.DestinationId).Take(4).ToList();
            return PartialView(last4);
        }
        public PartialViewResult PartialCountry(int sayfa = 1)
        {

            var values = context.Destinations.ToList().ToPagedList(sayfa, 3);
            return PartialView(values);
        }
        public PartialViewResult PartialFooter()
        {
            return PartialView();
        }

        public ActionResult DestinationDetail(int id)
        {
            var destination = context.Destinations.Find(id);

            return View(destination);
        }

        public PartialViewResult ReservationPopup()
        {
            return PartialView();
        }

        [HttpPost]

        public PartialViewResult ReservationPopup(Reservation reservation)
        {
            context.Reservations.Add(reservation);
            context.SaveChanges();
            return PartialView("Index");
        }
    }
}