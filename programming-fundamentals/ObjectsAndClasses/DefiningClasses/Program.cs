using System;

namespace DefiningClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            //Student student = new Student()
            //{
            //    Name = "Pesho",
            //    Age = 25
            //};

            //student.Age = 30;

            //student.PrintStudent();

            //List<Student> students =

            Student student = Student.Parse(Console.ReadLine());

            Student student2 = new Student("Gosho", 22);

            Console.WriteLine(student2.Name);

            
        }
    }
}
