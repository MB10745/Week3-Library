namespace Library1
{
    public class Person
    {
        private string firstName;
        private string lastName;

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        public Person()
        {
            FirstName = "";
            LastName = "";
        }

        public Person(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        public string GetFullName()
        {
            return (FirstName + " " + LastName);
        }
    }
}
