using System;
using System.Collections.Generic;
using LibraryLib;

namespace NovoselovTest
{
    /// <summary>
    /// Тестовое приложение для проверки функциональности библиотеки LibraryLib
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            LibraryFunctions library = new LibraryFunctions();

            Console.WriteLine("===== ТЕСТИРОВАНИЕ БИБЛИОТЕКИ LibraryLib =====\n");

            // Тест 1: GetLibraryName
            Console.WriteLine("1. Название библиотеки: " + library.GetLibraryName());

            // Тест 2: GetChiefLibrarian
            Console.WriteLine("2. Главный библиотекарь: " + library.GetChiefLibrarian());

            // Тест 3: GetStaff
            Console.WriteLine("\n3. Список сотрудников:");
            List<string> staff = library.GetStaff();
            foreach (var emp in staff)
            {
                Console.WriteLine("   - " + emp);
            }

            // Тест 4: SetChiefLibrarian
            Console.WriteLine("\n4. Смена главного библиотекаря на 'Петров П.С.':");
            bool result = library.SetChiefLibrarian("Петров П.С.");
            Console.WriteLine("   Результат: " + (result ? "Успех" : "Ошибка"));
            Console.WriteLine("   Новый главный: " + library.GetChiefLibrarian());

            // Тест 5: GenerateBookCode
            Console.WriteLine("\n5. Генерация кодов книг:");
            Console.WriteLine("   " + library.GenerateBookCode("ART", 1000));
            Console.WriteLine("   " + library.GenerateBookCode("SCI", 500));

            // Тест 6: AddStaff
            Console.WriteLine("\n6. Добавление нового сотрудника 'Смирнов С.И.':");
            bool added = library.AddStaff("Смирнов С.И.");
            Console.WriteLine("   Результат: " + (added ? "Добавлен" : "Уже есть"));

            Console.WriteLine("\n===== ТЕСТИРОВАНИЕ ЗАВЕРШЕНО =====");
            Console.ReadKey();
        }
    }
}