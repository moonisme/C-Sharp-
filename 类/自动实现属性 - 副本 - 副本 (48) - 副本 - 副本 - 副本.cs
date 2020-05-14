using System;

/// 自动实现属性
namespace attribute_1
{
    class C1
    {
        public int MyValue
        {
            set; get;
        }
    }
    class Program
    {
        static void Main()
        {
            C1 c = new C1();
            Console.WriteLine("MyValue: {0}", c.MyValue);

            c.MyValue = 20;
            Console.WriteLine("MyValue: {0}", c.MyValue);
        }
    }
}
