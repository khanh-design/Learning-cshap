using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example2_IF_statment
{
    internal class TryParse_function
    {
        static void Main(string[] args) 
        {
            Console.WriteLine("Enter a number: ");
            string numInput = Console.ReadLine();
            int num = Convert.ToInt32(numInput);

            Console.WriteLine(num);

            Console.ReadLine();
        }
    }
}
