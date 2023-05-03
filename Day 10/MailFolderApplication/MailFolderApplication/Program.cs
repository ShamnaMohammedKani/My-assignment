using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MailFolderApplication
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the name of folde\nInbox");
            bool the = true;

            do
            {
                Console.WriteLine("1.Add Mail\n2.delete mail\n3.Display Mail\n4.Exit\nEnter tour choice");
                int ans=int.Parse(Console.ReadLine());

                switch (ans)
                {
                    case 1: Console.WriteLine("enter the details of mail in CVs format");
                        string s = Console.ReadLine();
                        Mail ms = new Mail(s);
                        Console.WriteLine("Mail Succecsfully added");ht6
                }
            }
        }
    }
}
