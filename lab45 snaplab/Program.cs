using System;
using System.Collections.Generic;

namespace lab45_snaplab
{
    class Program
    {
        public static List<Point> points = new List<Point>();
        static void Main(string[] args)
        {
            Point point01, point02, point03;
            point01.X = 5;
            point01.Y = 2;
            point02.X = 4;
            point02.Y = 9;
            point03.X = 1;
            point03.Y = 8;
            points.Add(point01);
            points.Add(point02);
            points.Add(point03);

            int highX = 0;
            int highY = 0;
            int minx = 5000, maxx = 0, miny = 5000, maxy = 0;
            foreach(var p in points)
            {
                
                if(p.X > highX)
                {
                    highX = p.X;
                }
                if(p.Y > highY)
                {
                    highY = p.Y;
                }
                if(highX > highY)
                {
                    maxx = highX;
                }
                else
                {
                    maxy = highY;
                }
                if(p.X < minx)
                {
                    minx = p.X;
                }
                if(p.Y < miny)
                {
                    miny = p.Y;
                }
            }
            Console.WriteLine($"{highX}, {highY}, {minx}, {maxx}, {miny}, {maxy}");

        }
    }
    struct Point {

        public int X,Y;

        public Point(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

    }


}
