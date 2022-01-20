namespace exercise10_science_institute
{
    public class Manager : Employee
    {
        public string Role { get; set; }
        public int NumOfWorkdays { get; set; }
        public double SalaryCoefficient { get; set; }

        public Manager(
            string name, 
            int birthYear, 
            string certificate, 
            string role, 
            int numOfWorkdays, 
            double salaryCoefficient) : base(name, birthYear, certificate)
        {
            Role = role;
            NumOfWorkdays = numOfWorkdays;
            SalaryCoefficient = salaryCoefficient;
        }

        public override double GetSalary()
        {
            return NumOfWorkdays * SalaryCoefficient;
        }

        public override string ToString()
        {
            return base.ToString() +
                   $"║ {Role,-5}" +
                   $"║ {NumOfWorkdays,19}" +
                   $"║ {SalaryCoefficient,19}";
        }
    }
}