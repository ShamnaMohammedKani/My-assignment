using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;

// Write a C# Sharp program that takes four numbers as input to calculate and print the average//

namespace practice_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double num1, num2,num3,num4;
            Console.WriteLine("Enter the first num:");
            num1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Enetr the second num:");
            num2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter the third num:");
            num3 = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter the fourth num:");
            num4 = double.Parse(Console.ReadLine());

            double sum= (num1 +num2+num3 +num4);
            Console.WriteLine("The sum is : " + sum);

            double average = (num1 +num2+num3+num4)/4;
            Console.WriteLine("the avarage is : " + average);

        }
    }
}
