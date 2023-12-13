using System;

namespace Ejercicio5
{
    // Clase base Estudiante
    public class Estudiante
    {
        // Propiedades de la clase Estudiante
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public double Calificacion { get; set; }

        // Método para mostrar información del estudiante
        public void MostrarInformacion()
        {
            Console.WriteLine($"Nombre: {Nombre}");
            Console.WriteLine($"Edad: {Edad} años");
            Console.WriteLine($"Calificación: {Calificacion}");
        }
    }
}
