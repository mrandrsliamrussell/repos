using System;
using System.Collections.Generic;

namespace lab16_rabbits
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Rabbit> rabbits = new List<Rabbit>();
            Console.WriteLine("Hello World!");
            
            
            
            for (int i = 1; i <= 100; i++)
            {
                Console.Clear();
                Rabbit newrabbit = new Rabbit(0, "");
                newrabbit.name += i.ToString();
                rabbits.Add(newrabbit);
                for(int j = 0; j<i; j++)
                {
                    rabbits[j].age += 1;
                    Console.WriteLine($"{rabbits[j].name, -10} is {rabbits[j].age, -10} ");
                }
                System.Threading.Thread.Sleep(2000);
            }
            foreach(Rabbit r in rabbits)
            {
              //  Console.WriteLine($"{r.name} is {r.age}  years old");
               // System.Threading.Thread.Sleep(200);
            }
        }
    }
     public class Rabbit {
        public int age { get; set; }
        public string name { get; set; }

        public Rabbit(int age, string counter)
        {
            this.age = 0;
            this.name = $"Rabbit {counter}";
        }

       }
}
