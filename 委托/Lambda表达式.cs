using System;

///Lambda表达式
delegate double MyDel(int par);

class Program
{
    static void Main()
    {
        MyDel del = x => x + 1;

        Console.WriteLine("{0}", del(12));
    }
}

//output:
//13
