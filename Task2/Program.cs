using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;
            int minNum = 5;
            int maxNum = 10;
            Console.Write("Ввидите число от 5 до 10: ");
            num = Convert.ToInt32(Console.ReadLine());

            if (num > minNum && num < maxNum)
            {
                Console.WriteLine($"Число {num} больше 5 и меньше 10.");
            }
            else if (num == minNum)
            {
                Console.WriteLine("Число 5 равняется 5.");
            }
            else if (num == maxNum)
            {
                Console.WriteLine("Число 10 равняется 10.");
            }
            else {
                Console.WriteLine("Неизвестное число");
                 }

            Console.ReadKey();
        }
    }
}
