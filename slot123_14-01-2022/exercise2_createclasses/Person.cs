using System;

namespace exercise2_createclasses
{
    public class Person
    {
        public int Age { get; set; }
        public string Name { get; set; }

        public Person()
        {
        }
        public Person(int age, string name)
        {
            Age = age;
            Name = name;
        }

        public void DisplayPerson() {}
        public void Input() {}

        public override string ToString()
        {
            return $"Name: {Name}, Age: {Age}";
        }
    }
}