//Вы решили помочь Васе с разработкой его игры и взяли на себя красивый вывод сообщений в игре.
//Напишите функцию, которая принимает на вход строку текста и печатает ее на экран в рамочке из символов +, - и |. 
//Для красоты текст должен отделяться от рамки слева и справа пробелом.

using System;

namespace L4_Frame
{
    class Program
    {
        public static void Main()
        {
            WriteTextWithBorder("Menu:");
            WriteTextWithBorder("");
            WriteTextWithBorder(" ");
            WriteTextWithBorder("Game Over!");
            WriteTextWithBorder("Select level:");
        }

        private static void WriteTextWithBorder(string text)
        {
            string line = "+" + new string('-', text.Length + 2) + "+";
            Console.WriteLine(line);
            Console.WriteLine($"| {text} |");
            Console.WriteLine(line);
        }
    }
}
