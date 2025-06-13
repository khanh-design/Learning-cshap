using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Khai bao bien va gan gia tri
            //int age = 23;
            var age = 23; // Tu dong nhan dien kieu du lieu
            Console.WriteLine(age);

            var bigNumber = 1000000;
            Console.WriteLine(bigNumber);

            double negative = -55.2D;
            Console.WriteLine(negative);

            float precision = 5.0000001F;
            Console.WriteLine(precision);

            decimal money = 14.99M; // Su dung M de chi ro kieu decimal
            Console.WriteLine(money);


            int firstNum = 10;
            int secondNum = 3;

            Console.WriteLine(firstNum % secondNum);
            Console.WriteLine();

            var name = "Abc";
            Console.WriteLine(name);

            var letter = 'A'; // Ky tu
            Console.WriteLine(letter);

            // const keyword
            //const la tu khoa de khai bao bien co gia tri khong thay doi
            const int vat = 20; 
            const double percentVAT = vat / 100D; 
            int balance = 1000;

            Console.WriteLine(balance * (vat / 100));
            Console.WriteLine(balance * percentVAT);

            const string version = "v1.0";

            Console.WriteLine(20);

            Console.ReadLine();
        }
    }
}
