using SistemaWebAlumnos.Datos;
using SistemaWebAlumnos.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SistemaWebAlumnos.Controllers
{
    public class AlumnoController : Controller
    {
        DBContextEstudiantes context = new DBContextEstudiantes();
        // GET: Alumno
        public ActionResult Index()
        {
            var alumnos = context.Alumnos.ToList();
            return View(alumnos);
        }

        public ActionResult Create()
        {
            Alumno alumno = new Alumno();
            return View("Create", alumno);
        }

        [HttpPost]
        public ActionResult Create(Alumno alumno)
        {
            if (ModelState.IsValid)
            {
                context.Alumnos.Add(alumno);
                context.SaveChanges();
                return RedirectToAction("Index");
            }

            return View("Create", alumno);
        }

        public ActionResult Detail(int id)
        {
            var alumno = context.Alumnos.Find(id);

            if (alumno != null)
            {
                return View("Detail", alumno);
            }

            return HttpNotFound();
        }

        public ActionResult Delete(int id)
        {
            var alumno = context.Alumnos.Find(id);

            if (alumno != null)
            {
                return View(alumno);
            }
            else
            {
                return HttpNotFound();
            }

        }

        [HttpPost]
        public ActionResult Delete(Alumno alumno)
        {
            context.Alumnos.Attach(alumno);
            context.Alumnos.Remove(alumno);
            context.SaveChanges();

            return RedirectToAction("Index");

        }

        public ActionResult TraerPorNombre(string nombre)
        {
            var alumnos = (from a in context.Alumnos where a.Nombre == nombre select a).ToList();
            return View("Index",alumnos);
        }

    }
}