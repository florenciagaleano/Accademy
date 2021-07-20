using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebSiteProductos.Repository;

namespace WebSiteProductos.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        public ActionResult Index()
        {
            var productos = AdminProduct.TraerTodos();

            return View(productos);
        }

        //GET
        //Product
        public ActionResult TraerPorColor(string color)
        {
            var productos = AdminProduct.TraerPorColor(color);

            return View("Index",productos);
        }
    }
}