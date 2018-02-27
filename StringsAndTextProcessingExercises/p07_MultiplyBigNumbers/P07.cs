using System;
using System.Linq;
using System.Text;

namespace p07_MultiplyBigNumbers
{
    class P07
    {
        static void Main(string[] args)
        {
            string num1 = Console.ReadLine();
            int num2 = int.Parse(Console.ReadLine());

            if (num2 == 0)
            {
                Console.WriteLine("0");
                return;
            }
            int multiplyer = 0;
            int remainder = 0;
            int num = 0;
            StringBuilder sb = new StringBuilder();

            for (int i = num1.Length - 1; i >= 0; i--)
            {
                multiplyer = (num1[i] - 48) * num2 + remainder;
                num = multiplyer % 10;
                if (multiplyer > 9)
                {
                    remainder = multiplyer / 10;
                }
                else
                {
                    remainder = 0;
                }

                sb.Append(num);
            }

            if (remainder > 0)
            {
                sb.Append(remainder);
            }

            Console.WriteLine(sb.ToString().TrimEnd('0').ToCharArray().Reverse().ToArray());
        }
    }
}
