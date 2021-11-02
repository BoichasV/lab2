using System;

namespace ConsoleApp1
{                                                           //Завдання 6

    class Buyer 
    {
        public static string name { get; set; }
        public static string surname { get; set; }
        public static string card { get; set; }
        public static string age { get; set; }
        public static double order { get; set; }
        public static bool salecard { get; set; }
        public static void createBuy()
        {
            Console.Write($"Enter you`re name: ");
            name = Console.ReadLine();
            Console.Write($"Enter you`re surname: ");
            surname = Console.ReadLine();
            Console.Write($"Enter you`re card: ");
            card = Console.ReadLine();
            Console.Write($"Enter you`re age: ");
            age = Console.ReadLine();
            Console.Write($"Enter sum of you`re order: ");
            order = double.Parse(Console.ReadLine());
            Console.Write($"Do you have sale card?(YES or NO): ");
            string sales = Console.ReadLine();
            if (sales == "YES") { salecard = true; }
            else { salecard = false; }

        }
        public static void getInfo()
        {
            Console.WriteLine($"Name: {name}; Surname: {surname};  Age: {age}; Card: {card}; Sum of the order {order} ");
        }
        public static void sale() 
        {
            if (salecard == true)
            {
                order = order - (order * 0.05);
            }
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Buyer obj = new Buyer();
            Buyer.createBuy();
            Buyer.sale();
            Buyer.getInfo();
        }
    }
}