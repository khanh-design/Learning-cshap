using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn2_Data_Structure
{
    internal class Dictionary
    {
        static void Main(string[] args)
        {
            /*Dictionary<int, string> names = new Dictionary<int, string>()
            {
                {1, "ABc" },
                {2, "Avc" },
                {3, "Khanh" }
            };

            for (int i = 0; i < names.Count; i++)
            {
                KeyValuePair<int, string> pair = names.ElementAt(i); // su dung cap khoa va gia tri de tim phan tu.
                Console.WriteLine($"{pair.Key} - {pair.Value}");
            }

            Console.WriteLine();

            foreach (KeyValuePair<int, string> item in names)
            {
                Console.WriteLine($"{item.Key} - {item.Value}");
            }*/

            Dictionary<string, string> teachers = new Dictionary<string, string>()
            {
                { "Match", "Abc" },
                { "Secience", "Test" }
            };

            //Console.WriteLine(teachers["Macth"]);

            if (teachers.TryGetValue("Match", out string teacher))
            {
                Console.WriteLine(teacher);

                teachers["Match"] = "Jone";
            }
            else
            {
                Console.WriteLine("Match teacher not found");
            }

            //teachers.Remove("Match");

            if (teachers.ContainsKey("Match"))
            {
                teachers.Remove("Match");
            }
            else
            {
                Console.WriteLine("Match not found");
            }

            foreach (var item in teachers)
            {
                Console.WriteLine($"{item.Key} - {item.Value}");
            }
            Console.ReadLine();
        }
    }
}
