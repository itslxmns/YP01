using System;
using MyFirstDll;

namespace DllTester
{
    class Program
    {
        static void Main(string[] args)
        {
            //Создаем экземпляр нашего класса из DLL
            MyMath math = new MyMath();

            Console.WriteLine("Тестирование методов");
            math.PrintHello();
            math.PrintMessage("Тестирование прошло успешно");

            Console.WriteLine("Тестирование методов с возвращаемым значением");

            int sum = math.Add(10, 25);
            Console.WriteLine($"Результат сложения: {sum}");

            string greeting = math.GetGreeting("Студент");
            Console.WriteLine($"Результат приветствия: {greeting}");

            double division = math.Divide(15, 5);
            Console.WriteLine($"Результат деления: {division}");
            Console.ReadLine();
        }
    }
}