using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example2_IF_statment
{
    internal class Numeric_formatting
    {
        static void Main(string[] args)
        {
            double value = 1000D / 12.34;

            Console.WriteLine(value);
            Console.WriteLine(string.Format("{0:0.00}", value, 1000));


            double money = 10 / 3; //3.33333333s

            Console.WriteLine(money);
            Console.WriteLine(string.Format("-$10 / $3 = $-{0:0.00}", money));
            Console.WriteLine(money.ToString("C"));


            Console.WriteLine(money.ToString("C", CultureInfo.CurrentCulture));
            Console.WriteLine(money.ToString("C", CultureInfo.CreateSpecificCulture("en-GB")));
            Console.WriteLine(money.ToString("C", CultureInfo.CreateSpecificCulture("en-US")));
            Console.ReadLine();
        }
    }
}
