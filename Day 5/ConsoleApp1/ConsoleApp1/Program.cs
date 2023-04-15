using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int ch;
            Account a = null;
            do
            {
                Console.WriteLine("Menu");
                Console.WriteLine("1.create account");
                Console.WriteLine("2.Displayinfo");
                Console.WriteLine("3.withdraw");
                Console.WriteLine("0.QUIT");
                Console.WriteLine("Enter choice");
                ch = int.Parse(Console.ReadLine());
                switch(ch)

                {
                    case 1:
                        Console.WriteLine("Enter the account id");
                        int Id=int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter name");
                        string Name=Console.ReadLine();
                        Console.WriteLine("Enter opeening balance");
                        double Balance=double.Parse(Console.ReadLine());
                        a = new Account();
                        a.createaccount(Id,Name, Balance);

                        break;

                        case 2:
                          
                }
            }
           

          
           

            while (ch != 0);
        }
    }
}
