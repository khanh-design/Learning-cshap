using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example2_IF_statment
{
    internal class switch_statement
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a day of the week: ");
            int day = Convert.ToInt32(Console.ReadLine());

            /*if (day == 1)
            {
                Console.WriteLine("Mon");
            }
            else if (day == 2 || day == 3)
            {
                Console.WriteLine("Tue");
            }
            else
            {
                Console.WriteLine("Invalid, enter a value between 1 and 7");
            }*/
            
            switch (day)
            {
                case 1: Console.WriteLine("Mon");
                    break;
                case 2:
                    Console.WriteLine("Tue");
                    break;
                case 3:
                    Console.WriteLine("Web");
                    break;
                case 4:
                    Console.WriteLine("Thu");
                    break;
                case 5:
                    Console.WriteLine("Fri");
                    break;
                case 6:
                    Console.WriteLine("Sa");
                    break;
                case 7:
                    Console.WriteLine("Sun");
                    break;
                default:
                    Console.WriteLine("Invalid, enter a value between 1 and 7");
                    break;

            }
            Console.ReadLine();
        }
    }
}
