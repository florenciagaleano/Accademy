using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using WebSiteProductos.Repository;
using WebSiteProductos.Models;

namespace WebSiteProductos.Controllers
{
    public class SubCategoryController : Controller
    {

        public ActionResult Index()
        {
            var subCategorias = AdminSubCategory.Traertodos();

            return View(subCategorias);
        }

        public ActionResult Detalle(int id)
        {
            var subCategoria = AdminSubCategory.TraerPorId(id);

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
            Subcategory subCategoria = new Subcategory();
            return View("Create", subCategoria);
        }

        //Post
        [HttpPost]
        public ActionResult Create(Subcategory subCategoria)
        {
            if (ModelState.IsValid)
            {
                AdminSubCategory.Agregar(subCategoria);

                return RedirectToAction("Index");
            }
            else
            {
                return View("Create", subCategoria);

            }
        }


        public ActionResult Delete(int id)
        {
            Subcategory subCategory = AdminSubCategory.TraerPorId(id);
            if (subCategory != null)
            {
                AdminSubCategory.Eliminar(subCategory);
                return RedirectToAction("Index");
            }
            return View(subCategory);
        }

    }
}