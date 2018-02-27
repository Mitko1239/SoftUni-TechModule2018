using System;

namespace RandomDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Random rnd = new Random();
            //Console.WriteLine(rnd.Next(100,200));

            string[] words = Console.ReadLine().Split();

            Random random = new Random();

            for (int i = 0; i < words.Length; i++)
            {
                int pos = random.Next(0, words.Length);

                string temp = words[i];
                words[i] = words[pos];
                words[pos] = temp;
            }
            Console.WriteLine(string.Join(" ", words));
        }
    }
}
