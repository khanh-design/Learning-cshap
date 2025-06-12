using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn2_Data_Structure
{
    internal class session3_indexOf
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[]
            {
                90, 199, 22, 50, 33
            };

            Console.WriteLine("Enter number to search: ");
            int search = Convert.ToInt32(Console.ReadLine());

            //int position = Array.IndexOf(numbers, search);
            //int position = Array.IndexOf(numbers, search, 2);
            int position = System.Array.IndexOf(numbers, search, 1, 2);

            if (position > -1)
            {
                Console.WriteLine($"Number {search} has been found at position {position}");
            }
            else
            {
                Console.WriteLine($"Number {search} has been not found");
            }

            //int position = -1;

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] == search)
            //    {
            //        position = i;
            //    }
            //}
            //if (position > -1)
            //{
            //    Console.WriteLine($"Number {search} has been found at position {position}");
            //}
            //else
            //{
            //    Console.WriteLine($"Number {search} has been not found");
            //}

            Console.ReadLine();
        }
    }
}
