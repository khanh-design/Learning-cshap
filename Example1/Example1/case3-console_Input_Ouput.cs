using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example1
{
    internal class case3_console_Input_Ouput
    {
        static void Main(String[] args)
        {
            //Console.WriteLine("Hello my name is Aba!");

            Console.Write("Enter your name:");
            string name = Console.ReadLine();
            //Console.WriteLine(name);

            Console.Write("Enter your age: ");
            string ageInput = Console.ReadLine();
            int age = Convert.ToInt32(ageInput);
            //Console.WriteLine(age);

            //Console.Write("your name is ");
            //Console.WriteLine(name);
            //Console.Write(" add your name is ");
            //Console.WriteLine(age);

            Console.WriteLine();
            Console.WriteLine("Your name is " + name + " and your age is " + age);
            Console.ReadLine(); // Dung de doc du lieu tu nguoi dung
        }
    }
}
