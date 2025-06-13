using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example2_IF_statment
{
    internal class for_statement
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hi");
            //Console.WriteLine("Hi");
            //Console.WriteLine("Hi");
            //Console.WriteLine("Hi");
            //Console.WriteLine("Hi");

            Console.WriteLine("What do you want to repeat?: ");
            string message = Console.ReadLine();
            Console.WriteLine("And how many times do you want yo repeat it?: ");
            int loopCounter = Convert.ToInt32(Console.ReadLine());

            if (loopCounter <= 0)
            {
                Console.WriteLine("Sorry, please enter a value above 0");
            }
            else
            {
                for (int i = 0; i < loopCounter; i++) // lap qua index
                {
                    Console.WriteLine("Hi");
                }
            }

            /*for (int i = 1; i <= 10; i+= 2)
            {
                Console.WriteLine(i);
            }*/


            Console.ReadLine();
        }
    }
}
