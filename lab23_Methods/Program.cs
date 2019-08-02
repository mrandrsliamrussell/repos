using System;

namespace lab23_Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            var X01 = new X();
            X01.Grow();
            X.ReturnFixedData();

            Console.WriteLine(Math.PI);


           void DoThis(){
                Console.WriteLine("i am doing something");
                    }
           

            DoThis();
            DoThat();
            DoingLots(100, "hi", true);
            DoingLots(c: false, a: 45, b: "hello");
            DoingSomeOtherWork(new DateTime(2019, 05, 11));
            DoingSomeOtherWork(new DateTime(2019, 05, 11), c:'g', f:2.2f, d:233.4444444);
        }
        static void DoThat()
        {
            Console.WriteLine("i am doing something else");
        }


        static void DoingLots(int a, string b, bool c)
        {
            Console.WriteLine($"Doing lots {a},{b},{c}");
        }

        static void DoingSomeOtherWork( DateTime date, float f = 1.2f, char c = 'a', double d = 100.322)
        {
            Console.WriteLine($"{date}, {f}, {c}, {d}");
        }
    }
    class X
    {
        public int Age;
        public void Grow()
        {
            Age++;
        }
        public static string ReturnFixedData()
        {
            return "here is some fixed data";
        }

    }
}
