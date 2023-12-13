using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3
{
    class Estudiante
    {
        // Propiedades de la clase Estudiante
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public double Calificacion { get; set; }
    }

    class Program
    {
        static void Main()
        {
            Console.WriteLine("\t**Ejercicio 3: Clases y Objetos**");
            Console.WriteLine("Ejercicio con Datos Quemados");
            // Crea un objeto de tipo Estudiante llamado estudiante1 con datos quemados
            Estudiante estudiante1 = new Estudiante
            {
                Nombre = "Ricardo Rivadeneira",
                Edad = 24,
                Calificacion = 18.5
            };

            // Imprime en la consola la información del estudiante con datos quemados
            Console.WriteLine("Información del Estudiante con datos quemados:");
            Console.WriteLine($"Nombre: {estudiante1.Nombre}");
            Console.WriteLine($"Edad: {estudiante1.Edad} años");
            Console.WriteLine($"Calificación: {estudiante1.Calificacion}");

            Console.WriteLine("\nEjercicio con Ingreso de Datos");
            // Solicita al usuario ingresar información del estudiante
            Console.Write("Ingrese el nombre del estudiante:");
            string nombre = Console.ReadLine();

            Console.Write("Ingrese la edad del estudiante:");
            int edad = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ingrese la calificación del estudiante:");
            double calificacion = Convert.ToDouble(Console.ReadLine());

            // Crea un nuevo objeto Estudiante con la información ingresada por el usuario
            Estudiante estudiante2 = new Estudiante
            {
                Nombre = nombre,
                Edad = edad,
                Calificacion = calificacion
            };

            // Imprime en la consola la información del estudiante ingresada por el usuario
            Console.WriteLine("\nInformación del Estudiante ingresada por el usuario:");
            Console.WriteLine($"Nombre: {estudiante2.Nombre}");
            Console.WriteLine($"Edad: {estudiante2.Edad} años");
            Console.WriteLine($"Calificación: {estudiante2.Calificacion}");

            Console.ReadKey();
        }
    }
}