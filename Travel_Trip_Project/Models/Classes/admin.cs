using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Travel_Trip_Project.Models.Classes
{
    public class admin
    {
        [Key]
        public int id { get; set; }
        public string user { get; set; }
        public string password { get; set; }
    }
}