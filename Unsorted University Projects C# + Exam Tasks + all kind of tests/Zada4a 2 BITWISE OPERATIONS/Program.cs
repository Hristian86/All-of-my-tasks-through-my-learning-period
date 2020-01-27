    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Globalization;

    namespace Zada4a_2_BITWISE_OPERATIONS
    {
        class Program
        {
            static void Main(string[] args)
            {
                string dateAsText = Console.ReadLine();
            
                var date = DateTime.ParseExact(dateAsText,"d-m-yyyy", CultureInfo.InvariantCulture);
                Console.WriteLine(date.DayOfWeek);

            }
        }
    }
