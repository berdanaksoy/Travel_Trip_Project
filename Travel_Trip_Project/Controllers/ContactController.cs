using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Travel_Trip_Project.Models.Classes;

namespace Travel_Trip_Project.Controllers
{
    public class ContactController : Controller
    {
        // GET: Contact
        private readonly Context _context = new Context();
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult SendMessage(contact c)
        {
            _context.contacts.Add(c);
            _context.SaveChanges();
            TempData["Success"] = "Mesajınız başarıyla gönderildi.";

            return RedirectToAction("Index", "Contact");
        }
    }
}