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

            Console.WriteLine("----------");

            DateTime dt = new DateTime(2001, 8, 5, 13, 45, 58, 275);

            Console.WriteLine($"1) Date: {dt.Date}");
            Console.WriteLine($"2) Day: {dt.Day}");
            Console.WriteLine($"3) DayOfWeek: {dt.DayOfWeek}");
            Console.WriteLine($"4) DayOfYear: {dt.DayOfYear}");
            Console.WriteLine($"5) Hour: {dt.Hour}");
            Console.WriteLine($"6) Kind: {dt.Kind}");
            Console.WriteLine($"7) Millisecond: {dt.Millisecond}");
            Console.WriteLine($"8) Minute: {dt.Minute}");
            Console.WriteLine($"9) Month: {dt.Month}");
            Console.WriteLine($"10) Second: {dt.Second}");
            Console.WriteLine($"11) Ticks: {dt.Ticks}");
            Console.WriteLine($"12) TimeOfDay: {dt.TimeOfDay}");
            Console.WriteLine($"13) Year: {dt.Year}");

            Console.WriteLine("----------");

            DateTime dt2 = new DateTime(2001, 8, 5, 13, 45, 58, 275);

            string s1 = dt2.ToString("yyyy-MM-dd HH:mm:ss");
            string s2 = dt2.ToString("yyyy-MM-dd HH:mm:ss.fff");

            Console.WriteLine(dt2.ToLongDateString());
            Console.WriteLine(dt2.ToLongTimeString());
            Console.WriteLine(dt2.ToShortDateString());
            Console.WriteLine(dt2.ToShortTimeString());
            Console.WriteLine(dt2.ToString());
            Console.WriteLine(s1);
            Console.WriteLine(s2);

            Console.WriteLine("----------");

            DateTime dt3 = new DateTime(2001, 8, 5, 13, 45, 58, 275);

            DateTime dt4 = dt3.AddHours(2);
            DateTime dt5 = dt3.AddMinutes(3);
            DateTime dt6 = dt3.AddDays(7);

            TimeSpan ts1 = dt6.Subtract(dt3);

            Console.WriteLine(dt3);
            Console.WriteLine(dt4);
            Console.WriteLine(dt5);
            Console.WriteLine(dt6);
            Console.WriteLine(ts1);

            Console.WriteLine("----------");

            TimeSpan tsp1 = TimeSpan.MaxValue;
            TimeSpan tsp2 = TimeSpan.MinValue;
            TimeSpan tsp3 = TimeSpan.Zero;
            TimeSpan tsp4 = new TimeSpan(2, 3, 5, 7, 11);

            Console.WriteLine(tsp1);
            Console.WriteLine(tsp2);
            Console.WriteLine(tsp3);

            Console.WriteLine($"Days: {tsp4.Days}");
            Console.WriteLine($"Hours: {tsp4.Hours}");
            Console.WriteLine($"Minutes: {tsp4.Minutes}");
            Console.WriteLine($"Milliseconds: {tsp4.Milliseconds}");
            Console.WriteLine($"Seconds: {tsp4.Seconds}");

            Console.WriteLine($"Ticks: {tsp4.Ticks}");
            Console.WriteLine($"TotalDays: {tsp4.TotalDays}");
            Console.WriteLine($"TotalHours: {tsp4.TotalHours}");
            Console.WriteLine($"TotalMinutes: {tsp4.TotalMinutes}");
            Console.WriteLine($"TotalSeconds: {tsp4.TotalSeconds}");
            Console.WriteLine($"TotalMillisenconds: {tsp4.TotalMilliseconds}");

            Console.WriteLine("----------");

            TimeSpan ts2 = new TimeSpan(1, 30, 10);
            TimeSpan ts3 = new TimeSpan(0, 10, 5);

            TimeSpan sum = ts2.Add(ts3);
            TimeSpan dif = ts2.Subtract(ts3);
            TimeSpan mult = ts3.Multiply(2.0);
            TimeSpan div = ts3.Divide(2.0);

            Console.WriteLine(sum);
            Console.WriteLine(dif);
            Console.WriteLine(mult);
            Console.WriteLine(div);

            Console.WriteLine("----------");

            DateTime dtm1 = new DateTime(2000, 8, 15, 13, 5, 58, DateTimeKind.Local);
            DateTime dtm2 = new DateTime(2000, 8, 15, 13, 5, 58, DateTimeKind.Utc);
            DateTime dtm3 = new DateTime(2000, 8, 15, 13, 5, 58);

            Console.WriteLine("dtm1: " + dtm1);
            Console.WriteLine("dtm1 Kind: " + dtm1.Kind);
            Console.WriteLine("dtm1 to Local: " + dtm1.ToLocalTime());
            Console.WriteLine("dtm1 to Utc: " + dtm1.ToUniversalTime());
            Console.WriteLine();
            Console.WriteLine("dtm2: " + dtm2);
            Console.WriteLine("dtm2 Kind: " + dtm2.Kind);
            Console.WriteLine("dtm2 to Local: " + dtm2.ToLocalTime());
            Console.WriteLine("dtm2 to Utc: " + dtm2.ToUniversalTime());
            Console.WriteLine();
            Console.WriteLine("dtm3: " + dtm3);
            Console.WriteLine("dtm3 Kind: " + dtm3.Kind);
            Console.WriteLine("dtm3 to Local: " + dtm3.ToLocalTime());
            Console.WriteLine("dtm3 to Utc: " + dtm3.ToUniversalTime());

            Console.WriteLine("----------");

            DateTime dtm4 = DateTime.Parse("2000-08-15 13:05:58");
            DateTime dtm5 = DateTime.Parse("2000-08-15T13:05:58Z");

            Console.WriteLine(dtm4);
            Console.WriteLine(dtm5);
        }
    }
}
