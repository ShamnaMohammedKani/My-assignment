using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
       public delegate int Add(int i,int j);
        static void Main(string[] args)
        {

            int result;
            Add a = delegate (int b, int c)
            {
                return b + c;
            };
            result = a(10, 20); 
            Console.WriteLine(result);
          
        }
    }
}
