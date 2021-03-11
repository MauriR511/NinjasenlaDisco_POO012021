using System;

namespace PrimerPrograma
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            //declarando variables
            int a = 0, b = 0;

            //Pidiendo el valor para "a"
            Console.WriteLine("Enter a value for a:");
            a = Int32.Parse(Console.ReadLine());

            //Pidiendo el valor para "b"
            Console.WriteLine("Enter a value for b:");
            b = Int32.Parse(Console.ReadLine());

            //Mostrando la suma y la respuesta
            Console.WriteLine($"Adding {a} + {b} equals {AddNumbers(a, b)} ");
        }

        //Funcion que realiza la suma
        public static int AddNumbers(int a, int b)
        {
            return a + b;
        }
    }
}