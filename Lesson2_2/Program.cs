using System;

namespace Lesson2_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //2. Запросить у пользователя порядковый номер текущего месяца и вывести его название

            Console.WriteLine("Введите порядкой номер месяца:");
            int mon = Convert.ToInt32(Console.ReadLine());
            string monstr = "";
            switch (mon)
            {
                case 1:
                    monstr = "Январь";
                    break;
                case 2:
                    monstr = "Февраль";
                    break;
                case 3:
                    monstr = "Март";
                    break;
                case 4:
                    monstr = "Апрель";
                    break;
                case 5:
                    monstr = "Май";
                    break;
                case 6:
                    monstr = "Июнь";
                    break;
                case 7:
                    monstr = "Июль";
                    break;
                case 8:
                    monstr = "Август";
                    break;
                case 9:
                    monstr = "Сентябрь";
                    break;
                case 10:
                    monstr = "Октябрь";
                    break;
                case 11:
                    monstr = "Ноябрь";
                    break;
                case 12:
                    monstr = "Декабрь";
                    break;
                default:
                    Console.WriteLine("Введите число от 1 до 12");
                    break;
            }
            Console.WriteLine(monstr);
            Console.ReadKey();
        }
    }
}
