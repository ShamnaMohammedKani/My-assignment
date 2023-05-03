using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace carpooling_req4
{
    internal class abstract_class
    {
        public abstract class Car

        {

            long _id;

            string _name;

            public long Id

            {

                get { return _id; }

                set { _id = value; }

            }

            public string Name

            {

                get { return _name; }

                set { _name = value; }

            }

            public Car() { }

            public Car(long _id, string _name)

            {

                Id = _id;

                Name = _name;

            }

            public abstract double CalculateDriveCost

            {

                get;

            }
        }
    }
}
