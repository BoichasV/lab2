using System;

namespace ConsoleApp1
{                                                             //Завдання 1
    class Person
    {
        public static int count = 0;
        public Person()
        {
            count++;
        }
        public static void GetInfo()
        {
            System.Console.WriteLine($"You`re created {count} objects");

        }
    }
    class Program
    {
        static void Main(string[] args)
        {

            Person sam = new Person();
            Person max = new Person();
            Person pet = new Person();

            Person.GetInfo();


        }
    }
}