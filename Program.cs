using System;
using System.Runtime.Remoting.Messaging;

namespace StringInterpolation
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            DateTime dateTime = new DateTime(2019, 01, 22, 11, 01, 27);
            

            int field = 40;

            Console.WriteLine($"{"January 22, 2019", 40}");
            Console.WriteLine($"{dateTime.Year}.{dateTime.Month}.{dateTime.Day}");
            Console.WriteLine($"Day {dateTime.Day} of January, {dateTime.Year}");
            Console.WriteLine($"Year: {dateTime.Year}, Month: {dateTime.Month}, Day: {dateTime.Day}");
            Console.WriteLine($"{"Tuesday", 10}");
            var pm = dateTime.ToString("hh:mm tt");
            Console.WriteLine($"{pm, 10}{dateTime.DayOfWeek, 10}");
            Console.WriteLine($"h:{dateTime.Hour}, m:{dateTime.Minute}, s:{dateTime.Second}");
            Console.WriteLine($"{dateTime.Year}.0{dateTime.Month}.{dateTime.Day}.{dateTime.Hour}.0{dateTime.Minute}.{dateTime.Second}");
            var pi = Math.PI;
            Console.WriteLine(pi.ToString("C"));
            Console.WriteLine($"{pi, 10:F3}");

        }
    }
}
