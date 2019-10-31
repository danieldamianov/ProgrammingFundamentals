using System;

namespace _18_Different_Integers_Size
{
    class Program
    {
        static void Main(string[] args)
        {
            long totalPicturers = long.Parse(Console.ReadLine());
            long filterTime = long.Parse(Console.ReadLine());
            long percantegeOfFiltring = long.Parse(Console.ReadLine());
            long uploadTime = long.Parse(Console.ReadLine());
            long time = 0;
            time += totalPicturers * filterTime;
            decimal floatingPontUsefulPictures = 1.0m* totalPicturers * ((decimal)percantegeOfFiltring / 100);
            decimal usefulPhotos = Math.Ceiling(floatingPontUsefulPictures);
            time += (long)usefulPhotos * uploadTime;
            Console.Write($"{time / 86400}:");
            time = time - (time / 86400) * 86400;
            Console.Write($"{time / 3600:d2}:");
            time = time - (time / 3600) * 3600;
            Console.Write($"{time / 60:d2}:");
            time = time - (time / 60) * 60;
            Console.WriteLine($"{time:d2}");
        }
    }
}
