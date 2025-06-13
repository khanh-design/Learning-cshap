using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example1
{
    internal class case2
    {
        static void Main(string[] args)
        {
            int num1 = 1;
            int num2 = 2;

            int remaider = num1 % num2;

            num1 = 11;
            remaider = num1 % num2;
            Console.WriteLine(remaider);
            Console.ReadLine();


        }
    }
}
