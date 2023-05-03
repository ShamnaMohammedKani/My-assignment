using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @finally
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int b = 2;
            int[] a = new int[5];
            try
            {
                b=int.Parse(Console.ReadLine());
                int i = 18 / b;
                a[18] = 9;
            }
            catch (DivideByZeroException e)

            {
                Console.WriteLine("divide by zero error");

            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine("index out of range");
            }
            finally
            {
                Console.WriteLine("finallly");
            }


        }

        private static void parse(string v)
        {
            throw new NotImplementedException();
        }
    }
}
