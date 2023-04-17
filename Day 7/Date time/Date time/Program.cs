using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Date_time
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime currentDateTime = DateTime.Now;
            DateTime todaysDate = DateTime.Today;
            DateTime currentDateTimeUTC = DateTime.UtcNow;

            DateTime maxDateTimeValue = DateTime.MaxValue;
            DateTime minDateTimeValue = DateTime.MinValue;

            Console.WriteLine($"Current DateTime {currentDateTime}");
            Console.WriteLine($"Today's DateTime {todaysDate}");
            Console.WriteLine($"Current DateTime UTC Timezone {currentDateTimeUTC}");
            Console.WriteLine($"Max DateTime Value {maxDateTimeValue}");
            Console.WriteLine($"Min DateTime Value {minDateTimeValue}");

        }
    }
}
