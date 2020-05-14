using System;

/// 静态属性
namespace attribute_2
{
    class C1
    {
        public static int MyValue {set; get;}

        public void PrintValue()
        {
            Console.WriteLine("Value from inside: {0}", MyValue);
        }
    }
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Init Value: {0}", C1.MyValue);
            C1.MyValue = 10;
            Console.WriteLine("New Value: {0}", C1.MyValue);
            C1 c = new C1();
            c.PrintValue();
        }
    }
}