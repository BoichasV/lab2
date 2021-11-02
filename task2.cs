using System;

namespace ConsoleApp1
{                                                  //Завдання 2
    class User
    {
        public string id { get; set; }
        public string name { get; set; }
        public string surname { get; set; }
        public string age { get; set; }
   
        public User(string Id, string Name, string Surname, string Age)
        {
            id = Id;
            name = Name;
            surname = Surname;
            age = Age;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            bool c = true;
            User Sam = new User("1", "Sam", "Mas", "21");
            User Bob = new User("2", "Bob", "Lob", "22");
            User Feb = new User("3", "Feb", "Lob", "12");
            User[] m = new User[3];
            m[0] = Sam;
            m[1] = Bob;
            m[2] = Feb;

            string str_search = Console.ReadLine();
            foreach (User i in m)
            {
                if (i.id == str_search || i.name == str_search || i.surname == str_search || i.age == str_search)
                {
                    c = false;
                    Console.WriteLine($"ID: {i.id}, Name: {i.name}, Surname: {i.surname}, Age: {i.age}" );
                }
            }
            if (c == true)
            {
                Console.WriteLine($"Error, user not found");
            }
        }
    }
        
}

   