using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SistemaWebEmpleados.Datos;
using SistemaWebEmpleados.Models;

namespace SistemaWebEmpleados.Controllers
{
    public class EmpleadoController : Controller
    {
        private DbContextEmpleados context = new DbContextEmpleados();
        // GET: Empleado
        public ActionResult Index()
        {
            var empleados = context.Empleados.ToList();
            return View(empleados);
        }

        public ActionResult Detail(int id)
        {
            var empleado = context.Empleados.Find(id);
            if(empleado != null)
            {
                return View("Detail", empleado);
            }
            else
            {
                return HttpNotFound();
            }
        }

        public ActionResult Create()
        {
            Empleado empleado = new Empleado();
            return View("Create", empleado);
        }

        [HttpPost]
        public ActionResult Create(Empleado empleado)
        {
            if (ModelState.IsValid)
            {
                context.Empleados.Add(empleado);
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                return View("Create", empleado);
            }
        }

        public ActionResult Delete(int id)
        {
            Empleado empleado = context.Empleados.Find(id);
            if (empleado != null)
            {
                return View("Delete", empleado);
            }
            else
            {
                return HttpNotFound();
            }

        }

        [HttpPost]
        public ActionResult Delete(Empleado empleado)
        {
            if (empleado != null)
            {
                context.Entry(empleado).State = EntityState.Deleted;
                context.Empleados.Remove(empleado);
                context.SaveChanges();
            }
            return View(empleado);


        }
    }
}