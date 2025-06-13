using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example2_IF_statment.Exercise
{
    internal class Exercise_Times_Table
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i <= 10; i++) //0-9 1-10
            {
                Console.WriteLine("{0} x {1} = {2}", i, number, i * number);
            }

            Console.ReadLine();
        }
    }
}
