using System;

namespace lab44_crash_your_computer
{
    class Program
    {
        public static int[] i = new int[5];
        static void Main(string[] args)
        {
            try
            {
                i[7] = 50;

            }
            catch(NullReferenceException e)
            {
                Console.WriteLine("Null Reference exception");
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine("out of range");
            }
            catch (Exception e)
            {
                Console.WriteLine("general exception");
            }
           
            
        }
        static void RecurseYouuuuu()
        {
           
        }
    }

}
