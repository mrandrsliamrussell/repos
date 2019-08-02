using System;
using System.IO;
using System.Diagnostics;
using System.Text;


namespace lab62_streaming
{
    class Program
    {
 
        static void Main(string[] args)
        {
            var s = new Stopwatch();
            var builder = new StringBuilder();
            s.Start();
            // stream to write a file
            using (var writer = new StreamWriter("output.txt"))
            {

                for (int i = 0; i < 10000; i++)
                {
                    writer.WriteLine($"Line {i} - adding some text {DateTime.Now}");
                }
                s.Stop();
                writer.WriteLine(s.ElapsedTicks);
            writer.Close();
                //see if string builder is quicker

               

            }
            using(var writer = new StreamWriter("output2.txt"))
            {
                var t = new Stopwatch();
                t.Start();
                for (int i = 0; i < 10000; i++)
                {
                    builder.AppendLine($"Line {i} - adding some text {DateTime.Now}");
                    
                }
                writer.Write(builder);
                t.Stop();
                writer.WriteLine(t.ElapsedTicks);
                writer.Close();

            }
            string nextline;
            var builder2 = new StringBuilder();
            var u = new Stopwatch();
                u.Start();
            using(var reader = new StreamReader("output.txt"))
            {
                while((nextline=reader.ReadLine()) != null)
                {
                    builder2.AppendLine(nextline);
                }
            }
           
            Console.WriteLine(u.ElapsedTicks);
            Console.ReadKey();
            Console.WriteLine(builder2);
            Console.WriteLine(u.ElapsedTicks);
            u.Stop();

            //streaming to memory
            //use a pointer which is a reference to an address in memory

            var data = "here is some data to encrypt";
            using (var memorystream = new MemoryStream())
            {
                var buffer = new byte[100];

               for(int i = 0; i< data.ToCharArray().Length; i++)
                {
                    buffer[i] = (int)data.ToCharArray().GetValue(i).t;
                }
                memorystream.Write(buffer);
                //write data to memory
                
            }



        }
    }
}
