using System;

namespace PrimerPrograma
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            // Declarando variables
            int a = 0, b = 0;

            // Definición del procedimiento
            Console.WriteLine("***MULTIPLICATION***");

            // Ingresando valor para a
            Console.WriteLine("Enter a value for a:");
            a = Int32.Parse(Console.ReadLine());

            // Ingresando valor para b 
            Console.WriteLine("Enter a value for b:");
            b = Int32.Parse(Console.ReadLine());

            // Mostrando la multiplicacion 
            Console.WriteLine($"Multiplying {a} * {b} equals {MultiplyingNumbers(a, b)} ");
        }

        // Función de multiplicar
        public static int MultiplyingNumbers(int a, int b)
        {
            return a * b;
        }
    }
}