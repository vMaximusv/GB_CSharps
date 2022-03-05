using System;

namespace Lesson2
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.Запросить у пользователя минимальную и максимальную температуру за сутки и вывести среднесуточную температуру

            Console.WriteLine("Введите минимальную температуру за сутки");
            int tempmin = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите максимальную температуру за сутки");
            int tempmax = Convert.ToInt32(Console.ReadLine());
            if (tempmax < tempmin)
            {
                Console.WriteLine("Минимальная температура не может быть больше максимальной");
            }
            else
            {
                int srtemp = ((tempmin + tempmax) / 2);
                Console.WriteLine($"Средняя температура за сутки: {srtemp}");
            }
            Console.ReadKey();
        }
    }
}
