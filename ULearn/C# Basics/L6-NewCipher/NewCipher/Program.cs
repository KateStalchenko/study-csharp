//Незнакомка вернулась!
//На рабочем столе своего ноутбука Вася обнаружил огромный файл.
//Да, кажется предыдущая программа по расшифровке шифра не понадобится — незнакомка не повторяется...
//Вася где-то слышал, что pop и push — это операции работы со стеком.Видимо, тут нужно действовать по аналогии — push дописывает 
//указанную строку в конец текста, а pop удаляет из конца указанное количество символов.
//Видимо, чтобы прочитать второе послание незнакомки, нужно выполнить все операции из файла. 
//Но файл слишком большой, тут без программы-декодировщика не обойтись!

using System;
using System.Text;


namespace NewCipher
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] cipherMessage = { "push Привет! Это снова я! Пока!",
                                        "pop 5",
                                        "push Как твои успехи? Плохо?",
                                        "push qwertyuiop",
                                        "push 1234567890",
                                        "pop 26" };
            Console.WriteLine(ApplyCommands(cipherMessage));
        }

        private static string ApplyCommands(string[] commands)
        {
            var builder = new StringBuilder();
            foreach (string line in commands)
            {
                if (line.StartsWith("push"))
                {
                    builder.Append(line.Remove(0, 5));
                }
                else
                {
                    builder.Remove(((builder.Length - Int32.Parse(line.Remove(0, 4)))), Int32.Parse(line.Remove(0, 4)));
                }
            }
            return builder.ToString();
        }
    }
}