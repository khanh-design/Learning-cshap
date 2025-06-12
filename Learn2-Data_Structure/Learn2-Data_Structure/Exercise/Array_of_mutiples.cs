using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn2_Data_Structure.Exercise
{
    internal class Array_of_mutiples
    {
        /*
         * Xac dinh khoi tao 2 so nguyen (num, integer)
         * (7, 5) -> [7, 14, 21, 28, 35]
         * Tao mang kieu int voi kich thuoc do dai
         * lap qua mang va them no vao mang
         * in mang cuoi cung da them ra man hinh
         */
        static void Main(string[] args)
        {
            int num = 7;
            int Length = 5;

            int[] array = new int[Length];
            int count = 0;

            for (int i = 0; i < array.Length; i++)
            {
                array[count] = num * i;
                count++;
            }

            foreach (var item in array)
            {
                Console.WriteLine($"{item}");
            }

            Console.ReadLine();
        }
    }
}
