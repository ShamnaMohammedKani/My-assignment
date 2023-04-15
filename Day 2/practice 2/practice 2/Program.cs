using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Write a C# Sharp program to convert from celsius degrees to Kelvin and Fahrenheit.
kelvin = celsius + 273
fahrenheit = celsius x 18 / 10 + 3*/

namespace practice_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

            Console.WriteLine("enter the degree in celsius : ");
            double celsius = double.Parse(Console.ReadLine());

            Console.WriteLine("kelvin is {0}",+ (celsius + 273));
            Console.WriteLine("fahrenheit is{0}", +(celsius * 18 / 10 + 3));


        }
    }
}
