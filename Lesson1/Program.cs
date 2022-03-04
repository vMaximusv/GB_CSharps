using System;

namespace Lesson1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Давай познакомимся! Напиши мне свое имя?");
            string name = Console.ReadLine();
            Console.WriteLine($"Привет, " + name + ". Сегодня: " + DateTime.Today.ToShortDateString());
            Console.ReadKey();
        }
    }
}
