using System;

namespace Program_Person
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter Number of Persons:");
            int Number = Convert.ToInt32(Console.ReadLine());
            Person[] people = new Person[Number];

            for (int i=0;i<Number;i++)
            {
                Console.Write($"Enter Person[{i+1}] name:");
                string Name=Console.ReadLine();
                
                Console.Write($"Enter Person[{i + 1}] family:");
                string Family = Console.ReadLine();
               
                Console.Write($"Enter Person[{i + 1}] age:");
                int Age = Convert.ToInt32(Console.ReadLine());

                Person p = new Person(Name, Family, Age);
                people[i] = p;

            }

            Console.ForegroundColor = ConsoleColor.Green;

            foreach (Person person in people)
            {
                Console.WriteLine($"Name:{person.Name} Family:{person.Family} Age:{person.Age}");
            }

            Console.ResetColor();
            Console.ReadKey();
        }
    }
}
