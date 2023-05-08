using ENTITY;
using System;

using System.Collections.Generic;

using System.Linq;

using System.Text;

using System.Threading.Tasks;

namespace EFDemo1

{

    internal class Program

    {

        static void Main(string[] args)

        {

            ENTEntities e1 = new ENTEntities();

            foreach (var item in e1.Dpts)

            {

                Console.WriteLine(item.DeptName);

            }

            /*  using (var context = new ENTEntities())

              {

                  var dept = new Dpt()

                  {

                      DeptID = 110,

                      DeptName = "IT"

                  };

                  context.Dpts.Add(dept);

                  context.SaveChanges();

              }*/
            using (var context = new ENTEntities())

            {

                var dept = context.Dpts.First<Dpt>();

                dept.DeptName = "kulam";

                context.SaveChanges();

            }



        }

    }

}
