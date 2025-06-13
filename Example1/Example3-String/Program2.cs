using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example3_String
{
    internal class Program2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Password: ");
            string password = Console.ReadLine();

            Console.WriteLine("Enter password again: ");
            string passwordC = Console.ReadLine();

            if (password.Equals(string.Empty))
            {
                if (!passwordC.Equals(string.Empty))
                {
                    if (password.Length >= 6 && passwordC.Length >= 6)
                    {
                        if (password.Equals(passwordC))
                        {
                            Console.WriteLine("password macth");
                        }
                        else
                        {
                            Console.WriteLine("Password do not match");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Please enter 6 or more characters!");
                    }
                }
                else
                {
                    Console.WriteLine("Please enter a password confirmation");
                }
            }
            else
            {
                Console.WriteLine("please enter a password.");
            }
        }
    }
}
