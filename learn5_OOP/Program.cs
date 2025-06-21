using System;
using System.Text;
using System.Xml.Linq;

namespace learn5_OOP
{
    public class Program
    {
        private struct Person
        {
            public string name;
            public int age;
            public int birthMonth;
            public int number;

            // Make the constructor public to fix the accessibility issue
            public Person(string _name, int _age, int _birthMonth, int _number)
            {
                this.name = _name;
                this.age = _age;
                this.birthMonth = _birthMonth;
                this.number = _number;
            }
        }
        static void Main(string[] args)
        {
            /*string name = "Aba";
            int age = 23;
            int birthMonth = 5;

            Person person;

            person.name = "Aba";
            person.age = 23;
            person.birthMonth = 5;

            Console.WriteLine($"{name} - {age}");
            Console.WriteLine($"{person.name} - {person.age} - {person.birthMonth}");

            string newName = "";
            int newAge = 0;
            ReturnPerson(ref newName, ref newAge, ref birthMonth);
            Console.WriteLine($"{person.name} - {person.age} - {person.birthMonth}");*/

            Person p = ReturnPerson();

            Console.WriteLine($"{p.name} - {p.age} - {p.birthMonth}"); 

            Console.ReadLine();
        }

        static Person ReturnPerson()
        {
            Console.WriteLine("Enter your name: ");
            string name = Console.ReadLine();


            Console.WriteLine("Enter your age: ");
            int age = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("Enter your birhMonth: ");
            int birhMonth = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter your number: ");
            int number = Convert.ToInt32(Console.ReadLine());

            /*Person ps = new Person();
            ps.name = name;
            ps.age = age;
            ps.birthMonth = birhMonth;
            ps.number = number;*/

            return new Person(name, age, birhMonth, number);

        }
        /*static void ReturnPerson(ref string name, ref int age, ref int birhMonth)
        {
            Console.WriteLine("Enter your name: ");
            name = Console.ReadLine();


            Console.WriteLine("Enter your age: ");
            age = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("Enter your birhMonth: ");
            birhMonth = Convert.ToInt32(Console.ReadLine());

        }*/
    }
}
