using carpooling;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace memeber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<member> list1 = new List<member>();

            for (int i = 0; i < 2; i++)

            {

                Console.WriteLine("enter the details:");

                long id = int.Parse(Console.ReadLine());

                string firstname = Console.ReadLine();

                string lastname = Console.ReadLine();

                string email = Console.ReadLine();

                string contactnumber = Console.ReadLine();

                string licensenumber = Console.ReadLine();

                DateTime licensestart = DateTime.Parse(Console.ReadLine());

                DateTime licenseend = DateTime.Parse(Console.ReadLine());

                member member = new member(id, firstname, lastname, email, contactnumber, licensenumber, licensestart, licenseend);

                list1.Add(member);

            }

            foreach (member member in list1)

            {

                Console.WriteLine(member.ToString());

            }

            if (list1[0].Equals(list1[1]))

            {

                Console.WriteLine("both member same");

            }

            else

            {

                Console.WriteLine("different");

            }

        }

    }

}
       
