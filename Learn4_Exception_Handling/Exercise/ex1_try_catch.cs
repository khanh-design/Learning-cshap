using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn4_Exception_Handling.Exercise
{
    internal class ex1_try_catch
    {
        /*
         * Create a int and try convert any string to a int
         * Notice the error, write a try...catch handler around it
         * Catch the error and output the error message
         * Without changing the current code
         * 
         * Why is this a bad situation and how can we know can we know if its been converted?
         * 
         * Create a custom try parse function
         * Find the real function and copy return type/params
         * Read the tooltip it gives you, to givve you ideas on what to do.
         */

        static void Main(string[] args)
        {
            /*bool success = false;

            try
            {
                Console.WriteLine("Enter a number: ");
                int num = Convert.ToInt32(Console.ReadLine());
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
            }

            Console.WriteLine(success ? "Yep" : "Oh no");*/

            Console.WriteLine("Enter a number: ");
            if (TryParse(Console.ReadLine(), out int result))
            {
                Console.WriteLine("Yep" + result);
            }

            Console.ReadLine();
        }

        static bool TryParse(string input, out int result)
        {
            result = -1;

            try
            {
                result = Convert.ToInt32(input);
                return true;
            } 
            ////catch (FormatException)
            //{
            //    return false;
            //}
            catch (Exception e)
            {
                 return false;
            }

        }
    }
}
