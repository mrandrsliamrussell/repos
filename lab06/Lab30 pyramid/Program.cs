using System;
using System.Collections.Generic;
namespace Lab30_pyramid
{
    class Program
    {

         
        static void Main(string[] args)
        {
            List<string> pyramid = new List<string>();
            int pyramidSize = 60;
            pyramidSize++;
            for (int i = 0; i < pyramidSize; i++)
            {
                pyramid.Add("");
                for (int j = pyramidSize; j > i; j--)
                {
                    pyramid[i] += " ";
                }
                
                for (int j = 0; j < i; j++)
                {

                    pyramid[i] += " *";
                    
                    
                }
                Console.WriteLine(pyramid[i].ToString());
            }
        }
    }
}
