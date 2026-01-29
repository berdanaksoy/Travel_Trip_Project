using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Travel_Trip_Project.Models.Classes
{
    public class about
    {
        [Key]
        public int id { get; set; }
        public string photoURL { get; set; }
        public string description { get; set; }
    }
}