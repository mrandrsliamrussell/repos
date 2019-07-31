using System;

namespace lab61_events_oop
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             scenario : child will have a birthday
             birthday is the EVENT
             HaveAParty is the Method
             we attach to an OOP instance ie var james = new Child();
             
             
             */
            var James = new Child();
            
         for(int i = 1; i < 10; i++)
            {
                James.Grow();
            }


        }
    }
    class Child
    {
        public delegate int BirthdayDelegate(); //matches HaveAParty() method
        public event BirthdayDelegate OneMoreYearOlder;
        public int Age { get; set; }
        public Child()
        {
            Age = 0;
            Console.WriteLine($"Congratulations on the birth of your new baby Age is {Age}");
            OneMoreYearOlder += HaveAParty; //event is now not null
        }
        public void Grow()
        {
            //call the event
            OneMoreYearOlder();
        }
        public int HaveAParty()
        {
            Age++;

            Console.WriteLine($"celebrating birthday age is now {Age}");

            return Age;
        }

    }


}
