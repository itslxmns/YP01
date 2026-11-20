using System;

namespace MyFirstDll
{
    public class MyMath
    {
        public void PrintHello()
        {
            Console.WriteLine("DLL работает!");
        }

        //Метод, принимающий параметры
        public void PrintMessage(string message)
        {
            Console.WriteLine($"Сообщение из DLL: Все отлично!");
        }

        //Метод с возвращаемым значением типа int
        public int Add(int a, int b)
        {
            return a + b;
        }

        //Метод с возвращаемым значением типа string
        public string GetGreeting(string name)
        {
            return $"Привет,! Рад тебя видеть";
        }

        //Метод с возвращаемым значением типа double
        public double Divide(double a, double b)
        {
            if (b == 0) return 0;
            return a / b;
        }
    }
}