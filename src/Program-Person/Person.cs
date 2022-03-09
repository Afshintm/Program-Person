using System;

namespace Program_Person
{
    public class Person
    {
        public string Name;
        public string Family;
        public int Age;

        public Person(string Name, String Family, int Age)
        {
            this.Name = Name;
            this.Family = Family;
            this.Age = Age;

        }
        public Person()
        {

        }
        public override string ToString()
        {
            //return base.ToString();
            return  "I am " + Name +" "+Family+" and " + Age.ToString()+" years old." ;
        }
    }
    
}
