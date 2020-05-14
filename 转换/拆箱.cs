using System;

///拆箱
class program
{
    static void Main()
    {
        int i = 10;

        object oi = i;

        int j = (int) oi;   //对oi拆箱并把☞赋值给j
        Console.WriteLine("i: {0}, oi: {1}, j: {2}", i, oi, j);
    }
}

//output:
// i: 10, oi: 10, j: 10
