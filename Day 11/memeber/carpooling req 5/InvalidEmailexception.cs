using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace carpooling_req_5
{
    class Invalid_exception : Exception
    {
        string email;

        public Invalid_exception()

        {

        }
        public Invalid_exception(string email)
        {
            this.email = email;
        }
        public void inform()
        {
            Console.WriteLine("invalid email id for user");
        }

    }
}
