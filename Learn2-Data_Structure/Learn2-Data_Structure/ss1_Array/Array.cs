using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn2_Data_Structure
{
    internal class Array
    {
        static void Main(string[] args)
        {
            //int num1 = 5;
            //int num2 = 10;
            //int num3 = 15;
            //int num4 = 20;

            //int[] numbers = new int[10];

            ///*Console.Write("Enter a number: ");
            //numbers[0] = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Enter a number: ");
            //numbers[1] = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Enter a number: ");
            //numbers[2] = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Enter a number: ");
            //numbers[3] = Convert.ToInt32(Console.ReadLine());*/

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine("Enter a number: ");
            //    numbers[i] = Convert.ToInt32(Console.ReadLine());
            //}

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.Write($"{numbers[i]}");
            //}

            //foreach (var num in numbers)
            //{
            //    Console.WriteLine($"{num}");
            //}

            const int angleCount = 3;
            int[] angles = new int[angleCount];


            for (int i = 0; i < angles.Length; i++)
            {
                Console.Write($"Enter angles {i + 1}: ");
                angles[i] = Convert.ToInt32(Console.ReadLine());
            }

            int angleSum = 0;

            foreach (int item in angles)
            {
                angleSum += item;
            }
            
            Console.WriteLine(angleSum == 180 ? "Valid" : "Invalid!");
            //Console.WriteLine($"{numbers[0]} {numbers[1]} {numbers[2]}");

            Console.ReadLine();
        }
    }
}
