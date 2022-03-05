using System;

namespace Lesson2_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //3. Определить, является ли введённое пользователем число чётным

            Console.WriteLine("Введите число для проверки четности");
            int k = Convert.ToInt32(Console.ReadLine());
            if (k % 2 == 0)
            {
                Console.WriteLine($"Введенное число {k}, оно является ЧЕТНЫМ.");
            }
            else
            {
                Console.WriteLine($"Введенное число {k}, оно является НЕЧЕТНЫМ.");
            }
            Console.ReadKey();
        }
    }
}
