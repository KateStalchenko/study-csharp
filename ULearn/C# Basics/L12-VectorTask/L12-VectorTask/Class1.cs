/*1)    Создайте новый проект в Visual Studio.Выберите в качестве типа проекта Class Library.
  В этом проекте создайте два класса, Vector и Geometry, в пространстве имен GeometryTasks.
  В классе Vector должно быть два публичных поля, X и Y, типа double.
  В классе Geometry должно быть два статических метода: GetLength, который возвращает длину переданного вектора, и Add,
  который возвращает сумму двух переданных векторов.
  Оба класса разместите в одном файле. Вообще-то так обычно делать нельзя, но наша проверяющая система так устроена.

2)    Создайте класс отрезка Segment с двумя публичными полями, Begin и End, типа Vector.
  Добавьте метод Geometry.GetLength, вычисляющий длину сегмента, и метод Geometry.IsVectorInSegment(Vector, Segment), проверяющий, 
  что задаваемая вектором точка лежит в отрезке.

3)    Вы вдруг поняли, что не очень-то удобно писать имя класса Geometry при выполнении любой операции с векторами и сегментами.
  Однако, отказаться от этого класса вы не можете, потому что за те несколько минут, пока вы сдавали предыдущую задачу,
  вашу библиотеку скачали и начали использовать в своих проектах тысячи человек.
  Поэтому вы решили сохранить этот класс, но добавить методы Vector.GetLength(), Segment.GetLength(), Vector.Add(Vector), Vector.Belongs(Segment)
  и Segment.Contains(Vector) не вместо, а вместе с соответствующими методами класса Geometry.
  Сделайте это! Каждый из этих методов должен вызывать уже существующий метод класса Geometry, чтобы не дублировать код.*/


using System;

namespace GeometryTasks
{
    public class Vector
    {
        public double X { get; set; }
        public double Y { get; set; }

        public double GetLength() => Geometry.GetLength(this);
        public Vector Add(Vector vector) => Geometry.Add(this, vector);
        public bool Belongs(Segment segment) => Geometry.IsVectorInSegment(this, segment);
    }

    public class Segment
    {
        public Vector Begin;
        public Vector End;

        public double GetLength() => Geometry.GetLength(this);
        public bool Contains(Vector vector) => Geometry.IsVectorInSegment(vector, this);
    }

    public class Geometry
    {
        public static double GetLength(Vector vector) // метод, который возвращает длину переданного вектора
        {
            return Math.Sqrt(vector.X * vector.X + vector.Y * vector.Y);
        }

        public static Vector Add(Vector vector1, Vector vector2) // метод, который возвращает сумму двух переданных векторов
        {
            return new Vector { X = vector1.X + vector2.X, Y = vector1.Y + vector2.Y };
        }

        public static double GetLength(Segment segment) // метод, вычисляющий длину сегмента
        {
            return Math.Sqrt(Math.Pow((segment.End.X - segment.Begin.X), 2) + Math.Pow((segment.End.Y - segment.Begin.Y), 2));
        }

        public static bool IsVectorInSegment(Vector vector, Segment segment) // метод, проверяющий, что задаваемая вектором точка лежит в отрезке
        {
            if ((segment.Begin.X <= vector.X && segment.Begin.Y <= vector.Y) && (vector.X <= segment.End.X && vector.Y <= segment.End.Y))
            {
                double dx1 = segment.End.X - segment.Begin.X;
                double dy1 = segment.End.Y - segment.Begin.Y;
                double dx = vector.X - segment.Begin.X;
                double dy = vector.Y - segment.Begin.Y;

                double s = dx1 * dy - dx * dy1;

                return s == 0;
            }
            return false;
        }
    }
}