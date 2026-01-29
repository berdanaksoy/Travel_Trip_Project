using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Travel_Trip_Project.Models.Classes
{
    public class addressBlog
    {
        [Key]
        public int id { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public string address_full { get; set; }
        public string mail { get; set; }
        public string phone_number { get; set; }
        public string location { get; set; }
    }
}