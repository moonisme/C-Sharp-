using System;

///分部方法
namespace _partial
{
    partial class MyClass
    {
        partial void PrintSum(int x, int y);

        public void Add(int x, int y)
        {
            PrintSum(x, y);
        }
    }
    partial class MyClass
    {
        partial void PrintSum(int x, int y)
        {
            Console.WriteLine("Sum is {0}", x + y);
        }
    }

    class Program
    {
        static void Main()
        {
            MyClass mc = new MyClass();
            mc.Add(5, 6);
        }
    }
}
