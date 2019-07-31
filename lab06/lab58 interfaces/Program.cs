using System;

namespace lab58_interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            var c = new Child();
            c.Name = "bob";
            c.Property01 = 100;
            c.UseTool01();
            Console.WriteLine(c.DoThat());
        }
    }

    interface IToolShedItem01 {
        //no fields
        //public int Field01;

    //yes properties

        int Property01 { get; set; } //public is present but not stated
        void UseTool01(); // Abstract (also public) - again present but not stated

    }
    interface IToolShedItem02 {

         string Property02 { get; set; }
         string DoThat();

    }
 
    abstract class Parent {
        public string Name { get; set; }
       public abstract void DoThis();
    }
    class Child : Parent, IToolShedItem01, IToolShedItem02 {

      public override void DoThis() //mandatory abstract override
        {

        }

        public int Property01 { get; set; }
        public string Property02 { get; set; }
        public void UseTool01()
        {
            Console.WriteLine("use tool 01");
        }
        public string DoThat() => "shovel";
    }
}
