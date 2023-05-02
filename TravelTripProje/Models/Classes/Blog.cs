using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TravelTripProje.Models.Classes
{
    public class Blog
    {
        [Key]
        public int ID { get; set; }
        public string Title { get; set; }
        public DateTime Date { get; set; }
        public string Description { get; set; }
        public string BlogImageUrl { get; set; }
        public ICollection<Comments> Commentss { get; set; }
    }
}