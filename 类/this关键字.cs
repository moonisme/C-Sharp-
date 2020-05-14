using System;

/// this关键字
namespace _this
{
    class MyClass
    {
        int m = 10;
        public int ReturnMaxSum(int Var1)
        {
            return Var1 > this.m ? Var1 : this.m;
        }
    }
    class Program
    {
        static void Main()
        {
            MyClass mc = new MyClass();

            Console.WriteLine("Max: {0}", mc.ReturnMaxSum(30));
            Console.WriteLine("Max: {0}", mc.ReturnMaxSum(5));
        }
    }
}
