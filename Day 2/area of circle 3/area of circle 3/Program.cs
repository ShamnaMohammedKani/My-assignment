﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace area_of_circle_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double r = 0.0 , Area;
            Console.WriteLine(" Enter the radius : "); 
            r=double.Parse(Console.ReadLine());
            Area = AreaC(r);
            Console.WriteLine("area of the circle having radius {0} is {1}",r,Area);
        }
        static double AreaC(double rr)
        {
            double Area = 0.0;
            Area = 3.14 * rr * rr;
            return Area;
        }
    }
}
