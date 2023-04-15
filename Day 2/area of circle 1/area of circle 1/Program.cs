using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace area_of_circle_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int radius;
            double area;
            Console.WriteLine("Enter the radius of the circle: ");
            radius = int.Parse(Console.ReadLine());
            area = Math.PI * radius*radius;
            Console.WriteLine("Area of the circle is: " +area);
        }
    }
}
