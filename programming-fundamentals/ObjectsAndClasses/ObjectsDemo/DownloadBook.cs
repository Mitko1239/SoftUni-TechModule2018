using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net;
using System.Text;

namespace ObjectsDemo
{
    class DownloadBook
    {
        static void Main2(string[] args)
        {
            DateTime today = DateTime.Now;
            Console.WriteLine("Today is: " + today);
            DateTime tomorrow = today.AddDays(1);
            Console.WriteLine("Tomorrow is: " + tomorrow);
            double angleDegrees = 60;
            double angleRadians = angleDegrees * Math.PI / 180;
            Console.WriteLine(Math.Cos(angleRadians)); // 0.5
            Random rnd = new Random();
            Console.WriteLine("Random number = " + rnd.Next(1, 100));
            WebClient webClient = new WebClient();
            webClient.DownloadFile("http://www.introprogramming.info/wp-content/uploads/2015/10/Intro-CSharp-Book-v2015.pdf", "book.pdf");
            Process.Start("book.pdf");

        }
    }
}
