using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example3_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your message: ");
            string message = Console.ReadLine();

            Console.WriteLine(message[0]);
            Console.WriteLine(message.Length);

            for (int i = 0; i <= message.Length; i++)
            {
                Console.WriteLine(message[i]);
            }

            for (int i = message.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(message[i]);
            }

            Console.WriteLine();
        }
    }
}
