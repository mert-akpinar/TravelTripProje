using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TravelTripProje.Models.Classes
{
    public class ContactMe
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Adress {get; set; }
        public string Mail { get; set; }
        public string Phone { get; set; }
        public string Location { get; set; }
    }
}