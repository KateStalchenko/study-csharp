using System;

namespace Practice_IClonable
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person { Name = "Donald", Age = 25, Work = new Company { Name = "Microsoft" } };
            Person p2 = (Person)p1.Clone();
            p2.Name = "John";
            p2.Work.Name = "Google";
            Console.WriteLine(p1.Name);
            Console.WriteLine(p1.Work.Name);
            Console.ReadLine();
        }
    }

    class Person : ICloneable
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public Company Work { get; set; }
        
        public object Clone()
        {
            Company company = new Company { Name = this.Work.Name };
            return new Person
            {
                Name = this.Name,
                Age = this.Age,
                Work = company
            };

        }
    }

    public interface ICloneable
    {
        object Clone();
    }

    class Company
    {
        public string Name { get; set; }
    }
}
