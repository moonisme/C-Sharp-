using System;

/// 静态字段示例
namespace static_1
{
    class D
    {
        int m1;
        static int m2;

        public void SetVars(int v1, int v2)
        {
            m1 = v1;
            m2 = v2;
        }
        public void Display(string str)
        {
            Console.WriteLine("{0}: m1 = {1}, m2 = {2}", str, m1, m2);
        }
    }
    class Program
    {
        static void Main()
        {
            D d1 = new D();
            D d2 = new D();

            d1.SetVars(2, 4);
            d1.Display("d1");

            d2.SetVars(15, 17);
            d1.Display("d2");

            d1.Display("d1");
        }
    }
}