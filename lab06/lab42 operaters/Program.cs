using System;
using System.Linq;
namespace lab42_operaters
{
    class Program
    {
        static void Main(string[] args)
        {

            int x,y,z, w;
            x = 10;
            w = 10;
            y = x++;
            z = ++w;


            Console.WriteLine(y);
            Console.WriteLine(z);


            //binary
            //modulus %
            // divide / 
            // and &&

            //high if only both inputs are high
            Console.WriteLine(1 & 1);
            Console.WriteLine(1 & 0);
            Console.WriteLine(0 & 1);
            Console.WriteLine(0 & 0);
            // | or statement fine if one is high
            Console.WriteLine(1 | 1);
            Console.WriteLine(0 | 0);
            Console.WriteLine(0 | 1);
            Console.WriteLine(1 | 0);
            // ^ XOR
            Console.WriteLine(1 ^ 1);
            Console.WriteLine(1 ^ 0);
            Console.WriteLine(0 ^ 1);
            Console.WriteLine(0 ^ 0);
            // bit shift
            // >>
            Console.WriteLine(8 >> 2);
            Console.WriteLine(8 << 2);
            Console.WriteLine(8 >> 2);

            //ternary operator
            int num04 = 100;
            int num05 = 1000;

            if(num04 < num05)
            {
                //do this
            }
            else
            {
                //do that
            }
            //ternary
            var output = (num04 < num05) ? "if true" : "if false";

            Console.WriteLine(output);

            //Lambda operator

            int[] myArray = { 1, 2, 3, 4 ,5, 6 };

            var outputArray = myArray.Where(item => item > 2);

            foreach(var v in outputArray)
            {
                Console.WriteLine(v);
            }
            int?[] myArray2 = { null, 2, 3, null, 5, 6, null, 8 };

            var outputArray2 = myArray.Where(item => item > 2);
            foreach (var v in outputArray2)
            {
                Console.WriteLine(v);
            }

        }
    }
}
