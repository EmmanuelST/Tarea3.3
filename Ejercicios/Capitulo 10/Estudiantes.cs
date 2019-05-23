using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios.Capitulo_10
{
    class Estudiantes
    {
        public string Nombre { get; set; }
        public string Matricula { get; set; }
        public int Grado { get; set; }
        public DateTime FechaIngreso { get; set; }
        public string NombreTutor { get; set; }
        public string Direccion { get; set; }
        public string TelefonoTutor { get; set; }

        public Estudiantes()
        {
            Nombre = string.Empty;
            Matricula = string.Empty;
            Grado = 1;
            FechaIngreso = DateTime.Now;
            NombreTutor = string.Empty;
            Direccion = string.Empty;
        }
    }
}
