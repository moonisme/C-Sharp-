using System;

///访问修饰符 重要封装工具
namespace _indexer
{
    class Person
    {
        public string Name { get; private set; }
        public Person(string name)
        {
            Name = name;
        }
    }
    class Program
    {
        static public void Main()
        {
            Person p = new Person("chanzi");
            Console.WriteLine("Person's name is {0}.", p.Name);
        }
    }
}
