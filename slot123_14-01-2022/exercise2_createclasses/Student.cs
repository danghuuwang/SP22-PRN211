namespace exercise2_createclasses
{
    public class Student : Person
    {
        public double Gpa { get; set; }

        public Student()
        {
        }

        public Student(int age, string name, double gpa) : base(age, name)
        {
            Gpa = gpa;
        }

        public void DisplayStudent() {}
        public void Input() {}

        public override string ToString()
        {
            return base.ToString() + $", GPA: {Gpa}";
        }
    }
}