using System;

namespace lab19_polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            var p = new Parent();
            p.ThrowAParty();
            var c01 = new Child01();
            c01.ThrowAParty();
            var c02 = new Child02();
            c02.ThrowAParty();
        }
    }
    public class Parent
    {
        public virtual void ThrowAParty()
        {
            Console.WriteLine("parent is throwing a post dinner party only for base classes");
        }
    }
    public class Child01 : Parent
    {
       public override void ThrowAParty() 
        {
            Console.WriteLine("have fun with kids in the pool");
        }
    }
    public class Child02 : Parent
    {
        public override void ThrowAParty()
        {
            Console.WriteLine("being moody");
        }
    }
}
