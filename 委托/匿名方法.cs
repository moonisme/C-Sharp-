using System;

///匿名方法
class Program
{
    delegate int OtherDel(int InParam);

    static void Main()
    {
        OtherDel del = delegate(int x)
        {
            return x + 20;
        };
        Console.WriteLine("{0}", del(5));
        Console.WriteLine("{0}", del(6));
    }
}

//output:
// 25
// 26
