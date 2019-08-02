using System;

namespace lab18_method_overloading
{
    class Program
    {
        static void Main(string[] args)
        {
            var r = new Rabbit();
            r.Age = 0;
            for(int i = 0; i<10; i++)
            {
                r.Grow();
                Console.WriteLine(r.Age);
            }
            Console.WriteLine("\n\nHey it's summer now - growth rate has increased \n\n");
            for (int i = 0; i < 10; i++)
            {
                r.Grow(2);
                Console.WriteLine(r.Age);
            }
            Console.WriteLine("\n\nHey it's winter now - growth rate has decreased \n\n");
            for (int i = 0; i < 10; i++)
            {
                r.Grow(0.1);
                Console.WriteLine(r.Age);
            }
            var s = new SubRabbit();
            Console.WriteLine("\n\n subrabbits taking over\n\n");
            for (int i = 0; i < 10; i++)
            {
               // s.Grow();
               // Console.WriteLine(s.Age);
                s.HereIsACustomField = "Hey, i'm changing the subrabbit";
            }
        }
    }
   sealed class Rabbit
    {
        public double Age { get; set; }
        public void Grow()
        {
            Age++;
        }
        public void Grow(int growthFactor)
        {
            Age += growthFactor;
        }
        public void Grow(double wintergrowthFactor)
        {
            Age += wintergrowthFactor;
        }

    }

    class SubRabbit 
    {
        public string HereIsACustomField;
    }
}
