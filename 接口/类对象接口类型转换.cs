using System;

///类对象接口类型转换
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

        IIfc1 ifc = mc as IIfc1;
        ifc.PrintOut("interface");
    }
}

//output:
// Calling though: object
// Calling though: interface
