using System;

namespace p12_NumberChecker
{
    class P12
    {
        static void Main(string[] args)
        {
            try
            {
                int number = int.Parse(Console.ReadLine());
                Console.WriteLine("It is a number.");
            }
            catch (Exception)
            {
                //Houston, we have a problem!
                Console.WriteLine("Invalid input!");
            }
        }
    }
}
