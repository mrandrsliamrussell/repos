using System;

namespace lab22_first_test
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }
    }
    public class LabWork
    {
        public int CubeNumbers(int x, int y, int z)
        {
            return x*y*z;
        }
        public static int CubeNumbersStatic(int x, int y, int z)
        {
            return x * y * z;
        }
        public static int GetLengthOfArray(int[] myArray)
        {
            return myArray.Length;
        }
        public static int SumTotalOfArrayMembers(int[] array)
        {
            int total = 0;
            //return sum of all array menbers
            foreach(int i in array)
            {
                total += i;
            }
            return total;
        }

    }
}
