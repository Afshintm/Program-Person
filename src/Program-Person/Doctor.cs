namespace Program_Person
{
    public class Doctor: Person
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
}
