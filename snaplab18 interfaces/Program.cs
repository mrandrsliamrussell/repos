using System;

namespace snaplab18_interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            var dog1 = new Dog();
            var dog2 = new Dog();
            var dog3 = new Dog();

            dog1.Height = 300;
            dog2.Height = 800;
            dog3.Height = 150;

            Dog[] dogArray = new Dog[3] { dog1, dog2, dog3 };

            Dog dogholder;
            // Console.WriteLine(dog1.CompareTo(dog3));
            for (int j = 0; j < dogArray.Length; j++)
            {
                for (int i = 0; i < dogArray.Length - 1; i++)
                {


                    if (dogArray[i].CompareTo(dogArray[i + 1]) == 1)
                    {
                        dogholder = dogArray[i + 1];
                        dogArray[i + 1] = dogArray[i];
                        dogArray[i] = dogholder;
                    }




                }

            }

            foreach (var d in dogArray)
            {
                Console.WriteLine(d.Height);
            }

        }
    }


    class Dog : IComparable
    {

        public int Height { get; set; }
        public int CompareTo(object o)
        {
            Dog d = (Dog)o;
            if (this.Height < d.Height) return -1;
            if (this.Height == d.Height) return 0;
            return 1;

        }
    }
    public class SortDogs
    {
        void sortDogs()
        {
            Dog dog1 = new Dog();
            Dog dog2 = new Dog();
            Dog dog3 = new Dog();

            dog1.Height = 300;
            dog2.Height = 800;
            dog3.Height = 150;

            Dog[] dogArray = new Dog[3] { dog1, dog2, dog3 };

            Dog dogholder;
            // Console.WriteLine(dog1.CompareTo(dog3));
            for (int j = 0; j < dogArray.Length; j++)
            {
                for (int i = 0; i < dogArray.Length - 1; i++)
                {
                    if (dogArray[i].CompareTo(dogArray[i + 1]) == 1)
                    {
                        dogholder = dogArray[i + 1];
                        dogArray[i + 1] = dogArray[i];
                        dogArray[i] = dogholder;
                    }

                }

            }

            foreach (var d in dogArray)
            {
                Console.WriteLine(d.Height);
            }

        }

    }
}
