using System;
using GeometryTasks;

namespace Geometry
{
    class Program
    {
        static void Main(string[] args)
        {
            Vector vector = new Vector { X = 1, Y = 1 };
            Segment segment = new Segment { Begin = new Vector { X = 1, Y = 1 }, End = new Vector { X = 1, Y = 1 } };
            bool result = true;
            result = GeometryTasks.Geometry.IsVectorInSegment(vector, segment);
            Console.WriteLine(result);
        }
    }
}
