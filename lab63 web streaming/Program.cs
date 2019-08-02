using System;
using System.Net;
using System.Diagnostics;
namespace lab63_web_streaming
{
    class Program
    {
        static void Main(string[] args)
        {
            Uri bbcNews01 = new Uri("https://www.bbc.co.uk/news");

           
            var s = new Stopwatch();
            var t = new Stopwatch();


            s.Start();
            GetWebpageSync();
            s.Stop();
            Console.WriteLine(s.ElapsedMilliseconds);

            t.Start();
            AsyncMethod();
            t.Stop();
            Console.WriteLine(t.ElapsedMilliseconds);

        }


        static void GetWebpageSync()
        {
            Uri bbcNews01 = new Uri("https://www.bbc.co.uk/news");

           

            //URI uniform resource indicator
            //URL uniform resource locator


            //download this file
            //var s = new Stopwatch();
            var downloadWebpage01 = new WebClient { Proxy = null };
          //  s.Start();
            downloadWebpage01.DownloadFile(bbcNews01, "bbclocalcachedcopyNews01.html");

            Process.Start(@"C:\Program Files (x86)\Google\Chrome\Application\chrome.exe", "bbclocalcachedcopyNews01.html");
          //  s.Stop();
            //Console.WriteLine(s.ElapsedMilliseconds);
        }
        async static void AsyncMethod()
        {

            Uri bbcNews01 = new Uri("https://www.bbc.co.uk/news");

     

            //URI uniform resource indicator
            //URL uniform resource locator


            //download this file
           // var s = new Stopwatch();
            var downloadWebpage01 = new WebClient { Proxy = null };
           // s.Start();

            await downloadWebpage01.DownloadFileTaskAsync(bbcNews01, "bbclocalcachedcopyNews01.html");

            Process.Start(@"C:\Program Files (x86)\Google\Chrome\Application\chrome.exe", "bbclocalcachedcopyNews01.html");
           // s.Stop();
            //Console.WriteLine(s.ElapsedMilliseconds);
        }

    }
}
