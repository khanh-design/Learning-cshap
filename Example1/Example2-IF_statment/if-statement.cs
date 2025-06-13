using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example2_IF_statment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Console.WriteLine("Enter your name: ");
            string name = Console.ReadLine();

            Console.WriteLine("Enter your age: ");
            string ageInput = Console.ReadLine();
            int age = Convert.ToInt32(ageInput);

            Console.WriteLine();
            Console.WriteLine("Your name is " + name + " add your age is " + age);

            // == > >= < <= != || &&

            if (age < 0 || age > 150)
            {
                Console.WriteLine("Invalid age!");
            }
            else 
            {
                if (age >= 18 && age <= 25) // 18 > 18
                {
                    Console.WriteLine("you are between 18 and 25");
                }
                else if (age >= 26)
                {
                    Console.WriteLine("you are 26 or older");
                }
            }*/

            Console.WriteLine("Enter thhe first number: ");
            string numberAInput = Console.ReadLine();
            int numberA = Convert.ToInt32(numberAInput);

            Console.WriteLine("Enter the second number: ");
            string numberBInput = Console.ReadLine();
            int numberB = Convert.ToInt32(numberBInput);

            int answer = numberA * numberB;

            Console.WriteLine("Value of " + numberA + " x " + numberB + ": ");
            string answerAInput = Console.ReadLine();
            int actualAnswer = Convert.ToInt32(answerAInput);

            if (answer == actualAnswer)
            {
                Console.WriteLine("Well done!");
            }
            else if (answer != actualAnswer)
            {
                Console.WriteLine("Close but it was wrong");
            }

            Console.ReadLine();
        }
    }
}
