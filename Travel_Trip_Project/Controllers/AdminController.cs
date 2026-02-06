using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Travel_Trip_Project.Models.Classes;

namespace Travel_Trip_Project.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        Context c = new Context();
        [Authorize]
        public ActionResult Index()
        {
            var values = c.blogs.ToList();

            return View(values);
        }

        [HttpGet]
        public ActionResult NewBlog()
        {
            return View();
        }

        [HttpPost]
        public ActionResult NewBlog(blog p)
        {
            c.blogs.Add(p);
            c.SaveChanges();

            return RedirectToAction("Index");
        }

        public ActionResult DeleteBlog(int id)
        {
            var b = c.blogs.Find(id);
            c.blogs.Remove(b);
            c.SaveChanges();

            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult UpdateBlog(int id)
        {
            var b = c.blogs.Find(id);

            return View("UpdateBlog", b);
        }

        [HttpPost]
        public ActionResult UpdateBlog(blog p)
        {
            var b = c.blogs.Find(p.id);
            b.title = p.title;
            b.description = p.description;
            b.blogImage = p.blogImage;
            b.date = p.date;
            c.SaveChanges();

            return RedirectToAction("Index");
        }

        public ActionResult CommentList()
        {
            var comments = c.comments.ToList();

            return View(comments);
        }

        public ActionResult DeleteComment(int id)
        {
            var comment = c.comments.Find(id);
            c.comments.Remove(comment);
            c.SaveChanges();

            return RedirectToAction("CommentList");
        }

        [HttpGet]
        public ActionResult UpdateComment(int id)
        {
            var comment = c.comments.Find(id);

            return View("UpdateComment", comment);
        }

        [HttpPost]
        public ActionResult UpdateComment(comments p)
        {
            var comment = c.comments.Find(p.id);
            comment.user = p.user;
            comment.mail = p.mail;
            comment.comment = p.comment;
            c.SaveChanges();

            return RedirectToAction("CommentList");
        }
    }
}