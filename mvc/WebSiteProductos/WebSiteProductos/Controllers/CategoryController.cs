using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebSiteProductos.Data;
using WebSiteProductos.Models;
using WebSiteProductos.Respository;

namespace WebSiteProductos.Controllers
{
    public class CategoryController : Controller
    {
        ProductoDbContext context = new ProductoDbContext();
        // GET: Category
        public ActionResult Index()
        {
            
            var categorias = AdminCategory.TraerTodos();

            return View(context.Categories.ToList());
        }
        public ActionResult Detalle(int id)
        {
            var categoria = context.Categories.Find(id);

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
                context.Categories.Add(categoria);
                context.SaveChanges();
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

            if(category != null)
            {
                AdminCategory.Eliminar(category);
                return RedirectToAction("Index");
            }

            return View();
        }

    }
}