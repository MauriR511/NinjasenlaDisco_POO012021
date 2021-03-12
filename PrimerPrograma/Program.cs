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
            Console.WriteLine("***SUBTRACTION***");

            // Ingresando valor para a
            Console.WriteLine("Enter a value for a:");
            a = Int32.Parse(Console.ReadLine());

            // Ingresando valor para b 
            Console.WriteLine("Enter a value for b:");
            b = Int32.Parse(Console.ReadLine());

            // Mostrando la resta
            Console.WriteLine($"Subtracting {a} - {b} equals {SubtractingNumbers(a, b)} ");
        }

        // Función de resta
        public static int SubtractingNumbers(int a, int b)
        {
            return a - b;
        }
    }
}