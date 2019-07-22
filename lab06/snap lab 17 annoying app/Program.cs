using System;
using System.Runtime.InteropServices;
namespace snap_lab_17_annoying_app
{

    class Program
    {

        static void Main(string[] args)
        {
            Random rand = new Random();
            Random rand2 = new Random();
            int wait;
           for(int i = 0; i < 100; i++)
            {
                for(int j = 10000; j > 0; j-= 3) {
                    wait = rand2.Next(100, 400);
                Console.Beep(rand.Next(37,10000), wait);
                    System.Threading.Thread.Sleep(wait);
                int k = j % 10;

                    switch (k)
                    {

                        case 0:
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.BackgroundColor = ConsoleColor.Green;
                            Console.WriteLine("i aint dun nuffink shut yer face mate");
                            break;
                        case 1:
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.BackgroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("i aint dun nuffink your nans a right biffer");
                            break;
                        case 2:
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.BackgroundColor = ConsoleColor.Blue;
                            Console.WriteLine("i aint dun nuffink imma punch you in the throat");
                            break;
                        case 3:
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.BackgroundColor = ConsoleColor.Magenta;
                            Console.WriteLine("i aint dun nuffink you wat mate");
                            break;
                        case 4:
                            Console.ForegroundColor = ConsoleColor.Magenta;
                            Console.BackgroundColor = ConsoleColor.Cyan;
                            Console.WriteLine("i aint dun nuffink shut your maff");
                            break;
                        case 5:
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.BackgroundColor = ConsoleColor.DarkBlue;
                            Console.WriteLine("i aint dun nuffink shut up abot my ex u slag");
                            break;
                        case 6:
                            Console.ForegroundColor = ConsoleColor.DarkBlue;
                            Console.BackgroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine("i aint dun nuffink pm me babes");
                            break;
                        case 7:
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.BackgroundColor = ConsoleColor.Black;
                            Console.WriteLine("i aint dun nuffink sanru is well fit omg");
                            break;
                        case 8:
                            Console.ForegroundColor = ConsoleColor.Black;
                            Console.BackgroundColor = ConsoleColor.Red;
                            Console.WriteLine("i aint dun nuffink i aint drunk honest ");

                            break;
                        case 9:
                            Console.ForegroundColor = ConsoleColor.DarkGray;
                            Console.BackgroundColor = ConsoleColor.DarkGray;
                            Console.WriteLine("i aint dun nuffink");
                            break;


                    }

                    
                }
                
            }
        }
    }
}
