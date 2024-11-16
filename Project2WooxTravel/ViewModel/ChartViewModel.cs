using Project2WooxTravel.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project2WooxTravel.ViewModel
{
    public class ChartViewModel
    {
        public List<string> DestinationTitles { get; set; }
        public List<int> DestinationCapacities { get; set; }
        public List<decimal> DestinationPrices { get; set; }
        public int AdminCount { get; set; }
    }
}