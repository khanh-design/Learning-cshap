using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example2_IF_statment
{
    internal class Condition_operator
    {
        static void Main(string[] args)
        {
            int age = -10;

            /*if (age >= 0)
            {
                Console.WriteLine("valid");

            }
            else
            {
                Console.WriteLine("Invalid");
            }*/

            //condition ? true : false

            string result = age >= 0 ? "Valid" : "Invalid";
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
