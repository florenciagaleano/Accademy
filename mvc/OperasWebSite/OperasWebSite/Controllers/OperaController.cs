using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OperasWebSite.Data;
using OperasWebSite.Models;

namespace OperasWebSite.Controllers
{
    public class OperaController : Controller
    {
        
            //declara y crea una instancia de EF
            OperaDbContext context = new OperaDbContext();
            //GET: opera
            //GET /opera/Index
            public ActionResult Index()
            {
                var operas = context.Operas.ToList();
                return View(operas);
            }
        //Get
        public ActionResult Detail(int id)
        {
            var opera = context.Operas.Find(id);
            if (opera!=null)
            {
                return View("Detail", opera);
            }
            else
            {
                return HttpNotFound();
            }
        }
        //se puede invocar con GET /Opera/Create
        public ActionResult Create()
        {
            Opera opera = new Opera();
            return View("Create", opera);
        }
        //se decora con httpPOST, se  usa en la etiqueta form html --> /opera/create por post
        [HttpPost]
        public ActionResult Create(Opera opera)
        {
            if (ModelState.IsValid)
            {
                context.Operas.Add(opera);
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                return View("Create", opera);
            } 
        }

        
    }
}