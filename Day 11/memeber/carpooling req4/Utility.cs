using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static carpooling_req4.abstract_class;

namespace carpooling_req4
{
    internal class Utility
    {
        public class UtilityCar : Car

        {

            bool _rearCoolingVents;

            public bool RearCoolingVents

            {

                get { return _rearCoolingVents; }

                set { _rearCoolingVents = value; }

            }

            public UtilityCar() { }

            public UtilityCar(bool rearCoolingVents, int id, string name) : base(id, name)

            {

                RearCoolingVents = rearCoolingVents;

            }
        }
    }
}
