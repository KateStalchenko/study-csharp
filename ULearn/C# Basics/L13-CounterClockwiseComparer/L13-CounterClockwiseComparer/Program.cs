/* А как насчет того, чтобы отсортировать точки в порядке следования против часовой стрелки, считая первой ту, что находится на 3:00? */

using System;
using System.Collections;

namespace L13_CounterClockwiseComparer
{
    class Program
    {
        private static void Main()
        {
            var array = new[]
            {
                new Point { X = 1, Y = 0 },
                new Point { X = -1, Y = 0 },
                new Point { X = 0, Y = 1 },
                new Point { X = 0, Y = -1 },
                new Point { X = 0.01, Y = 1 }
            };

            Array.Sort(array, new ClockwiseComparer());
            foreach (Point e in array)
                Console.WriteLine("{0} {1}", e.X, e.Y);
        }
    }

    public class Point
    {
        public double X;
        public double Y;
    }

    public class ClockwiseComparer : IComparer
    {
        public int Compare(object x, object y)
        {
            Point x1 = x as Point;
            Point y1 = y as Point;

            return Math.Atan2(-x1.Y, -x1.X).CompareTo(Math.Atan2(-y1.Y, -y1.X));
        }
    }
}