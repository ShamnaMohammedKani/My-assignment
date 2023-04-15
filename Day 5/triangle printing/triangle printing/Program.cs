using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace triangle_printing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Enter the no.of rows: ");
            n=int.Parse(Console.ReadLine());
            for(int i = 0; i < n; i++)

            {
                for(int j = 0; j < n-i; j++)

                {
                    Console.Write(" ");

                }
                for(int k= 0; k < (2*i-1); k++)
                {
                    Console.Write("*");
                    
                }
                Console.WriteLine("\n");



            }
            
        }
       
    }
}
