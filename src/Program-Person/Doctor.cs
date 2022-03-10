namespace Program_Person
{
    public class Doctor_old: Person
    {
       
        public Specialities Speciality { get; set; }
    
        public void m1()
        {
            Doctor drSaeid = new Doctor();
            string nam1 = drSaeid.Name;

        }
        public override string ToString()
        {
            //return base.ToString();
            return "I am doctor " + Name + " " + Family + " and " + Age.ToString()+" years old, my specilality is " + Speciality;
        }
    }

    public class Doctor
    {
        public Doctor(Person p) 
        { 
            Person = p; 
        }
        //public Doctor() { }
        public Doctor(string name, string familyName, int age) 
            :this(new Person { Name = name, Family = familyName, Age= age})
        {
            
        }
        public Person Person { get; private set; }

        public Specialities Speciality { get; set; }
        public void ChangeName(string newName) 
        {
            if (newName.Length < 50)
                Person.Name = newName;
        }
       
        public override string ToString()
        {
            //return base.ToString();
            return "I am doctor " +Person.Name + " " + Person.Family + " and " + Person.Age.ToString() + " years old, my specilality is " + Speciality;
        }
    }
}
