using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace learn3_Function
{
    class Test
    {
        public static void something() 
        {
            Console.WriteLine("Aba something");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Test.something();

            WelcomeMessage();

            Console.ReadLine();
        }

        static void WelcomeMessage()
        {
            Console.WriteLine("Welcome Aba");
        }
    }
}
