using System;

namespace lab40_loops
{
    class Program
    {
        static void Main(string[] args)
        {
            //for
            //when you need an index and when you need to iterate in a certain direction or by a certain amount
            //foreach
            //when you dont need an index
            //while
            //when you want to check a condition before doing a loop
            //do while
            // when you want to do something then check a condition

            //break : useful when looking for one item only and looping until finding this item
            string[] items = new string[] { "first", "second", "third" };

            foreach (var item in items)
            {
                if(item == "second")
                {
                    break;
                }
                Console.WriteLine("items before break point " + item);
            }

            //continue
            foreach (var item in items)
            {
                if (item == "second")
                {
                    continue;
                }
                Console.WriteLine("items before break point " + item);
            }


            //throw
            // create a loop but manually throw excveption if certain condition reached
            //return
            //use return to save lots of if/e;se conditions

            var output = DoThis(10);

            int DoThis(int inputNumber)
            {
                if(inputNumber == 5)
                {
                    return -100;
                }
                return -4;
            }
        }
      
    }
}
