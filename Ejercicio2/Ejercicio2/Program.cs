using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t**Ejercicio 2: Estructuras de Control**");
            // Edad quemada para verificar si es mayor o no
            int edadQuemada = 14;
            Console.WriteLine("Ejercicio con dato quemado: 14");
            // Verificar si la edad quemada es mayor o no a 18
            if (edadQuemada >= 18)
            {
                Console.WriteLine("La edad designada cumple con ser mayor de edad.");
            }
            else
            {
                Console.WriteLine("La edad designada no es mayor de edad.");
            }

            Console.WriteLine("\nEjercicio con ingreso de Dato");
            // Pedir al usuario que ingrese su edad
            Console.Write("Ingrese su edad: ");
            int edadUsuario;

            // Validar la entrada del usuario
            while (!int.TryParse(Console.ReadLine(), out edadUsuario))
            {
                Console.WriteLine("Por favor, ingrese un número válido para la edad:");
            }

            // Verificar si la edad ingresada por el usuario es mayor o no a 18
            if (edadUsuario >= 18)
            {
                Console.WriteLine("Usted es mayor de edad.");
            }
            else
            {
                Console.WriteLine("Usted NO es mayor de edad.");
            }

            Console.ReadKey(); // Detener la consola para visualizar el resultado
        }
    }
}
