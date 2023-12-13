using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("\t**Ejercicio 5: Herencia**");

            EstudianteGraduado graduado1 = new EstudianteGraduado();

            Console.Write("Ingrese el nombre del estudiante graduado:");
            graduado1.Nombre = Console.ReadLine();

            Console.Write("Ingrese la edad del estudiante graduado:");
            graduado1.Edad = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ingrese la calificación del estudiante graduado:");
            graduado1.Calificacion = Convert.ToDouble(Console.ReadLine());

            Console.Write("Ingrese el título obtenido por el estudiante graduado:");
            graduado1.Titulo = Console.ReadLine();

            Console.WriteLine("\nInformación del Estudiante Graduado:");
            graduado1.MostrarInformacion();
            Console.WriteLine($"Título obtenido: {graduado1.Titulo}");

            Console.ReadKey();
        }
    }
}
