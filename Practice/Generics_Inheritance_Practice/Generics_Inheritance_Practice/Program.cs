using System;

namespace Generics_Inheritance_Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            Account<string> acc1 = new Account<string>("34");
            UniversalAccount<int> acc3 = new UniversalAccount<int>(450);
            UniversalAccount<int> acc2 = new UniversalAccount<int>(25);
            StringAccount acc4 = new StringAccount("258");
            Account<string> acc5 = new StringAccount("222");
            IntAccount<string> acc6 = new IntAccount<string>(25) { Code = "gg258" };
            Account<int> acc7 = new IntAccount<long>(7) { Code = 258 };
            MixedAccount<string,int> acc8 = new MixedAccount<string, int>("256") { Code = 111 };
            Account<string> acc9 = new MixedAccount<string, int>("555") { Code = 22 };
            Console.WriteLine(acc1.Id);
            Console.WriteLine(acc2.Id);
            Console.WriteLine(acc3.Id);
        }

        class Account<T>
        {
            public T Id { get; private set; }
            public Account(T _id)
            {
                Id = _id;
            }
        }

        class UniversalAccount<T> : Account<T>
        {
            public UniversalAccount(T id) : base(id)
            { }
        }

        class StringAccount : Account<string>
        {
            public StringAccount(string id) : base(id)
            { }
        }

        class IntAccount<T> : Account<int>
        {
            public T Code { get; set; }
            public IntAccount(int id) : base(id)
            { }
        }

        class MixedAccount<T, K> : Account<T>
            where K : struct
        {
            public K Code { get; set; }
            public MixedAccount (T id): base (id)
            { }
        }
    }
}

