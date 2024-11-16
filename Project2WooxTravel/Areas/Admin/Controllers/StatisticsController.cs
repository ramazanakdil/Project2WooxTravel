using Project2WooxTravel.Context;
using Project2WooxTravel.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Project2WooxTravel.Areas.Admin.Controllers
{
    [Authorize]
    public class StatisticsController : Controller
    {
        TravelContext context = new TravelContext();
        public ActionResult StatisticsList()
        {
            var model = new StatisticsViewModel
            {
                TotalUser = context.admins.Count(),
                TotalReservations = context.Reservations.Count(),
                TotalMessages = context.Messages.Count(),
                DestinationsCount = context.Destinations.Count()
            };
            return View(model);
        }

        public ActionResult Chart()
        {
            int adminCount = context.admins.Count();

            // Destinasyon başlıkları, kapasiteleri ve fiyatları
            var destinationTitles = context.Destinations.Select(d => d.Title).ToList();
            var destinationCapacities = context.Destinations.Select(d => d.Capacity).ToList();
            var destinationPrices = context.Destinations.Select(d => d.Price).ToList();

            // ViewData veya ViewBag ile verileri view'e gönderme
            ViewBag.AdminCount = adminCount;
            ViewBag.DestinationTitles = destinationTitles;
            ViewBag.DestinationCapacities = destinationCapacities;
            ViewBag.DestinationPrices = destinationPrices;

            return View();
        }
    }
}