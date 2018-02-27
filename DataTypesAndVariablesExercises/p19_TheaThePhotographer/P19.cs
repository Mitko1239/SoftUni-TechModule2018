using System;

namespace p19_TheaThePhotographer
{
    class P19
    {
        static void Main(string[] args)
        {
            int photos = int.Parse(Console.ReadLine());
            int filterTime = int.Parse(Console.ReadLine());
            int filterFactor = int.Parse(Console.ReadLine());
            int uploadTime = int.Parse(Console.ReadLine());

            double percent = filterFactor * 0.01;

			int filteredPhotos = (int)Math.Ceiling(photos * percent);
            long totalFilterTime = (long)photos * filterTime;
            long totalUploadTime = (long)filteredPhotos * uploadTime;
            long totalTime = totalFilterTime + totalUploadTime;

            TimeSpan time = TimeSpan.FromSeconds(totalTime);

            Console.WriteLine($"{time.Days}:{time.Hours:d2}:{time.Minutes:d2}:{time.Seconds:d2}");
        }
    }
}
