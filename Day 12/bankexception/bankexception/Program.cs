﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bankexception
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try

            {

                c.withdraw(450);

            }

      catch(bankexception e)

            {

                Console.WriteLine("Transaction Failed ");

                e.inform();

            }

        }
    }

}


        