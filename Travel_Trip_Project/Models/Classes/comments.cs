using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Travel_Trip_Project.Models.Classes
{
    public class comments
    {
        [Key]
        public int id { get; set; }
        public string user { get; set; }
        public string mail { get; set; }
        public string comment { get; set; }
        public int blogId { get; set; }
        public virtual blog Blog { get; set; }
        public DateTime date { get; set; }
    }
}