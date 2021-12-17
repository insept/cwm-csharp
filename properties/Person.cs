namespace Properties
{
    public class Person 
    {
        public string Name { get; private set; }
        public string Username { get; set; }
        public DateTime Birthdate { get; private set; }

        public Person(string name)
        {
            Name = name;
        }
        public Person(string name, DateTime birthdate)
        {   this.Name = name;

            Birthdate = birthdate;
        }
        public int Age
        {
            get
            { 
                var timeSpan = DateTime.Today - Birthdate;
                var years = timeSpan.Days/365;

                return years;
            }
        }
    }
}
