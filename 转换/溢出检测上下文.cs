using System;

///溢出检测上下文
class program
{
    static void Main()
    {
        ushort sh = 2000;
        byte sb;

        sb = unchecked((byte) sh);
        Console.WriteLine("sb: {0}", sb);

        sb = checked((byte) sh);
        Console.WriteLine("sb: {0}", sb);
    }
}

//output:
// sb: 208
// 引发的异常:“System.OverflowException”(位于 c#.dll 中)
