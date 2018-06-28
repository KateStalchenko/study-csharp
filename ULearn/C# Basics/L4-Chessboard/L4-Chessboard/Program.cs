//Стали известны подробности про новую игру Васи.Оказывается ее действия разворачиваются на шахматных досках нестандартного размера.
//У Васи уже написан код, генерирующий стандартную шахматную доску размера 8х8.Помогите Васе переделать этот код так, 
//чтобы он умел выводить доску любого заданного размера.

using System;

namespace Shaxmatnayadoska
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteBoard(4);
            WriteBoard(1);
            WriteBoard(2);
            WriteBoard(3);
            WriteBoard(10);
            Console.ReadKey();
        }

        private static void WriteBoard(int size)
        {
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    if ((i % 2 == 0 && j % 2 == 0) || (i % 2 != 0 && j % 2 != 0)) Console.Write("#");
                    else Console.Write(".");
                }
                Console.Write("\n");
            }
            Console.WriteLine("");
        }
    }
}