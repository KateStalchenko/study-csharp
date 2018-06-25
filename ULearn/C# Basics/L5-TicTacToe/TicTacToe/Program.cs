using System;

namespace TicTacToe
{
    class Program
    {
        public enum Mark
        {
            Empty,
            Cross,
            Circle
        }

        public enum GameResult
        {
            CrossWin,
            CircleWin,
            Draw
        }

        static void Main(string[] args)
        {
            Check("XXX OO. ...");
            Check("OXO XO. .XO");
            Check("OXO XOX OX.");
            Check("XOX OXO OXO");
            Check("... ... ...");
            Check("XXX OOO ...");
            Console.ReadKey();
        }

        private static void Check(string description)
        {
            Console.WriteLine(description.Replace(" ", "\r\n"));
            Console.WriteLine(GetGameResult(CreateFromString(description)));
            Console.WriteLine();
        }

        public static Mark[,] CreateFromString(string str)
        {
            str = str.Replace(" ", "");
            char[] b = str.ToCharArray();
            int ch = 0;
            Mark[,] arr = new Mark[3, 3];
            // Инициализируем данный массив
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (b[ch] == 'X')
                        arr[i, j] = Mark.Cross;

                    if (b[ch] == 'O')
                        arr[i, j] = Mark.Circle;

                    if (b[ch] == '.')
                        arr[i, j] = Mark.Empty;
                    ch++;
                }
            }
            return arr;
        }

        public static GameResult GetGameResult(Mark[,] field)
        {
            bool isCircleWin = false;
            bool isCrossWin = false;
            int length = field.GetLength(0);
            Mark currentMark;

            for (int index = 0; index < length - 1; index++)
            {
                bool rowCheckResult = CheckRow(index, field, out currentMark);
                if (currentMark == Mark.Circle)
                {
                    isCircleWin = true;
                }
                else if (currentMark == Mark.Cross)
                {
                    isCrossWin = true;
                }

                bool columnCheckResult = CheckColumn(index, field, out currentMark);
                if (currentMark == Mark.Circle)
                {
                    isCircleWin = true;
                }
                else if (currentMark == Mark.Cross)
                {
                    isCrossWin = true;
                }
            }
            
            if (CheckDiagonalOne(field, out currentMark))
            {
                if (currentMark == Mark.Circle)
                {
                    isCircleWin = true;
                }
                else if (currentMark == Mark.Cross)
                {
                    isCrossWin = true;
                }
            }

            if (CheckDiagonalTwo(field, out currentMark))
            {
                if (currentMark == Mark.Circle)
                {
                    isCircleWin = true;
                }
                else if (currentMark == Mark.Cross)
                {
                    isCrossWin = true;
                }
            }

            if (isCircleWin == isCrossWin)
            {
                return GameResult.Draw;
            }
            else
            {
                return isCircleWin ? GameResult.CircleWin : GameResult.CrossWin;
            }
        }

        public static bool CheckDiagonalOne(Mark[,] field, out Mark outputMark)
        {
            int length = field.GetLength(0);
            outputMark = Mark.Empty;

            for (int i = 0; i < length - 1; i++)
            {
                if (field[i, i] != field[i + 1, i + 1])
                {
                    return false;
                }
            }
            outputMark = field[0, 0];
            return true;
        }

        public static bool CheckDiagonalTwo(Mark[,] field, out Mark outputMark)
        {
            int length = field.GetLength(0);
            outputMark = Mark.Empty;

            for (int i = 0; i < length - 1; i++)
            {
                if (field[length - 1 - i, i] != field[length - 2 - i, i + 1])
                {
                    return false;
                }
            }
            outputMark = field[length - 1, 0];
            return true;
        }

        public static bool CheckRow(int rowIndex, Mark[,] field, out Mark outputMark)
        {
            outputMark = Mark.Empty;
            int length = field.GetLength(0);

            for (int column = 0; column < length - 1; column++)
            {
                if (field[rowIndex, column] != field[rowIndex, column + 1])
                {
                    return false;
                }
            }

            outputMark = field[rowIndex, 0];
            return true;
        }

        public static bool CheckColumn(int columnIndex, Mark[,] field, out Mark outputMark)
        {
            outputMark = Mark.Empty;
            int length = field.GetLength(0);

            for (int row = 0; row < length - 1; row++)
            {
                if (field[row, columnIndex] != field[row + 1, columnIndex])
                {
                    return false;
                }
            }
            outputMark = field[0, columnIndex];
            return true;
        }

    }
}
