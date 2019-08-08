using System;
using System.Threading.Tasks;

namespace lab72_tasks
{
    class Program
    {
        static void Main(string[] args)
        {
            //old
            var ActionMethod01 = new Action(DoThis);
            var task01 = new Task(ActionMethod01);

            task01.Start();
            //still old
            var task02 = Task.Factory.StartNew(
                //placeholder for a methos
                //delegates are placeholders for a method
                () => { Console.WriteLine("inside task 02 called by task factory"); }
                );

            var task03 = new Task(//newer
                () => { Console.WriteLine("in task 03"); }
                );
            task03.Start();
            //newest
            var task04 = Task.Run(
                () => { Console.WriteLine("in task 04"); }
                );

            Console.WriteLine("the program has finished");
            System.Threading.Thread.Sleep(3000);
            Console.ReadLine();
        }
        static void DoThis()
        {
            Console.WriteLine("i am doing something");
        }
    }
}
