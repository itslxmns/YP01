using System;

namespace PracticalTasks
{
    public class Prak1
    {
        public int Add(int a, int b) => a + b;

        private double Dev(int a, int b)
        {
            if (b == 0) throw new DivideByZeroException("Деление на ноль!");
            return (double)a / b;
        }

        public double Calculate(int a, int b) => Dev(a, b);

        public static void Main()
        {
            var calc = new Prak1();

            Console.Write("Введите первое число: ");
            int firstNumber = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите второе число: ");
            int secondNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Сложение: {calc.Add(firstNumber, secondNumber)}");
            Console.WriteLine($"Деление: {calc.Calculate(firstNumber, secondNumber)}");
        }
    }
}