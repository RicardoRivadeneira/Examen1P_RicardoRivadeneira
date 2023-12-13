using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4
{
    public class Estudiante
    {
        // Propiedades de la clase Estudiante
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public string Carrera { get; set; }

        // Método para mostrar la información del estudiante
        public void MostrarInformacion()
        {
            Console.WriteLine("Detalles del estudiante:");
            Console.WriteLine("Nombre: " + Nombre);
            Console.WriteLine("Edad: " + Edad);
            Console.WriteLine("Carrera: " + Carrera);
        }
    }
}
