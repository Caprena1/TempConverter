using System;

namespace TempConverter
{
    class Program
    {
        static void Main(string[] args)
        {
           var fToc = TempConverter.FahrenheitToCelsius(45);
           var cTof  = TempConverter.CelsiusToFahrenheit(0);
            Console.WriteLine(fToc);
            Console.WriteLine(cTof);

        }
    }
}
