using System;
using System.Globalization;

namespace DateAndHours
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime d1 = DateTime.Now;

            Console.WriteLine(d1);
            Console.WriteLine(d1.Ticks);

            DateTime d2 = new DateTime(2018, 11, 25);
            Console.WriteLine(d2);

            DateTime d3 = new DateTime(2018, 11, 25, 20, 45, 3);
            Console.WriteLine(d3);

            DateTime d4 = new DateTime(2018, 11, 25, 20, 45, 3, 500);
            Console.WriteLine(d4);

            DateTime d5 = DateTime.Now;
            Console.WriteLine(d5);

            DateTime d6 = DateTime.Today;
            Console.WriteLine(d6);

            DateTime d7 = DateTime.UtcNow;
            Console.WriteLine(d7);

            DateTime d8 = DateTime.Parse("2000-08-15");
            Console.WriteLine(d8);

            DateTime d9 = DateTime.Parse("2000-08-15 13:05:58");
            Console.WriteLine(d9);

            DateTime d10 = DateTime.Parse("15/08/2000");
            Console.WriteLine(d10);

            DateTime d11 = DateTime.ParseExact("2000-08-15", "yyyy-MM-dd", CultureInfo.InvariantCulture);
            Console.WriteLine(d11);

            DateTime d12 = DateTime.ParseExact("10/30/2000", "MM/dd/yyyy", CultureInfo.InvariantCulture);
            Console.WriteLine(d12);

            Console.WriteLine("----------");

            TimeSpan t1 = new TimeSpan(0, 1, 30);
            Console.WriteLine(t1);
            Console.WriteLine(t1.Ticks);

            TimeSpan t2 = new TimeSpan();
            Console.WriteLine(t2);

            TimeSpan t3 = new TimeSpan(900000000L);
            Console.WriteLine(t3);

            TimeSpan t4 = new TimeSpan(1, 2, 11, 57);
            Console.WriteLine(t4);

            TimeSpan t5 = new TimeSpan(1, 2, 11, 57, 321);
            Console.WriteLine(t5);

            TimeSpan t6 = TimeSpan.FromDays(1.5);
            Console.WriteLine(t6);

            TimeSpan t7 = TimeSpan.FromHours(1.5);
            Console.WriteLine(t7);

            TimeSpan t8 = TimeSpan.FromMinutes(1.5);
            Console.WriteLine(t8);

            TimeSpan t9 = TimeSpan.FromSeconds(1.5);
            Console.WriteLine(t9);
        }
    }
}
