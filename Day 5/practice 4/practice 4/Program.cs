using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i,j;
            Console.WriteLine("Display pattern");
            for (i= 0; i <6; i++)
            {
                for (j = 0; j <=i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();

            }
            

        }
    }
}
