using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static carpooling_req4.abstract_class;

namespace carpooling_req4
{
    internal class HatchBack
    {
        class HatchBack : Car

        {

            bool _powerWindowsEnabled;

            bool _automaticGear;

            public bool PowerWindowsEnabled

            {

                get { return _powerWindowsEnabled; }

                set { _powerWindowsEnabled = value; }

            }

            public bool AutomaticGear

            {

                get { return _automaticGear; }

                set { _automaticGear = value; }

            }

            public override double CalculateDriveCost => throw new NotImplementedException();

            public HatchBack() { }

            public HatchBack(bool powerWindowsEnabled, bool automaticGear, int id, string name) : base(id, name)

            {

                PowerWindowsEnabled = powerWindowsEnabled;

                AutomaticGear = automaticGear;

            }


        }
    }
}
