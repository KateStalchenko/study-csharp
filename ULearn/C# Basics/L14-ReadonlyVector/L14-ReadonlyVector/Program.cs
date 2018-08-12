/* Помните класс Vector из позапрошлой практики? Скорее всего, он был написан ужасно, с открытыми полями и всем прочим.
Как правило, такие структуры данных делают read-only.
В пространстве имен ReadOnlyVectorTask сделайте класс ReadOnlyVector с двумя публичными readonly-полями X и Y, которые устанавливаются в конструкторе.
ReadOnlyVector должен содержать метод Add(ReadOnlyVector other), который возвращает сумму векторов.
При работе с readonly классами часто хочется изготовить вектор "такой же, но с другим значением поля X или Y". 
Обеспечьте такую функциональность с помощью методов WithX(double) и WithY(double) */

using System;

namespace ReadOnlyVectorTask
{
    class ReadOnlyVector
    {
        public readonly double X;
        public readonly double Y;

        public ReadOnlyVector(double x, double y)
        {
            X = x;
            Y = y;
        }

        public ReadOnlyVector Add(ReadOnlyVector vector)
        {
            double x = X + vector.X;
            double y = Y + vector.Y;
            return new ReadOnlyVector(x, y);
        }

        public ReadOnlyVector WithX(double x)
        {
            return new ReadOnlyVector(x, Y);
        }

        public ReadOnlyVector WithY(double y)
        {
            return new ReadOnlyVector(X, y);
        }

        public override string ToString()
        {
            return $"x:{X}, y:{Y}";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            ReadOnlyVector vector = new ReadOnlyVector(5, 8);
            Console.WriteLine(vector);
            ReadOnlyVector vector2 = new ReadOnlyVector(8, 9);
            Console.WriteLine(vector2);
            ReadOnlyVector vector3 = vector.Add(vector2);
            Console.WriteLine(vector3);
            ReadOnlyVector vector4 = vector3.WithX(0.55);
            Console.WriteLine(vector4);
            ReadOnlyVector vector5 = vector3.WithY(0.56);
            Console.WriteLine(vector5);

        }
    }
}
