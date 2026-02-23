using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Travel_Trip_Project.Models.Classes
{
    public class Context:DbContext
    {
        public DbSet<admin> admins { get; set; }
        public DbSet<blog> blogs { get; set; }
        public DbSet<about> abouts { get; set; }
        public DbSet<contact> contacts { get; set; }
        public DbSet<comments> comments { get; set; }
    }
}