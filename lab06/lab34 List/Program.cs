using System;
using System.Collections.Generic;
namespace lab34_List
{
    class Program
    {
        static List<int> list01 = new List<int>();
        static List<string> list02 = new List<string>();
        static void Main(string[] args)
        {

            List<String> list03 = new List<string>();
            // arrays are fixed
            int[] array01 = new int[10]; //size fixed
            int[,] grid2D = new int[10, 10];
            int[,,] grid3D = new int[10, 10, 10];
            int[,,,] grid4D = new int[10, 10, 10, 10];

            //jagged array
            //its possible to create an array of arrays where each array can be of a different size

            int[][] jaggedArray = new int[3][];
            //first array size 10
            jaggedArray[0] = new int[10];
            //second at size 100
            jaggedArray[1] = new int[100];

            list01.Add(10);
            list01.Add(20);
            list01.Insert(0, 100);
            

            foreach(var i in list01)
            {
                Console.WriteLine(i);
            }
            list01.RemoveAt(0);
            foreach (var i in list01)
            {
                Console.WriteLine(i);
            }

            list02.Add("it ");
            list02.Add("aint ");
            list02.Add("easy ");
            list02.Add("being ");
            list02.Add("cheesy");
            list02.Insert(4, "depressed");

            foreach (var i in list02)
            {
                Console.WriteLine(i);
            }
            //FOREACH block used quite often

            var dictionary01 = new Dictionary<int, string>();

            dictionary01.Add(10, "hi");
            dictionary01.Add(20, "there");
            dictionary01.Add(30, "spartans");
            dictionary01.TryAdd(30, "spartans2");

            //ITERATE loop over dictionary

            foreach (var key in dictionary01.Keys)
            {
                Console.WriteLine($"Key {key,-15} Value {dictionary01[key]}");
            }

            //queue

            var queue = new Queue<int>();
            queue.Enqueue(10); // add first item
            queue.Enqueue(20); // add second item
            queue.Enqueue(30); // add third item
            //.............................30........20.........10.....BUS STOP

            var firstitemonbus  = queue.Dequeue(); //first item get on bus

            // ...............................30..........20.......BUS STOP

            Console.WriteLine(firstitemonbus);

            Console.WriteLine($"queue contains number 50? {queue.Contains(50)}");
            Console.WriteLine($"queue contains number 20? {queue.Contains(20)}");
            Console.WriteLine($"check out who is first in line {queue.Peek()}");

            foreach(var v in queue)
            {
                Console.WriteLine(v);
            }
            //stack
            var stack = new Stack<string>();

            //LIFO last in first out
            //think of a rugby scrum or pack of cards

            stack.Push("first");
            stack.Push("second");
            stack.Push("third");

            foreach(var v in stack)
            {
                Console.WriteLine(v);
            }
            stack.Pop();
            foreach (var v in stack)
            {
                Console.WriteLine(v);
            }

            Console.WriteLine(stack.Contains("first"));
            Console.WriteLine(stack.Peek());


            int[] numArray = new int[4];
            numArray[0] = 10;
            numArray[1] = 20;
            numArray[2] = 30;
            numArray[3] = 40;

            List<int> intList = new List<int>();
            var intQueue = new Queue<int>();
            var intStack = new Stack<int>();
            int sum = 0;
            foreach(int i in numArray)
            {
                intList.Add(i * 10);
                sum += i;
                
            }
            Console.WriteLine(sum);
            sum = 0;

            foreach (int i in intList)
            {
                intQueue.Enqueue(i + 1);
                sum += i;
                
            }
            Console.WriteLine(sum);
            sum = 0;

            foreach (int i in intQueue)
            {
                intStack.Push(i + 2);
                sum += i;
            }
            Console.WriteLine(sum);
            sum = 0;
            foreach (int i in intStack)
            {
                sum += i;
            }
            Console.WriteLine(sum);


        }

        void DoThat()
        {
            list01.Add(10);
            list02.Add("hi");
            
        }
    }
     class DoThis
    {

    }
}
