using System;

namespace Program_Person
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Please Enter Number of Persons:");
            //int Number = Convert.ToInt32(Console.ReadLine());
            //Person[] people = new Person[Number];

            //for (int i=0;i<Number;i++)
            //{
            //    Console.Write($"Enter Person[{i+1}] name:");
            //    string Name=Console.ReadLine();

            //    Console.Write($"Enter Person[{i + 1}] family:");
            //    string Family = Console.ReadLine();

            //    Console.Write($"Enter Person[{i + 1}] age:");
            //    int Age = Convert.ToInt32(Console.ReadLine());

            //    Person p = new Person(Name, Family, Age);
            //    people[i] = p;

            //}

            //Console.ForegroundColor = ConsoleColor.Green;

            //foreach (Person person in people)
            //{
            //    Console.WriteLine($"Name:{person.Name} Family:{person.Family} Age:{person.Age}");
            //}

            //Console.ResetColor();
            //Console.ReadKey();

            Doctor Dr1 = new Doctor();
            Dr1.Name = "Saeid";
            Dr1.Family = "Rouzitalab";
            Dr1.Age = 39;
            Dr1.Speciality = Specialities.Eyes;


            var dr2 = new Doctor { Name = "Ali", Family = "Naderi", Age = 35, Speciality = Specialities.Heart };
            Console.WriteLine(Dr1.ToString());

            var per1 = new Person { Age = 34, Family = "Abbasi", Name = "Samira" };
            Console.WriteLine(per1.ToString());

        }

    }
}


