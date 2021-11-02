using System;

namespace ConsoleApp1
{                                                           //Завдання 3
     class Worker
     {
         public double sum { get; set; }
         public static double operator +(Worker salary, double premium)
         {
             return salary.sum + premium;
         }
     }
     class Program
     {
         static void Main(string[] args)
         {
             double premium = 1000;
             Worker salary = new Worker { sum = 12000 };
             double result = salary + premium;
             Console.WriteLine($"You`re salary: {result}$");
             Console.ReadKey();
         }
     }
 }
    