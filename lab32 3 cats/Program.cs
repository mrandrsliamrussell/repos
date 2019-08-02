using System;

namespace lab32_3_cats
{
    class Program
    {
        static void Main(string[] args)
        {
            Cat[] catArray = new Cat[3];
            catArray[0] = new Cat("bob", 3);
            catArray[1] = new Cat("sam", 5);
            catArray[2] = new Cat("jeff", 4);
        }
    }
    class Cat
    {
        public Cat(string name, int age)
        {
            string catName = name;
            int catAge = age;

        }
    }
}
