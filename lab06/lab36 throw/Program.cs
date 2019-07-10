using System;

namespace lab36_throw
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                throw (new Exception("something terrible has happened"));
            }
            catch(Exception e)
            {
                Console.WriteLine(e);
                Console.WriteLine(e.Data);
                Console.WriteLine(e.Message);
            }

            try
            {
                // main code for whole company
                try
                {
                    // code for separtment
                    try
                    {
                        //my code : exception here**************
                        throw new ArithmeticException("your code is bad");
                    }
                    catch
                    {
                        // dont handle here
                        throw;  // throws up to next level
                    }
                }
                catch(Exception e)
                {
                    // yes handle here
                    Console.WriteLine(e.Message);
                }
            }
            catch
            {
                //catching company wide errors
            }
        }
    }
}
