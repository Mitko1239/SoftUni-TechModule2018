using System;
using System.Linq;

namespace p18_SequenceOfCommands
{
    class P18
    {
        private const char ArgumentsDelimiter = ' ';

        public static void Main()
        {
            int sizeOfArray = int.Parse(Console.ReadLine());

            long[] array = Console.ReadLine()
                .Split(ArgumentsDelimiter)
                .Select(long.Parse)
                .ToArray();

            string command = Console.ReadLine().Trim();

            while (!command.Equals("stop"))
            {

                int[] args = new int[2];
                string[] stringSplit = command.Split(ArgumentsDelimiter);
                string commandName = stringSplit[0];

                if (commandName.Equals("add") ||
                    commandName.Equals("subtract") ||
                    commandName.Equals("multiply"))
                {

                    args[0] = int.Parse(stringSplit[1]);
                    args[1] = int.Parse(stringSplit[2]);
                }

                PerformAction(array, commandName, args);

                PrintArray(array);
                Console.WriteLine();

                command = Console.ReadLine();
            }
        }

        static void PerformAction(long[] arr, string action, int[] args)
        {
            //long[] array = arr;
            int pos = args[0] - 1;
            int value = args[1];

            switch (action)
            {
                case "multiply":
                    arr[pos] *= value;
                    break;
                case "add":
                    arr[pos] += value;
                    break;
                case "subtract":
                    arr[pos] -= value;
                    break;
                case "lshift":
                    ArrayShiftLeft(arr);
                    break;
                case "rshift":
                    ArrayShiftRight(arr);
                    break;
            }
        }

        private static void ArrayShiftRight(long[] array)
        {
            long[] clonedArray = array.Clone() as long[];

            for (int i = 1; i < clonedArray.Length; i++)
            {
                array[i] = clonedArray[i - 1];
            }

            array[0] = clonedArray[array.Length - 1];
        }

        private static void ArrayShiftLeft(long[] array)
        {
            long[] clonedArray = array.Clone() as long[];

            for (int i = 0; i < clonedArray.Length - 1; i++)
            {
                array[i] = clonedArray[i + 1];
            }

            array[array.Length - 1] = clonedArray[0];
        }

        private static void PrintArray(long[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
        }
    }
}
