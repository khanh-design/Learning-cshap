using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn2_Data_Structure.Exercise
{
    internal class Odd_Even_number_split
    {
        /*
         * Tao ra 2 danh sach kieu integer, 1 cai chua so chan, 1 cais chua so le
         * lap tu 0 -20 
            * neu so la chan thi them vao danh sach chan
            * neu so la le thi them vao danh sach le
         * Print ra danh sach chan 
         * Print ra danh sach le
         */
        static void Main(string[] args)
        {
            List<int> odd = new List<int>();
            List<int> even = new List<int>();

            for (int i = 0; i < 20; i++)
            {
                if (i % 2 == 0)
                {
                    even.Add(i);
                }
                else
                {
                    odd.Add(i);
                }
            }

            foreach (var item in even)
            {
                Console.WriteLine($"{item}");
            }

            Console.WriteLine("Printing even numbers: ");

            foreach (var item in odd)
            {
                Console.WriteLine($"{item}");
            }

            Console.WriteLine(Environment.NewLine + "Printing odd number: ");

            Console.ReadLine();
        }
    }
}
