using System;

namespace lab49_reference_value_type
{
    class Program
    {
        static void Main(string[] args)
        {
            //value types
            int x = 5;
            int y = x;
             y = 100;

            Console.WriteLine($"X is {x} Y IS {y}");

            int[] arrayA = new int[] { 10, 20, 30 };
            int[] arrayB = arrayA;

            //before
            Array.ForEach(arrayA, item => Console.WriteLine(item));
            Array.ForEach(arrayB, item => Console.WriteLine(item));


            arrayB[1] += 6;
            //after
            Array.ForEach(arrayA, item => Console.WriteLine(item));
            Array.ForEach(arrayB, item => Console.WriteLine(item));

            int[] arrayC = (int[])arrayA.Clone();

            arrayC[2] += 9;
            Array.ForEach(arrayA, item => Console.WriteLine(item));
            Array.ForEach(arrayB, item => Console.WriteLine(item));
            Array.ForEach(arrayC, item => Console.WriteLine(item));

        }
    }
}
