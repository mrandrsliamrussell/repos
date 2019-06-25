using System;

namespace lab13_methods
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var d01 = new dog();
            d01.name = "doggo";
            d01.age = 20;

            for (int i = 1; i <= 15; i++){
                d01.shrink();
                Console.WriteLine(d01.age.ToString());
            }

            
        }
    }
    class dog{
        public string name;
        public int age;

       public void grow()
        {
            age++;
        }
        public void shrink()
        {
            age--;
        }
        }
}
