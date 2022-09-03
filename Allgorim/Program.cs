using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Allgoritm
{

    class Program
    {
        static void Main()
        {                 
            User user1 = new User("1", "Ivan", false);
            User user2 = new User("2", "Petr", true);
            User user3 = new User("3", "Mari", false);
            user1.UserChek();
            Console.WriteLine();
            user2.UserChek();
            Console.WriteLine();
            user3.UserChek();
            Console.ReadKey();
        }
    }
    class User
    {
        public string Login { get; set; }
        public string Name { get; set; }
        public bool IsPremium { get; set; }
        public User (string login, string name, bool ispremium)
        {
            Login = login;
            Name = name;
            IsPremium = ispremium;
        }
        public void UserChek()
        {
            if (IsPremium == false)
            {
                Console.WriteLine(Name);
                ShowAds();
            }
            else
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine($"Привет!!! {Name}");
                Console.BackgroundColor = ConsoleColor.Black;
                Thread.Sleep(3000);
            }
        }
        static void ShowAds()
        {
            Console.WriteLine("Посетите наш новый сайт с бесплатными играми free.games.for.a.fool.com");
            // Остановка на 1 с
            Thread.Sleep(1000);

            Console.WriteLine("Купите подписку на МыКомбо и слушайте музыку везде и всегда.");
            // Остановка на 2 с
            Thread.Sleep(2000);

            Console.WriteLine("Оформите премиум-подписку на наш сервис, чтобы не видеть рекламу.");
            // Остановка на 3 с
            Thread.Sleep(3000);
        }
    }
}


