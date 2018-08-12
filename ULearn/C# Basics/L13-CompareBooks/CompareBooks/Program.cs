/* Вы пишете учетную систему для книжного магазина, и вам необходимо научиться сравнивать между собой записи о книгах, 
 * чтобы продавцам было удобно искать нужную.
 * Каждая книга имеет название Title и номер тематического раздела Theme. Реализуйте интерфейс IComparable у класса Book. */

using System;

namespace CompareBooks
{
    class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book { Title = "A", Theme = 5 };
            Book book2 = new Book { Title = "A", Theme = 5 };
            Console.WriteLine (book1.CompareTo(book2));
        }
    }

    class Book : IComparable
    {
        public string Title;
        public int Theme;

        public int CompareTo(object obj)
        {
            Book book = obj as Book;
            if (Theme > book.Theme)
            {
                return 1;
            }
            else if (Theme == book.Theme)
            {
                return Title.CompareTo(book.Title);
            }
            return -1;
        }
    }
}
