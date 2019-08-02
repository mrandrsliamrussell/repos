using System;
using System.IO;
using System.Diagnostics;
using System.Text;
namespace lab50_Async
{
    class Program
    {
        static void Main(string[] args)
        {
            var counter = 0;
            // create a big text file
            // use streamwriter to write to a string as a stream to a like
            using (var writer = new StreamWriter("data.dat"))
            {
                
                for (int i = 0; i < 1000000; i++)
                {
                    writer.WriteLine($"{i,-5} new line {DateTime.Now}");
                   
                }
                Console.WriteLine("hi");
            }

            ReadDataAsync();
            ReadSync();
            while(true){
                System.Threading.Thread.Sleep(400);
                Console.WriteLine("main loop working");
            }
        }
        static void ReadSync()
        {
            var s = new Stopwatch();
            s.Start();
            //using can encapsulate a method which is reaching outside of the clean c# runtime
            //in this case were reading a file from windows / SQL database
            //will auto close the file

            //string builder can be used to construct a string from a lot of little inputs
            var stringbuilder = new StringBuilder();
            string longstring = "";
            using (var reader = new StreamReader("data.dat"))
            {
                while (!reader.EndOfStream)
                {
                    //longstring += reader.ReadLine();
                    stringbuilder.Append(reader.ReadLine());
                }
            }
            s.Stop();
            Console.WriteLine(s.ElapsedMilliseconds);
         
        }
        static async void ReadDataAsync()
        {
            var stringbuilder = new StringBuilder();
            var s = new Stopwatch();
            s.Start();

            string line = null;
            using (var reader = new StreamReader("data.dat"))
            {
                while(true){
                    line = await reader.ReadLineAsync();
                    if (line == null) break;
                    stringbuilder.Append(line);
                }
            }
            s.Stop();
            Console.WriteLine(s.ElapsedMilliseconds + "async");
           
        }
    }
}
