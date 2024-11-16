using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project2WooxTravel.ViewModel
{
    public class StatisticsViewModel
    {
        public int TotalUser { get; set; }
        public int TotalReservations { get; set; }
        public int TotalMessages { get; set; }
        public int DestinationsCount { get; set; }
    }
}