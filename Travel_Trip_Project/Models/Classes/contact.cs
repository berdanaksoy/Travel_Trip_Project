using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Travel_Trip_Project.Models.Classes
{
    public class contact
    {
        [Key]
        public int id { get; set; }
        public string fullname { get; set; }
        public string mail { get; set; }
        public string phone_number { get; set; }
        public string message { get; set; }
    }
}