using System;
using System.Collections.Generic;
using System.Linq;
namespace Eng_35_Tests
{
    public class Eng35Tests
    {
        static void Main()
        {
            string string01 = "why what a lovely array of words you have here";

            // Console.WriteLine(CreateArrayFromSentence(string01));
            // Console.WriteLine(GetWordsFromSentence(string01));
            GenerateArray();
        }




        //pass in sentence and return array of individual words
        public static string[] CreateArrayFromSentence(string inputString)
        {
            string[] words = inputString.Split(' ');
            return new string[]
            {

            };

        }
        //pass in sentence and return number of words
        public static int GetWordsFromSentence(string inputString)
        {
            int wordCount = 0;
            string[] words = inputString.Split(' ');
            foreach (var word in words)
            {
                wordCount++;
            }
            return wordCount;
        }
        // "this is a sentence" returns "This Is A Sentence"
        public static string TurnFirstWordToUpperCase(string inputString)
        {

            string[] words = inputString.Split(' ');
            foreach (var word in words)
            {
                foreach (char c in word)
                {
                    if (c == word[0])
                    {
                        c.ToString().ToUpper();
                    }

                }
            }

            return "";
        }
        // "this is a sentence" returns "THIS is a sentence"
        public static string TurnAllWordsToUppercaseButLastWordToLowercase(string inputString)
        {
            return "";
        }
        // "this is a sentence" returns "THIS IS A SENTENCE"


        /* pass in array of 10 numbers
         * while loop ==> add one to each number
         * do while loop ==> add 3 to each number
         * foreach loop ==> double each number*/
        public static void GenerateArray()
        {

            int[] numbers = new int[] { 10, 11, 12, 13, 14, 15, 16, 17, 18, 19 };



            Mega_Multiple_Coding_Loops(numbers);
        }





        public static int Mega_Multiple_Coding_Loops(int[] myArray)
        {
            int i = 0;
            while (i < 10) {

                myArray[i] += 1;
                i++;
            }
            i = 0;

            do
            {

                myArray[i] += 3;
                i += 1;
            }
            while (i < 10);
            i = 0;


            foreach (int v in myArray)
            {
                myArray[i] *= 2;
                i++;
            }
            i = 0;

            List<Cat> listOfCats = new List<Cat>();

            foreach (var v in myArray)
            {
                Cat newcat = new Cat("cat " + v.ToString(), v);


                listOfCats.Add(newcat);


            }

            int totalofallcats = 0;
            foreach (Cat c in listOfCats)
            {
                Console.WriteLine($"cat name is {c.catName} and cat age is {c.catAge}");
                totalofallcats += c.catAge;

            }
            Console.WriteLine(totalofallcats);



            return totalofallcats;
        }


        public static int SumOfArray(int[] myArray)
        {

            var newArray = Enumerable.Range(1, 20).ToArray();

            int total = 0;
            foreach (var v in myArray)
            {
                total += v;
            }

            return total;
        }
        public static double MultiplyNumbers(double x, double y, double n)
        {
            double answer = 0;

            answer = Math.Pow(x * y, n);

            return answer;
        }

        public static int[] SortArray(int[] myArray)
        {

            Array.Sort(myArray);
            
            
            return myArray;
        }

        public static Cat[] SortCat(Cat[] myCats)
        {
            Cat tempCat;
            for(int i = 0; i < myCats.Length; i++)
            {
                if(myCats[i+1] != null)
                {
                    if(myCats[i].catAge > myCats[i + 1].catAge)
                    {
                        tempCat = myCats[i];
                        myCats[i] = myCats[i + 1];
                        myCats[i + 1] = tempCat;

                    }
                }
            }

            return myCats;
        }
        public static int HowManyNumbersDivisableBy(int start, int end, int diviser)
        {
            int result = 0;

            for(int i = start; i <= end; i++)
            {
                if(i % diviser == 0)
                {
                    result++;
                }
            }

            return result;
        }

        public static int ArrayLoopQueueStack(int[] array)
        {
            int[] numArray = new int[4];
            numArray[0] = 10;
            numArray[1] = 20;
            numArray[2] = 30;
            numArray[3] = 40;

            List<int> intList = new List<int>();
            var intQueue = new Queue<int>();
            var intStack = new Stack<int>();
            int sum = 0;
            foreach (int i in numArray)
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
            return sum;


        }
    

    }

    public class Cat
    {
        public string catName { get; set; }

        public int catAge { get; set; }

        public Cat(string name, int age)
        {
            this.catName = name;
            this.catAge = age;
        }
    }


    

}
