using System;
using System.Collections.Generic;
using System.Linq;

namespace p02_AppendLists
{
    class P02
    {
        static void Main(string[] args)
        {
            // Variant 1
            //List<string> textList = Console.ReadLine()
            //    .Split('|')
            //    .ToList();

            //textList.Reverse();

            //foreach (var text in textList)
            //{
            //    var textArr = text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            //    var joined = string.Join(" ", textArr);
            //    Console.Write(joined + " ");
            //}
            //Console.WriteLine();

            //Variant 2
            List<List<string>> outerList = Console.ReadLine()
                .Split('|')
                .Reverse()
                .Select(
                    s => s.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList()
                ).ToList();

            foreach (var innerList in outerList)
            {
                Console.Write(string.Join(" ", innerList) + " ");
            }
            Console.WriteLine();
        }
    }
}
