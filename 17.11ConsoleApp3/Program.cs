using System;

namespace PracticalTasks
{
    public class User
    {
        public string Login;
        public string Email;
        public string Phone;
    }

    class Program
    {
        static void Main()
        {
            var user = new User
            {
                Login = "Dmitriy",
                Email = "Dmitriy@mail.ru",
                Phone = "+79001350415"
            };
            Console.WriteLine($"Пользователь: {user.Login}, {user.Email}, {user.Phone}");
        }
    }
}