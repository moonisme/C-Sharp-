using System;

///装箱（创建副本）
class Program
{
    static void Main()
    {
        int i = 10;

        object oi = i;   //对i装箱并把引用赋值给oi

    Console.WriteLine("i: {0}, io: {1}", i, oi);

    i = 12;
    oi = 15;
    Console.WriteLine("i: {0}, io: {1}", i, oi);
    }
}

//output:
// i: 10, io: 10
// i: 12, io: 15
