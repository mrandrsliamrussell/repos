using System;

namespace lab29_variables
{
    class Program
    {
        static void Main(string[] args)
        {
            byte b01 = 0;
            byte b02 = 255;
            byte b03 = 0b_0101_0101;  // binary lioteral
            byte b04 = 0x_FF;
            byte b05 = 0x_0C;       // hex literal

            Console.WriteLine(b05);

            // buffer
            // youtube vid is split into timy parts
            //each part is the sixe of a buffer

            // buffer is an array of bites
            byte[] myBuffer = new byte[4000]; // chunk size for sending video

            //char
            //ascii : first computers maps a number to every character
            //h is 104 H is 72
            char char01 = 'c';
            char char02 = 'd';

            Console.WriteLine((int)char01);

            const int num10 = 10;

            //  num10 = 100;   cannot change because constant

            var num01 = 10;
            var num02 = "hi";

            //alias

            string x = "hi";  //use this
            String y = "there"; //string is class dont use

            //readonly : use in preference to const
            // const will change value to literal
            // readonly will preserve as a variable


            //null check

            //null coalesce

            //tuples
            void DoThis()
            {

            }

            int DoThat()
            { return -1;

            }

            void DoingSomething(out int result, out string result2)
            {
                result = -1;
                result2 = "hi";
            }

            //tuple is an anonymous type
            // declare
            (string x01, int y01, bool z01) DoingSomethingElse()
            {
                return ("hi", 10, false);
            }

            //call
            var output = DoingSomethingElse();

            //get individual items
            Console.WriteLine($"{output.z01}");
        }
    }
}
