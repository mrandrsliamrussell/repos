using System;

namespace lab25_strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string s01 = "hi there";

            foreach (var c in s01)
            {
                Console.WriteLine(c);
            }
            Console.WriteLine($"fifth letter is {s01[4]}");

            // parsing to integer
            int num01 = int.Parse("1234");
            Console.WriteLine($"type of num is {num01.GetType()}");
            //dont use parse because it will throw an exception and crash your computer
            try
            {
                int num02 = int.Parse("1234 text");
                Console.WriteLine(num02);
                int num03 = int.Parse("text text");
                Console.WriteLine(num03);
                int num04 = int.Parse("text");
                Console.WriteLine(num04);
            }
            catch (Exception e)
            {
                Console.WriteLine("dont use pass");
                Console.WriteLine(e);
            }
            finally
            {
                Console.WriteLine("back to normal");
            }
            int.TryParse("123abc", out int output01);
            Console.WriteLine(output01);
            int.TryParse("abc123", out int output02);
            Console.WriteLine(output02);
            int.TryParse("123", out int output03);
            Console.WriteLine(output03);

            // string.format and string interpolation
            double d01 = 1.234;

            Console.WriteLine(string.Format("{0,10:N0}", d01));
            Console.WriteLine(string.Format("{0,10:N1}", d01));
            Console.WriteLine(string.Format("{0,10:N2}", d01));

            Console.WriteLine($"{d01,10:N0}");
            Console.WriteLine($"{d01,10:N1}");
            Console.WriteLine($"{d01,10:N2}");

            //column width
            Console.WriteLine($"{d01,10:N3}{d01,10:N3}{d01,10:N3}");


            //currency

            Console.WriteLine($"{d01,10:N3}{d01,10:N3}{d01,10:N3}{d01, 10:C}");


        string s05 ="this is a pretty long string now that i think about it";
            string[] words = s05.Split(' ');
            foreach(var word in words)
            {
                Console.WriteLine(word);
            }

            string s06;
            s06 = string.Join(' ', words);
            Console.WriteLine(s06);

            /*multi line comment
             * 
             */

           s06 = string.Concat(s06, "hey whats up");
            Console.WriteLine(s06);

            string s07 = " i have a banana";

            

            Console.WriteLine(s07.Replace("banana", "headache"));

        }
    }
}
