using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t**Ejercicio 1: Variables y Operador en C#**");
            Console.WriteLine("Ejercicio con Datos Quemados");
            // Parte con datos quemados
            int numero1 = 24;
            int numero2 = 14;

            int resultado = numero1 + numero2;
            Console.WriteLine(numero1 + " + " + numero2);
            Console.WriteLine("El resultado de la suma con datos quemados es: " + resultado);

            Console.WriteLine("\nEjercicio con Ingreso de Datos");
            // Solicitar al usuario ingresar valores
            Console.Write("Por favor, ingrese el primer número: ");
            int userInput1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Por favor, ingrese el segundo número: ");
            int userInput2 = Convert.ToInt32(Console.ReadLine());

            int userResult = userInput1 + userInput2;

            Console.WriteLine("El resultado de la suma con los números ingresados es: " + userResult);

            Console.ReadKey(); // Detener la consola para visualizar el resultado
        }
    }
}
