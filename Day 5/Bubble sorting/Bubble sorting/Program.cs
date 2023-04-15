using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bubble_sorting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i, j;

            int[] arr = new int[5];
            Console.WriteLine("Enter the array elemnet: ");
            for (i=0; i<arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            for(i=0;i<arr.Length-1;i++)
            {
                for(j=0;j<arr.Length - 1;j++)
                {
                    if (arr[j] > arr[j+1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j+1];
                        arr[j+1] = temp;
                    }
                }
            }
            for(i=0;i<arr.Length;i++)
            {
                Console.WriteLine("{0} ", arr[i]);
            }
        }
    }
}
