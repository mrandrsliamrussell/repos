using System;

namespace snap_lab_6
{
    class Program
    {
        static void Main(string[] args)
        {
            
            
        }
       
    }
    public static class snapLab6
    {
        static void Print()
        {
            Console.WriteLine(SubarraySum(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 }, 8));
        }
    
        public static int SubarraySum(int[] nums, int k)
        {
            int match = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                int count = 0;

                for (int j = i; j < nums.Length; j++)
                {
                    count += nums[j];

                    if (count == k)
                    {
                        match++;
                    }
                    if (count > k)
                    {
                        break;
                    }
                }
            }
            return match;
        }
    }
}
