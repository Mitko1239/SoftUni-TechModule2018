using System;
using System.Globalization;

namespace ObjectsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var birthday = new { Day = 27, Month = 11, Year = 1996 };

            DateTime bDay = new DateTime(1992, 2, 27);
            DateTime bDay2 = DateTime.Now;

            //dynamic day = 1;
            //day = "Monday";

            DateTime endWorld = DateTime.MaxValue;

            //System.Threading.Thread.CurrentThread.CurrentCulture = new CultureInfo("zh-CN");

            Console.WriteLine("{0:MMMM}", endWorld);

            //Console.WriteLine(bDay2.Day);
        }
    }
}
