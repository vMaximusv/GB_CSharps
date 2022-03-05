using System;

namespace Lesson2_4
{
    class Program
    {
        static void Main(string[] args)
        {
            //4. Рисование чека

            string nameShop = "АО \"Дикси-Юг\"";
            string location = "г. Москва, Анадырский пр-д, 21";
            double inn = 7704249540;
            int nc = 002;
            string tov = "Колбаса док.";
            int sum;
            int kolvo = 1;
            int cen = 230;
            int itog = 0;

            Console.WriteLine("\t\t" + nameShop);
            Console.WriteLine("\t" + location);
            Console.WriteLine("\t\tИНН " + inn);
            Console.WriteLine("Чек на продажу №:" + nc + "\tДата: " + DateTime.Now);
            Console.WriteLine("    Наименование\tКол-во   Цена   Стоим");
            Console.WriteLine($"{tov}\t\t {kolvo}\t {cen}  =  {sum = kolvo * cen}");
            itog += sum;
            tov = "Хлеб белый";
            kolvo = 2;
            cen = 100;
            Console.WriteLine($"{tov}\t\t {kolvo}\t {cen}  =  {sum = kolvo * cen}");
            itog += sum;
            tov = "Молоко 3,2%";
            kolvo = 1;
            cen = 150;
            Console.WriteLine($"{tov}\t\t {kolvo}\t {cen}  =  {sum = kolvo * cen}");
            itog += sum;
            Console.WriteLine("**************************************************");
            Console.WriteLine($"\t\t\tСУММА ПО ЧЕКУ {itog}");
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine($"ПОДИТОГ\t\tруб.\t\t {itog}");
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine($"\t\tИТОГО К ОПЛАТЕ {itog}");
            Console.WriteLine($"\t\tНАЛИЧНЫЕ       {itog}");
            Console.WriteLine($"\t\tСДАЧА          0,00");
            Console.ReadKey();
        }
    }
}
