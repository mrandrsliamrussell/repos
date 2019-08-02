using System;

namespace lab60_events_trivial
{
    class Program
    {
        //delegate
        public delegate int Delegate01(string x);
        //event
        public static event Delegate01 Event01;
        static void Main(string[] args)
        {

            //1 declared an event
            //2 declared a restriction on method types (delegate)
            //3 add a method
            Event01 += Method01;
            Event01 += Method02;//no brackets placeholder created but method not called
            Event01("hello world special event");

           
        }
        static int Method01(string input)
        {
            Console.WriteLine("print pls");
            Console.WriteLine(input);
            return input.Length;
        }
        static int Method02(string input)
        {
            Console.WriteLine("print more pls");
            Console.WriteLine(input);
            return input.Length;
        }
    }
}
