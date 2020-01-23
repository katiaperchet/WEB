using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebActividades.Models;

namespace WebActividades.Controllers
{
    public class ActividadController : Controller
    {
		List<Actividad> actividades = new List<Actividad>();
		// GET: Actividad
		public ActionResult Index()
        {			
			Actividad actividad1 = new Actividad();
			actividad1.Area = "Educación";
			actividad1.Creador = "Juan Pérez";
			actividad1.Descripcion = "Inserción de la robótica en el Aula";
			actividad1.Duracion = "60 hrs";
			actividad1.Institucion = "Escuela Industrial Nro 6 de Rio Gallegos";
			actividad1.Materiales = "Kit de robótica básico";
			actividad1.Pautas = "Uso de los robots";
			actividad1.Resumen = "Utilizar robots";
			actividad1.Titulo = "Insertar robots";
			actividad1.Naps = "idk";
			Actividad actividad2 = new Actividad();
			actividad2.Area = "Educación";
			actividad2.Creador = "Juan Pérez";
			actividad2.Descripcion = "Inserción de la robótica en el Aula";
			actividad2.Duracion = "60 hrs";
			actividad2.Institucion = "Escuela Municipal Dr Juan B Justo de Córdoba";
			actividad2.Materiales = "Kit de robótica básico";
			actividad2.Pautas = "Uso de los robots";
			actividad2.Resumen = "Utilizar robots";
			actividad2.Titulo = "Insertar robots";
			actividad2.Naps = "idk";
			actividades.Add(actividad1);
			actividades.Add(actividad2);
			return View(actividades);
		}

        // GET: Actividad/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Actividad/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Actividad/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Actividad/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Actividad/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Actividad/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Actividad/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}