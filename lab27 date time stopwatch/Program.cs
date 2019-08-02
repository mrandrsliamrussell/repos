using System;

namespace lab27_date_time_stopwatch
{
    class Program
    {
        static void Main(string[] args)
        {
            // times

            var time01 = DateTime.Now;

            Console.WriteLine(time01.ToLongTimeString());

            // add units of time

            Console.WriteLine(time01.AddDays(2));
            Console.WriteLine(time01.AddSeconds(2));
            Console.WriteLine(time01.AddMilliseconds(500000).ToLocalTime());
            Console.WriteLine(time01.AddTicks(900000000000000));

            // measure time
            //lets count to 1 million and measure the time

            var s = new System.Diagnostics.Stopwatch();

            s.Start();
            
            while(s.ElapsedMilliseconds < 10000)
            {
                Console.WriteLine(s.ElapsedMilliseconds);
            }

            s.Stop();

            Console.WriteLine(s.ElapsedMilliseconds);
            Console.WriteLine(s.ElapsedTicks);

        }
    }
}
