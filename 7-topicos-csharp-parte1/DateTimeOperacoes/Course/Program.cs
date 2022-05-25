using System;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime d1 = new DateTime(2001, 8, 15, 13, 45, 58, 275);
            Console.WriteLine(d1);
            Console.WriteLine("1) Date: " + d1.Date);
            Console.WriteLine("2) Day: " + d1.Day);
            Console.WriteLine("3) DayOfWeek: " + d1.DayOfWeek);
            Console.WriteLine("4) DayOfYear: " + d1.DayOfYear);
            Console.WriteLine("5) Hour: " + d1.Hour);
            Console.WriteLine("6) Kind: " + d1.Kind);
            Console.WriteLine("7) Millisecond: " + d1.Millisecond);
            Console.WriteLine("8) Minute: " + d1.Minute);
            Console.WriteLine("9) Month: " + d1.Month);
            Console.WriteLine("10) Second: " + d1.Second);
            Console.WriteLine("11) Ticks: " + d1.Ticks);
            Console.WriteLine("12) TimeOfDay: " + d1.TimeOfDay);
            Console.WriteLine("13) Year: " + d1.Year);

            Console.WriteLine("--------------------------------------");

            // formatação dateTime -> string
            DateTime d2 = new DateTime(2001, 8, 15, 13, 45, 58);
            string s1 = d2.ToLongDateString();
            string s2 = d2.ToLongTimeString();
            string s3 = d2.ToShortDateString();
            string s4 = d2.ToShortTimeString();
            string s5 = d2.ToString();
            string s6 = d2.ToString("yyyy-MM-dd HH:mm:ss");
            string s7 = d2.ToString("yyyy-MM-dd HH:mm:ss.fff");
            Console.WriteLine("1) ToLongDateString: " + s1);
            Console.WriteLine("2) ToLongTimeString: " + s2);
            Console.WriteLine("3) ToShortDateString: " + s3);
            Console.WriteLine("4) ToShortTimeString: " + s4);
            Console.WriteLine("5) ToString: " + s5);
            Console.WriteLine(s6);
            Console.WriteLine(s7);

            Console.WriteLine("--------------------------------------");

            // operações com DateTime
            DateTime x = new DateTime(2022, 05, 08, 12, 0, 0);

            TimeSpan time = new TimeSpan(1, 2, 30, 0); // uma dia, duas horas, 30 minutos
            DateTime y1 = x.Add(time);
            DateTime y2 = x.AddDays(3);
            DateTime y3 = x.AddHours(3);
            DateTime y4 = x.AddMilliseconds(10000);
            DateTime y5 = x.AddMinutes(3);
            DateTime y6 = x.AddMonths(3);
            DateTime y7 = x.AddSeconds(3);
            DateTime y8 = x.AddTicks(10000000L);
            DateTime y9 = x.AddYears(3);
            DateTime y10 = x.Subtract(time);
            TimeSpan t = DateTime.Now.Subtract(x);

            Console.WriteLine(x);
            Console.WriteLine("y1: " + y1);
            Console.WriteLine("y2: " + y2);
            Console.WriteLine("y3: " + y3);
            Console.WriteLine("y4: " + y4);
            Console.WriteLine("y5: " + y5);
            Console.WriteLine("y6: " + y6);
            Console.WriteLine("y7: " + y7);
            Console.WriteLine("y8: " + y8);
            Console.WriteLine("y9: " + y9);
            Console.WriteLine("y10: " + y10);
            Console.WriteLine("t: " + t);

            Console.WriteLine("--------------------------------------");
            Console.WriteLine(new TimeSpan(0, 0, 1).Ticks);
        }
    }
}
