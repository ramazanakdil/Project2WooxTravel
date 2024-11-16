using Project2WooxTravel.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project2WooxTravel.ViewModel
{
    public class MessageDestinationViewModel
    {
        public List<Message> Messages { get; set; }
        public List<Destination> Destinations { get; set; }
        public Admin AdminInfo { get; set; }
    }
}