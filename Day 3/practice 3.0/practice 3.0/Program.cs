using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace practice_3._0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n, diff;
            const int x = 51;
            Console.WriteLine("Enter the value of n: ");
            n=int.Parse(Console.ReadLine());
            diff = diffC(n, x);
            Console.WriteLine(diff);
        }
               static int diffC(int n, int x) 
        {
            int diff;
            diff = n - x;
            if (n > x) 
            {
                return (n-x)*3;
            }
           
                return (x - n);
            
        }
    }
}
