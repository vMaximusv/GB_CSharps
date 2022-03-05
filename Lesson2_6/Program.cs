using System;

namespace Lesson2_6
{
    class Program
    {
        static void Main(string[] args)
        {
            //Закрепление битовых масок

            dayWeek daysshop1 = (dayWeek)0b_0011111;
            dayWeek daysshop2 = (dayWeek)0b_0111110;
            Console.WriteLine($"Расписание магазина \"Цветы и розы\":\n{daysshop1}\n");
            Console.WriteLine($"Расписание супермаркета \"Лента\":\n{daysshop2}\n");
            Console.ReadKey();
        }

        [Flags]
        public enum dayWeek
        {
            Понедельник = 0b_0000001,
            Вторник = 0b_0000010,
            Среда = 0b_0000100,
            Четверг = 0b_0001000,
            Пятница = 0b_0010000,
            Суббота = 0b_0100000,
            Воскресенье = 0b_1000000
        }
    }
}
