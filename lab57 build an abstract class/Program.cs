using System;

namespace lab57_build_an_abstract_class
{
    class Program
    {
        static void Main(string[] args)
        {
            var newHoliday = new Eurodisney();
            Console.WriteLine(newHoliday.IsMickyMouseWatchingMe());

            Console.WriteLine(newHoliday.OhJeezGoof());
            
        }
    }

    public abstract class DisneyLand
    {

       abstract public bool IsMickyMouseWatchingMe();

        public string OhJeezGoof()
        {
            return "A Hyuk Hyuk Hyuk";
        }

    }

    public class Eurodisney : DisneyLand
    {
       public override bool IsMickyMouseWatchingMe()
        {
            return true;
        }

       

    }
    
}
