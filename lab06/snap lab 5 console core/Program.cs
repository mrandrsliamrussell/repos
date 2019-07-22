using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;
namespace snap_lab_5_console_core
{
    class Program
    {      
        static void Main(string[] args)
        {
            Rabbits.rabbits();

        }
    }
    public class Rabbits
    {
        static int seconds = 0;
        static int rabbitCount = 1;
        static int foxCount = 1;
         public static int rabbits()
        {
            File.Delete("output.csv");

            File.AppendAllText("output.csv", "seconds, Rabbit Population, Fox Population");
            while (rabbitCount < 100000000)
            {
                seconds++;
                rabbitCount = rabbitCount << 1;
                if(seconds > 4)
                {
                    rabbitCount -= foxCount;
                    foxCount = foxCount << 1;
                    File.AppendAllText("output.csv",$"\n{seconds},{rabbitCount},{foxCount}");
                }
               
                Console.WriteLine(rabbitCount);
               
            }
           
            Console.WriteLine(seconds);
            return seconds;
            
        }
            

        
    }
    
}
