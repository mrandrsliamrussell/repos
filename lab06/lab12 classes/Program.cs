using System;
using System.Collections.Generic;
namespace lab12_classes
{
    class Program
    {
        static List<Dog> dogs = new List<Dog>();
        static void Main(string[] args)
        {
          

            var m01 = new Mammal();
            m01.height = 100;
            m01.length = 100;
            m01.weight = 2000;

            var d01 = new Dog();
            d01.height = 50;
            d01.length = 200;
            d01.weight = 30;
            d01.dogId = "dog 01";
           // Console.WriteLine($"Dog has height {d01.height} , weight {d01.weight}, and length {d01.length}");

            for(int i=0; i< 20; i++)
            {
                var newdog = new Dog();
                newdog.dogId = $"{i}";
                newdog.height = 50;
                newdog.weight = 50;
                newdog.length = 100;
                dogs.Add(newdog);
                
            }
            foreach( Dog dog in dogs){

                Console.WriteLine($" dog is {dog.dogId.ToString()}, and this long { dog.length}");

                dog.Grow();
            }
        }
    }

    class Dog : Mammal{

        public void Grow()
        {
            age += 1;
        }

    }
    class Cat : Mammal{ }

    class Mammal {
        public int height, weight, length, age;
        public string dogId;

    }
}
