using System;

namespace lab11
{
    class Program
    {
        static void Main(string[] args)
        {
            var o = new object();
            //manually create and populate an object

            Object o2 = new
            {
                
                name = "bob",
                age = 22
            };

            Console.WriteLine(o2.ToString());

            
        }
    }
}
