using System;

namespace lab28_Enum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Fruit.apple);
            Console.WriteLine(Fruit.banana);
            Console.WriteLine(Fruit.pear);

            Console.WriteLine((int)Fruit.apple);
            Console.WriteLine((int)Fruit.count);

            //use with days of week and months of year

            // 0 = sunday -> saturday = 6
            // jan = 1 -> dec = 12

            var d = DateTime.Now;
            Console.WriteLine(d);
            Console.WriteLine(d.Month);
            Console.WriteLine(d.Day);
            Console.WriteLine((int)d.DayOfWeek);
            Console.WriteLine(d.DayOfWeek);
        }
        
    }


  
    enum Fruit{

       notfruit = -1, banana,apple,pear, count

    }
}
