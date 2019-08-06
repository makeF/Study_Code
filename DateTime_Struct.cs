using System;

namespace TestConsole
{
    
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dt1 = DateTime.Now;
            DateTime dt2 = Convert.ToDateTime("1999-02-02");

            TimeSpan t = dt1 - dt2;

            Console.WriteLine("出生到现在有{0}小时。",t.TotalHours);
        }

    }
}
