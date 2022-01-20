namespace exercise10_science_institute
{
    public abstract class Employee
    {
        public string Name { get; set; }
        public int BirthYear { get; set; }
        public string Certificate { get; set; }

        protected Employee(string name, int birthYear, string certificate)
        {
            Name = name;
            BirthYear = birthYear;
            Certificate = certificate;
        }

        public abstract double GetSalary();

        public override string ToString()
        {
            return $"║ {Name,-18}" +
                   $"║ {BirthYear,11}" +
                   $"║ {Certificate,-12}";
        }
    }
}