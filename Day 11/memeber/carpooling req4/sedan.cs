using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static carpooling_req4.abstract_class;

namespace carpooling_req4
{
    internal class sedan
    {
        class sedan : Car

        {

            bool _absEnabled;

            Int32 _bootSpace;

            public bool AbsEnabled

            {

                get { return _absEnabled; }

                set { _absEnabled = value; }

            }

            public Int32 BootSpace

            {

                get { return _bootSpace; }

                set { _bootSpace = value; }

            }

            public sedan() { }

            public sedan(bool absEnabled, int bootSpace, int id, string name) : base(id, name)

            {

                AbsEnabled = absEnabled;

                BootSpace = bootSpace;

            }
        }
    }
}
