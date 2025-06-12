using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn2_Data_Structure
{
    internal class List
    {
        static void Main (string[] args)
        {
            int[] numbers = new int[]
            {
                1, 2, 3
            };

            List<int> listNumbers = new List<int>();

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine("Enter a numbers: ");
                listNumbers.Add(Convert.ToInt32(Console.ReadLine()));           
            }

            for (int i = 0; i < listNumbers.Count; i++)
            {
                Console.WriteLine(listNumbers[i]);
            }

            foreach (var item in listNumbers)
            {
                Console.WriteLine(item);
            }

            listNumbers.RemoveAt(0); // xoa tai 1 vi tri cu the

            Console.ReadLine();
        }
    }
}
