using System;

namespace p01_BlankReceipt
{
    class P01
    {
        static void Main(string[] args)
        {
            //PrintStudent("Pesho", 20);
            PrintTriangle(29);
        }

        static void PrintStudent(string name, int age, double grade = 2.00)
        {
            Console.WriteLine($"Student: {name}; Age {age}; Grade: {grade}");
        }

        static void PrintTriangle(int n)
        {
            for (int line = 1; line <= n; line++)
                PrintLine(1, line);

            for (int line = n - 1; line >= 1; line--)
                PrintLine(1, line);
        }

        static void PrintLine(int start, int end)
        {
            for (int i = start; i <= end; i++)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }


    }
}
