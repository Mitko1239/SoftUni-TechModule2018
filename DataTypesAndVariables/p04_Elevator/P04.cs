using System;

namespace p04_Elevator
{
    class P04
    {
        static void Main(string[] args)
        {
            int people = int.Parse(Console.ReadLine());
            int capacity = int.Parse(Console.ReadLine());
            int courses = (int)Math.Ceiling(1.0 * people / capacity);
            Console.WriteLine(courses);
        }
    }
}
