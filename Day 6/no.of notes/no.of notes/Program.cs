using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace no.of_notes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the amount: ");
            int amt=int.Parse(Console.ReadLine());

            int[] notes = { 2000, 500, 200, 100, 50, 20, 10, 5, 2, 1 };
            

            
            {
                for(int i = 0; i < 10; i++)
                {
                    int n = amt / notes[i];
                    amt=amt% notes[i];
                    Console.WriteLine(n);
                }
            }
        }
    }
}
