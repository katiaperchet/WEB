using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebActividades.Models
{
	public class Actividad
	{
		public string Area { get; set; }
		public string Institucion { get; set; }
		public string Titulo { get; set; }
		public string Creador { get; set; }
		public decimal Duracion { get; set; }
		public string Materiales { get; set; }
		public string Resumen { get; set; }
		public string Descripcion { get; set; }
		public string Pautas { get; set; }
		public string Naps { get; set; }
	}
}
