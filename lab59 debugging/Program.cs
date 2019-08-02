using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.IO;

namespace lab59_debugging
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int i = 0; i< 10; i++)
            {
                Console.WriteLine(i);
                Debug.WriteLine($"debigging: i is {i}");
                Trace.WriteLine($"trace to output window is {i}");

                File.AppendAllText("C:\\Log\\output.txt",$"logging to text file{DateTime.Now} i has value {i}\n\n");
                File.AppendAllText("C:\\Users\\LRussell\\Documents\\output.txt", $"logging to text file{DateTime.Now} i has value {i}\n\n");
                File.AppendAllText(@"C:\Users\LRussell\Documents\output2.txt", $"logging to text file{DateTime.Now} i has value {i}\n\n");
                File.AppendAllText($"{System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)}\\output3.txt", $"logging to text file{DateTime.Now} i has value {i}\n\n");
                File.AppendAllText("output.txt",$"logging to text file{DateTime.Now} i has value {i}\n\n");

                EventLog.WriteEntry("Application", "U have b33n h4xed by 4chan m8 git rekt", EventLogEntryType.Information, 5678, 123);
            }


            for( int j = 0; j < 10; j++)
            {
                Console.WriteLine($"j has value {j}");
            }


            Console.Read();
        }
    }
}
