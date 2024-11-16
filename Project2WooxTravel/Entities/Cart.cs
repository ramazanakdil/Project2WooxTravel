using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project2WooxTravel.Entities
{
    public class Cart
    {
        public int CartId { get; set; }
        public string User { get; set; }
        public string CartNumber { get; set; }
        public string NameSurname { get; set; }
        public string ExpDate { get; set; }
        public int Ccv { get; set; }
    }
}