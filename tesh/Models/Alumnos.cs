using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace tesh.Models
{
    public class Alumnos
    { 
        public int id { get; set; }
        public string NombreAlumno { get; set; }
        public string ApellidoAlumno { get; set; }
        public int    Calificacion { get; set; }
        public DateTime FechaNacimientoAlumno { get; set; }
    }
}
