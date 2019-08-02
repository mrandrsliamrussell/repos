using System;

namespace lab26_integers
{
    class Program
    {
        static void Main(string[] args)
        {
            // signed integet can be posative or negative
            short s01; // 16 bits 15 for data one for -/+
            int i01;    //32
            long l01;  //64
           
            Int16 s02;  //16
            Int32 i02;  //32
            Int64 l02; //64


            // unsigned can only be posative
            ushort us01; //unsigned 16 bit
            uint ui01;  // 32
            ulong ul01; //64


            // examples
            Console.WriteLine(short.MaxValue);
            Console.WriteLine(ushort.MaxValue);
            Console.WriteLine(ulong.MaxValue);


            //decimals

            var f = 1.23f;
            Console.WriteLine(f);

            var f02 = 1.45674567456745674567456745674567m;

            Console.WriteLine(f02);

            //use with exponential numbers
            Console.WriteLine(double.MaxValue);
            // use with high signifacant figures/ highest presision e.g money
            Console.WriteLine(decimal.MaxValue);
            Console.WriteLine(float.MaxValue);
            // care when equating decimal numbers
            var d01 = 0.1m;
            var d02 = 0.2m;
            Console.WriteLine(d01 + d02 == 0.3m);
            var d03 = 0.1;
            var d04 = 0.2;
            Console.WriteLine(d03 + d04 == 0.3);
            // test less than small number
            Console.WriteLine(d03 + d04 - 0.3 < 0.00000001);
        }
    }
}
