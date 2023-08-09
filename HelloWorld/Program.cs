using System;
using System.Runtime.CompilerServices;

namespace HelloWorld
{
    //PascalCase
    public class Program
    {
        public static void Main(string[] args)
        {
            //camelClass
            string firstAndLastName  = "Michał";

            //UPPER_CASE
            const double PI_NUMBER = 3.14;
            Console.WriteLine("Hello World");
            Console.WriteLine("Nazywam się Michał Kamiński");
            if (PI_NUMBER > 2)
            {
                WritePiNumber(PI_NUMBER);
            }
        }

        private static string WritePiNumber(double pi)
        {
            return ("3.14");
        }
    }
}

 