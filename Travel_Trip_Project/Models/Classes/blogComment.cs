using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Travel_Trip_Project.Models.Classes;

namespace Travel_Trip_Project.Models.Classes
{
    public class blogComment
    {
        public IEnumerable<blog> value1 { get; set; }
        public IEnumerable<comments> value2 { get; set; }
        public IEnumerable<blog> value3 { get; set; }
    }
}