using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Write a C# program to print the odd numbers from 1 to 99. Prints one number per line

namespace practice_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Odd number between 1 and 99 is: ");
            
            for( n=1;n<99;n++)

            {
                if (n % 2 != 0)
                {
                    Console.WriteLine(n);
                }

            }
            
        }
    }
}
