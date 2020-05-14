using System;

///接口声明实现
interface IIfc1
{
    void PrintOut(string s);
}

class Myclass: IIfc1
{
    public void PrintOut(string s)
    {
        Console.WriteLine("Calling though: {0}", s);
    }
}

class Program
{
    static void Main()
    {
        Myclass mc = new Myclass();
        mc.PrintOut("object");
    }
}

//output:
// Calling though: object
