using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice_4._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[10];
            int i;
            Console.WriteLine("Input 10 elements in the array :\n");
            for (i = 0; i < 10; i++)
            {
                Console.WriteLine("element - {0} : ", i);
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("\nElements in array are: ");
            for (i = 0; i < 10; i++)
            {
                Console.WriteLine("{0}  ", arr[i]);
            }
            Console.WriteLine("\n");
        }
    }
}
