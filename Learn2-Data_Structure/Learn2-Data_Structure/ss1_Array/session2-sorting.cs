using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn2_Data_Structure
{
    internal class session2_sorting
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[]
            {
                1, 2, 3, 4, 5, 6, 7, 8, 9
            };

            string test = "";
            test.Replace(" ", " ");

            System.Array.Sort(numbers); // sap xep tang dan

            System.Array.Reverse(numbers); // sap xep giam dan

            System.Array.Clear(numbers, 1, numbers.Length); // xoa mang 3 dau vao clear(mang, index, do dai mang)

            foreach (var item in numbers)
            {
                Console.WriteLine($"{item} ");
            }

            Console.ReadLine();
        }
    }
}
