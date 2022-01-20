namespace exercise10_science_institute
{
    public class LabStaff : Employee
    {
        public double Salary { get; set; }

        public LabStaff(
            string name, 
            int birthYear, 
            string certificate, 
            double salary) : base(name, birthYear, certificate)
        {
            Salary = salary;
        }

        public override double GetSalary()
        {
            return Salary;
        }
    }
}