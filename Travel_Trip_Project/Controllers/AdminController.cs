using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI;
using Travel_Trip_Project.Models.Classes;

namespace Travel_Trip_Project.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        Context c = new Context();
        [Authorize]
        [Authorize]
        public ActionResult Index(int page = 1)
        {
            int pageSize = 10;

            var values = c.blogs
                          .OrderByDescending(x => x.id)
                          .Skip((page - 1) * pageSize)
                          .Take(pageSize)
                          .ToList();

            int totalRecords = c.blogs.Count();
            int totalPages = (int)Math.Ceiling((double)totalRecords / pageSize);

            ViewBag.CurrentPage = page;
            ViewBag.TotalPages = totalPages;

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

        public ActionResult CommentList(int page=1)
        {
           int pageSize = 10;

            var values = c.comments
                          .OrderByDescending(x => x.id)
                          .Skip((page - 1) * pageSize)
                          .Take(pageSize)
                          .ToList();

            int totalRecords = c.comments.Count();
            int totalPages = (int)Math.Ceiling((double)totalRecords / pageSize);

            ViewBag.CurrentPage = page;
            ViewBag.TotalPages = totalPages;

            return View(values);
        }

        public ActionResult DeleteComment(int id)
        {
            var comment = c.comments.Find(id);
            c.comments.Remove(comment);
            c.SaveChanges();

            return RedirectToAction("CommentList");
        }

        public ActionResult CommentDetails(int id)
        {
            var comment = c.comments.Find(id);

            return View("CommentDetails", comment);
        }

        public ActionResult Messages(int page=1)
        {
            int pageSize = 10;

            var values = c.contacts
                          .OrderBy(x => x.id)
                          .Skip((page - 1) * pageSize)
                          .Take(pageSize)
                          .ToList();

            int totalRecords = c.contacts.Count();
            int totalPages = (int)Math.Ceiling((double)totalRecords / pageSize);

            ViewBag.CurrentPage = page;
            ViewBag.TotalPages = totalPages;

            return View(values);
        }

        public ActionResult MessageDetails(int id)
        {
            var contact = c.contacts.Find(id);

            return View(contact);
        }

        public ActionResult DeleteMessage(int id)
        {
            var contact = c.contacts.Find(id);
            c.contacts.Remove(contact);
            c.SaveChanges();

            return RedirectToAction("Messages");
        }

        public ActionResult UpdateAbout()
        {
            var about = c.abouts.FirstOrDefault();

            return View(about);
        }

        [HttpPost]
        public ActionResult UpdateAbout(about about)
        {
            var value = c.abouts.Find(about.id);
            value.photoURL = about.photoURL;
            value.description = about.description;
            c.SaveChanges();
            TempData["Success"] = "Başarıyla kaydedildi.";

            return View();
        }
    }
}