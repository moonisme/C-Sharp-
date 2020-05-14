using System;

///方法返回类型标识TR 方法参数类型T1 T2
public delegate TR Func<T1, T2, TR>(T1 p1, T2 p2);

class Simple
{
    static public string PrintString(int p1, int p2)
    {
        int total = p1 + p2;
        return total.ToString();
    }
}

class Program
{
    static void Main()
    {
        var myDel = new Func<int, int, string>(Simple.PrintString);

        Console.WriteLine("Total: {0}", myDel(15, 13));
    }
}

//output:
// Total: 28
