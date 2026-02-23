using PagedList;
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
        public ActionResult Index(int page=1)
        {
            bc.value1 = c.blogs.OrderByDescending(x => x.date).ToPagedList(page, 3);
            bc.value2 = c.comments.OrderByDescending(x => x.date).Take(3).ToList();
            bc.value3 = c.blogs.OrderByDescending(x => x.date).Take(3).ToList();

            return View(bc);
        }

        public ActionResult BlogDetails(int id)
        {
            bc.value1 = c.blogs.Where(x => x.id == id).OrderByDescending(x=>x.id).ToPagedList(1, 3);
            bc.value2 = c.comments.Where(y => y.blogId == id).OrderByDescending(x => x.date).ToList();
            bc.value3 = c.blogs.OrderByDescending(x => x.date).Take(3).ToList();
            bc.value4 = c.comments.OrderByDescending(x => x.date).Take(3).ToList();

            return View(bc);
        }

        [HttpGet]
        public PartialViewResult AddComment(int id)
        {
            ViewBag.blogId = id;

            return PartialView();
        }

        [HttpPost]
        public ActionResult SendComment(comments co)
        {
            co.date = DateTime.Now;
            c.comments.Add(co);
            c.SaveChanges();

            return RedirectToAction("BlogDetails", new { id = co.blogId });
        }
    }
}