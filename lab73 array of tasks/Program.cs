using System;
using System.Threading.Tasks;
using System.Threading;
namespace lab73_array_of_tasks
{
    class Program
    {
        static void Main(string[] args)
        {
            var taskArray = new Task[3];
            taskArray[0] = Task.Run(() => { Console.WriteLine("running task 1"); Thread.Sleep(5433); Console.WriteLine("finished task 1"); });
            taskArray[1] = Task.Run(() => { Console.WriteLine("running task 2"); Thread.Sleep(2233); Console.WriteLine("finished task 2"); });
            taskArray[2] = Task.Run(() => { Console.WriteLine("running task 3"); Thread.Sleep(433); Console.WriteLine("finished task 3"); });

            Task.WaitAll(taskArray);


            Console.WriteLine("another line");
            

            //return data from a task
            //generics task<T> T is the type of data to return

            var task05 = Task<string>.Run(

                () => { Console.WriteLine("task is running");
                    return "nice";
                });

            Console.WriteLine(task05.Result);
            Console.ReadLine();
        }

        
    }
}
