using System;
using System.Collections.Generic;
using System.Linq;

namespace LibraryLib
{
    /// <summary>
    /// Класс LibraryFunctions реализует функциональность для управления
    /// сотрудниками, книгами и читателями городской библиотеки г. Чита
    /// </summary>
    public class LibraryFunctions
    {
        // Название библиотеки
        private const string LIBRARY_NAME = "Городская библиотека г.Чита";

        // Список сотрудников библиотеки
        private List<string> libraryStaff;

        // ФИО главного библиотекаря
        private string chiefLibrarian;

        /// <summary>
        /// Конструктор класса LibraryFunctions
        /// Инициализирует данные о библиотеке и сотрудниках
        /// </summary>
        public LibraryFunctions()
        {
            // Инициализация списка сотрудников
            libraryStaff = new List<string>
            {
                "Петров П.С.",
                "Сидорова А.В.",
                "Козлов И.Д.",
                "Иванова М.П."
            };

            // Установка главного библиотекаря по умолчанию
            chiefLibrarian = "Иванова М.П.";
        }

        /// <summary>
        /// Метод GetChiefLibrarian возвращает ФИО главного библиотекаря
        /// </summary>
        /// <returns>Строка с ФИО главного библиотекаря</returns>
        public string GetChiefLibrarian()
        {
            return chiefLibrarian;
        }

        /// <summary>
        /// Метод GetLibraryName возвращает название библиотеки
        /// </summary>
        /// <returns>Строка с названием библиотеки</returns>
        public string GetLibraryName()
        {
            return LIBRARY_NAME;
        }

        /// <summary>
        /// Метод SetChiefLibrarian изменяет ФИО главного библиотекаря
        /// Изменение происходит только если указанное ФИО есть в списке сотрудников
        /// </summary>
        /// <param name="fullname">ФИО нового главного библиотекаря</param>
        /// <returns>true, если главный библиотекарь успешно изменен, иначе false</returns>
        public bool SetChiefLibrarian(string fullname)
        {
            // Проверка наличия переданного ФИО в списке сотрудников
            if (libraryStaff.Contains(fullname))
            {
                chiefLibrarian = fullname;
                return true;
            }
            return false;
        }

        /// <summary>
        /// Метод GenerateBookCode формирует код книги вида CAT_number
        /// где CAT - это категория книги, number - случайный номер
        /// </summary>
        /// <param name="category">Категория книги (например, ART, SCI, BIO)</param>
        /// <param name="number">Максимальный номер для генерации (верхняя граница)</param>
        /// <returns>Сгенерированный код книги в формате CAT_number</returns>
        public string GenerateBookCode(string category, int number)
        {
            // Проверка корректности входных данных
            if (string.IsNullOrWhiteSpace(category) || number <= 0)
            {
                throw new ArgumentException("Категория не может быть пустой, а номер должен быть больше 0");
            }

            // Генерация случайного номера от 1 до number (включительно)
            Random random = new Random();
            int randomNumber = random.Next(1, number + 1);

            // Формирование кода в формате CAT_number
            return $"{category.ToUpper()}_{randomNumber}";
        }

        /// <summary>
        /// Метод GetStaff возвращает список всех сотрудников библиотеки
        /// </summary>
        /// <returns>Список сотрудников библиотеки</returns>
        public List<string> GetStaff()
        {
            // Возвращаем копию списка, чтобы исходный список не был изменен извне
            return new List<string>(libraryStaff);
        }

        /// <summary>
        /// Метод AddStaff добавляет нового сотрудника в список сотрудников
        /// </summary>
        /// <param name="fullname">ФИО нового сотрудника</param>
        /// <returns>true, если сотрудник успешно добавлен, false если сотрудник уже в списке</returns>
        public bool AddStaff(string fullname)
        {
            // Проверка на пустое значение
            if (string.IsNullOrWhiteSpace(fullname))
            {
                return false;
            }

            // Проверка наличия сотрудника в списке
            if (libraryStaff.Contains(fullname))
            {
                return false;
            }

            // Добавление нового сотрудника
            libraryStaff.Add(fullname);
            return true;
        }
    }
}
