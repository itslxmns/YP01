using System;

namespace SimpleException
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите любое число: ");
            string input = Console.ReadLine();
            try
            {
                int number = int.Parse(input);
                int result = 100 / number;
                Console.WriteLine("Результат: " + result);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ой, произошла ошибка!");
                Console.WriteLine("Что случилось: " + ex.Message);
            }
            finally
            {
                Console.WriteLine("Программа завершила работу.");
            }
            Console.ReadLine();
        }
    }
}