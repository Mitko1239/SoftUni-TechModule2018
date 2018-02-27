using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClasses
{
    class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Student(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public Student()
        {
        }

        public override string ToString()
        {
            return Name;
        }

        public void PrintStudent()
        {
            Console.WriteLine(Name + " -> " + Age);
        }

        public static Student Parse(string input)
        {
            string[] tokens = input.Split();

            return new Student() { Name = tokens[0], Age = int.Parse(tokens[1]) };
        }

    }
}
