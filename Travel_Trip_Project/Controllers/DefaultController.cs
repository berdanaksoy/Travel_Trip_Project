using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Travel_Trip_Project.Models.Classes;

namespace Travel_Trip_Project.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        Context c = new Context();
        public ActionResult Index()
        {
            var values = c.blogs.Take(5).ToList();

            return View(values);
        }

        public ActionResult About()
        {
            return View();
        }

        public ActionResult Contact()
        {
            return View();
        }

        public PartialViewResult Partial1()
        {
            var values = c.blogs.OrderByDescending(x => x.date).Take(2).ToList();

            return PartialView(values);
        }

        public PartialViewResult Partial2()
        {
            var values = c.blogs.OrderByDescending(x => x.date).Skip(2).Take(1).ToList();

            return PartialView(values);
        }

        public PartialViewResult Partial3()
        {
            var oneMonthAgo = DateTime.Now.AddMonths(-1);

            var values = c.blogs
                .Where(x => x.date >= oneMonthAgo)
                .Select(x => new
                {
                    Blog = x,
                    CommentCount = x.Comments.Count()
                })
                .OrderByDescending(x => x.CommentCount)
                .Take(10)
                .Select(x => x.Blog)
                .ToList();

            return PartialView(values);
        }

        public PartialViewResult Partial4()
        {
            var values = c.blogs
                .Select(x => new { Blog = x, CommentCount = x.Comments.Count })
                .OrderByDescending(x => x.CommentCount)
                .Take(3)
                .Select(x => x.Blog)
                .ToList();

            return PartialView(values);
        }

        public PartialViewResult Partial5()
        {
            var values = c.blogs
                .Select(x => new { Blog = x, CommentCount = x.Comments.Count })
                .OrderByDescending(x => x.CommentCount)
                .Skip(3)
                .Take(3)
                .Select(x => x.Blog)
                .ToList();

            return PartialView(values);
        }
    }
}