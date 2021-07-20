using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OperasWebSite.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Login(string user,string rol)
        {
            ViewBag.User = user;
            ViewBag.Role = rol;

            return View();
        }

        public ActionResult SearchByTitle(string title)
        {
            ViewBag.Title = title;

            return View();
        }
    }
}