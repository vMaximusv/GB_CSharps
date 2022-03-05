using System;

namespace Lesson2_5
{
    class Program
    {
        static void Main(string[] args)
        {
            //5. Если пользователь указал месяц из зимнего периода, а средняя температура > 0, вывести сообщение «Дождливая зима».

            string season = "";
            Console.WriteLine("Введите месяц:");
            string month = Console.ReadLine();
            Console.WriteLine("Введите среднюю температуру за месяц:");
            int tempmonth = Convert.ToInt32(Console.ReadLine());
            switch (month)
            {
                case "Декабрь":
                case "Январь":
                case "Февраль":
                    season = "Зима";
                    break;
                case "Март":
                case "Апрель":
                case "Май":
                    season = "Весна";
                    break;
                case "Июнь":
                case "Июль":
                case "Август":
                    season = "Лето";
                    break;
                case "Сентябрь":
                case "Октябрь":
                case "Ноябрь":
                    season = "Осень";
                    break;
                default:
                    Console.WriteLine("Такого месяца нет");
                    break;
            }
            if (season == "Зима" && tempmonth > 0)
            {
                Console.WriteLine("Дождливая зима");
            }
            else if (season == "Зима" && tempmonth <= 0)
            {
                Console.WriteLine("Суровая зима");
            }
            Console.ReadKey();
        }
    }
}
