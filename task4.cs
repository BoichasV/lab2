using System;

namespace ConsoleApp1
{                                                                       //Завдання 4

    class Person
    {
        public string id { get; set; }
        public string name { get; set; }
        public string surname { get; set; }
        public string age { get; set; }

        public Person(string Id, string Name, string Surname, string Age)
        {
            id = Id;
            name = Name;
            surname = Surname;
            age = Age;
        }
        public Person() 
        {
            id = "0";
            name = "DefaultName";
            surname = "DefaultSurname";
            age = "0";
        }
        public Person(string ID, string NAME) 
        {
            id = ID;
            name = NAME;
            surname = "DefaultSurname";
            age = "0";
        }
        public void GetInfo()
        {
            Console.WriteLine($"Id: {id}; Name: {name}; Surname: {surname};  Age: {age}. ");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Person Non = new Person();
            Person Sam = new Person("1", "Sam", "Mas", "21");
            Person Bob = new Person("2", "Bob");
            Sam.GetInfo();
            Non.GetInfo();
            Bob.GetInfo();

        }
    }
}