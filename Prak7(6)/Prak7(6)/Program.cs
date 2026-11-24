using System;
using System.Globalization;

namespace DateTimeTasks
{
    class Program
    {
        static void Main(string[] args)
        {
            //Parse (выводим просто дату)
            string date1Str = "24.11.2026";
            DateTime date1 = DateTime.Parse(date1Str);
            Console.WriteLine(date1.ToShortDateString());

            //ParseExact
            string date2Str = "25.11.2026";
            Console.WriteLine("Метод ParseExact():");
            DateTime date2 = DateTime.ParseExact(date2Str, "dd.MM.yyyy", null);
            Console.WriteLine(date2.ToShortDateString());

            //TryParse
            string date3Str = "26.11.2026";
            Console.WriteLine("Метод TryParse():");
            if (DateTime.TryParse(date3Str, out DateTime result1))
            {
                Console.WriteLine($"Дата успешно преобразована: {result1.ToShortDateString()}");
            }

            //TryParseExact
            string date4Str = "27.11.2026";
            Console.WriteLine("Метод TryParseExact():");
            if (DateTime.TryParseExact(date4Str, "dd.MM.yyyy", null, DateTimeStyles.None, out DateTime result2))
            {
                Console.WriteLine($"Дата успешно преобразована: {result2.ToShortDateString()}");
            }

            Console.ReadLine();
        }
    }
}