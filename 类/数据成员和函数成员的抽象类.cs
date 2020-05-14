using System;

///数据成员和函数成员的抽象类
namespace _abstract
{
    abstract class MyBaseClass
    {
        public int SideLength = 10;
        const int TriangleSideCount = 3;

        abstract public void PrintStuff(string s);
        abstract public int MyInt {get; set;}

        public int PerimeterLength()
        {
            return TriangleSideCount * SideLength;
        }
    }

    class MyClass: MyBaseClass
    {
        public override void PrintStuff(string s)
        {
            Console.WriteLine(s);
        }

        private int _myInt;

        public override int MyInt
        {
            get { return _myInt; }
            set { _myInt = value; }
        }
    }

    class Program
    {
        static void Main()
        {
            MyClass mc = new MyClass();
            mc.PrintStuff("This is a string.");
            mc.MyInt = 28;
            Console.WriteLine(mc.MyInt);
            Console.WriteLine("Perimeter Length: {0}", mc.PerimeterLength());
        }
    }
}