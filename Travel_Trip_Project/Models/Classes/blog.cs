using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Travel_Trip_Project.Models.Classes
{
    public class blog
    {
        [Key]
        public int id { get; set; }
        public string title { get; set; }
        public DateTime date { get; set; }
        public string description { get; set; }
        public string blogImage { get; set; }
        public ICollection<comments> Comments { get; set; }
    }
}