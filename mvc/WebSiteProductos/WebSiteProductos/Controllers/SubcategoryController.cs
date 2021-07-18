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
    public class SubcategoryController : Controller
    {
            ProductoDbContext context = new ProductoDbContext();
            // GET: Subcategory
            public ActionResult Index()
            {
                var subcategorias = AdminSubcategory.TraerTodos();

                return View(subcategorias);
            }
            public ActionResult Detalle(int id)
            {
                var subCategoria = AdminSubcategory.TraerPorId(id);

                if (subCategoria != null)
                {
                    return View("Detalle", subCategoria);
                }
                else
                {
                    return HttpNotFound();
                }
            }


        //GET
        public ActionResult Create()
            {
                Subcategory subcategoria = new Subcategory();
                return View("CrearSubcategory", subcategoria);
            }

            //Post
            [HttpPost]
            public ActionResult Create(Subcategory subcategoria)
            {
                if (ModelState.IsValid)
                {
                    context.Subcategories.Add(subcategoria);
                    context.SaveChanges();
                    return RedirectToAction("Index");
                }
                else
                {
                    return View("CrearSubcategory", subcategoria);

                }
            }

            public ActionResult Delete(int id)
            {
                Subcategory category = AdminSubcategory.TraerPorId(id);

                if (category != null)
                {
                    AdminSubcategory.Eliminar(category);
                    return RedirectToAction("Index");
                }

                return View();
            }
        }
}