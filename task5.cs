using System;

namespace ConsoleApp1
{
                                                                        //Завдання 5
    class User
    {
        private static int id { get; } = 1;
        private static string name { get; } = "Sam";
        private static string surname { get; } = "Mas";
        public static void GetInfo()
        {
            System.Console.WriteLine($"User #{id} have name: {name}, and surname: {surname}");

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            User sam = new User();
            User.GetInfo();
        }
    }
}