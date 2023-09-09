internal class Program
{
    public static void Main(string[] args)
    {
        //DateTime Methods
        Console.WriteLine("DateTime Methods");

        Console.WriteLine(DateTime.Now);
        Console.WriteLine(DateTime.Now.Date);
        Console.WriteLine(DateTime.Now.Year);
        Console.WriteLine(DateTime.Now.Month);
        Console.WriteLine(DateTime.Now.Day);      
        Console.WriteLine(DateTime.Now.Hour);
        Console.WriteLine(DateTime.Now.Minute);
        Console.WriteLine(DateTime.Now.Second);

        Console.WriteLine(DateTime.Now.DayOfWeek);
        Console.WriteLine(DateTime.Now.DayOfYear);

        Console.WriteLine(DateTime.Now.ToLongDateString());
        Console.WriteLine(DateTime.Now.ToShortDateString());
        Console.WriteLine(DateTime.Now.ToLongTimeString());
        Console.WriteLine(DateTime.Now.ToShortTimeString());

        Console.WriteLine(DateTime.Now.AddDays(3));
        Console.WriteLine(DateTime.Now.AddHours(2));
        Console.WriteLine(DateTime.Now.AddSeconds(20));
        Console.WriteLine(DateTime.Now.AddMonths(5));
        Console.WriteLine(DateTime.Now.AddYears(20));
        Console.WriteLine(DateTime.Now.AddMilliseconds(60));

        //DateTime Format
        Console.WriteLine(DateTime.Now.ToString("dd"));
        Console.WriteLine(DateTime.Now.ToString("ddd"));
        Console.WriteLine(DateTime.Now.ToString("dddd"));

        Console.WriteLine(DateTime.Now.ToString("MM"));
        Console.WriteLine(DateTime.Now.ToString("MMM"));
        Console.WriteLine(DateTime.Now.ToString("MMMM"));

        Console.WriteLine(DateTime.Now.ToString("yy"));
        Console.WriteLine(DateTime.Now.ToString("yyyy"));

        //Math Kutuphanesi
        Console.WriteLine("Math Kutuphanesi");
        
        Console.WriteLine(Math.Abs(-250));
        Console.WriteLine(Math.Sin(0));
        Console.WriteLine(Math.Cos(0));
        Console.WriteLine(Math.Tan(0));

        Console.WriteLine(Math.Ceiling(24.7));
        Console.WriteLine(Math.Round(24.7));
        Console.WriteLine(Math.Floor(24.7));

        Console.WriteLine(Math.Max(32,27));
        Console.WriteLine(Math.Min(32,27));

        Console.WriteLine(Math.Pow(2,7));
        Console.WriteLine(Math.Sqrt(36));
        Console.WriteLine(Math.Log(9));
        Console.WriteLine(Math.Exp(3));
        Console.WriteLine(Math.Log10(10));

        
        


    }
}