using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Travel_Trip_Project.Models.Classes;

namespace Travel_Trip_Project.Controllers
{
    public class BlogController : Controller
    {
        // GET: Blog
        Context c = new Context();
        blogComment bc = new blogComment();
        public ActionResult Index()
        {
            bc.value1 = c.blogs.OrderByDescending(x=>x.date).ToList();
            bc.value3=c.blogs.OrderByDescending(x=>x.date).Take(3).ToList();

            return View(bc);
        }

        public ActionResult BlogDetails(int id)
        {
            bc.value1 = c.blogs.Where(x => x.id == id).ToList();
            bc.value2 = c.comments.Where(y => y.blogId == id).ToList();

            return View(bc);
        }
    }
}