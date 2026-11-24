using System;
class Program
{
    static void Main()
    {
        Console.Write("Введите первую строку: "); //программа просит пользователя ввести первую строку и
        string first = Console.ReadLine(); //сохраняет её в переменную first

        Console.Write("Введите вторую строку: ");
        string second = Console.ReadLine();

        //сравниваем строки методом Compare(Сравнить)
        int result = string.Compare(first, second);
        Console.WriteLine("Сравнение строк:");

        if (result == 0)
        {
            Console.WriteLine("Строки равны");
        }
        else if (result < 0)
        {
            Console.WriteLine("Первая строка стоит раньше второй");
        }
        else
        {
            Console.WriteLine("Первая строка стоит позже второй");
        }

        //проверяем равенство строк методом Equals(Равно)
        Console.WriteLine("Метод Equals():");
        Console.WriteLine(string.Equals(first, second));

        //сравниваем строки по значениям символов методом CompareOrdinal(СравнитьПорядковое)
        Console.WriteLine("Метод CompareOrdinal():");
        Console.WriteLine(string.CompareOrdinal(first, second));

        //проверяем строки оператором ==
        Console.WriteLine("Оператор ==:");
        Console.WriteLine(first == second);

        //проверяем строки оператором !=
        Console.WriteLine("Оператор !=:");
        Console.WriteLine(first != second);

        //ищем позицию 2 строки внутри 1
        Console.WriteLine("Метод IndexOf():");
        int index = first.IndexOf(second);
        Console.WriteLine("Позиция: " + index);

        //проверяем наличие 2 строки внутри 1
        Console.WriteLine("Метод Contains():");
        Console.WriteLine(first.Contains(second));
    }
}