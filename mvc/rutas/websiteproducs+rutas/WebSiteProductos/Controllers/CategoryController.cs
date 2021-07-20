using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using WebSiteProductos.Repository;
using WebSiteProductos.Models;

namespace WebSiteProductos.Controllers
{
    public class CategoryController : Controller
    {
        public ActionResult Index()
        {
            var categorias = AdminCategory.Traertodos();

            return View(categorias);
        }

        public ActionResult Detalle(int id)
        {
            var categoria = AdminCategory.TraerPorId(id);

            if (categoria != null)
            {
                return View("Detalle", categoria);
            }
            else
            {
                return HttpNotFound();
            }
        }

        //GET
        public ActionResult Create()
        {
            Category categoria = new Category();
            return View("Create", categoria);
        }

        //Post
        [HttpPost]
        public ActionResult Create(Category categoria)
        {
            if (ModelState.IsValid)
            {
                AdminCategory.Agregar(categoria);
                 
                return RedirectToAction("Index");
            }
            else
            {
                return View("Create", categoria);

            }
        }


        public ActionResult Delete(int id)
        {
            Category category = AdminCategory.TraerPorId(id);
            if (category != null)
            {
                AdminCategory.Eliminar(category);
                return RedirectToAction("Index");
            }
            return View(category);
        }


    }
}