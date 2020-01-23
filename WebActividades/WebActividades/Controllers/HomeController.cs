using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebActividades.Models;

namespace WebActividades.Controllers
{
	public class HomeController : Controller
	{
		public IActionResult Index()
		{
			/*List<Actividad> actividades = new List<Actividad>();
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
			return View(actividades);*/
			return View();
		}

		public IActionResult About()
		{
			return View();
		}

		public IActionResult Contact()
		{
			ViewData["Message"] = "Your contact page.";

			return View();
		}

		public IActionResult Privacy()
		{
			return View();
		}

		[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
		public IActionResult Error()
		{
			return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
		}
	}
}
