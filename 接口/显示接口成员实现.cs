using System;

///显示接口成员实现
interface IIfc1
{
    void PrintOut(string s);
}

interface IIfc2
{
    void PrintOut(string t);
}

class MyClass: IIfc1, IIfc2
{
    void IIfc1.PrintOut(string s)
    {
        Console.WriteLine("IIfc1:  {0}", s);
    }

      void IIfc2.PrintOut(string s)
    {
        Console.WriteLine("IIfc2:  {0}", s);
    }
}

class Program
{
    static void Main()
    {
        MyClass mc = new MyClass();

        IIfc1 ifc1 = mc as IIfc1;
        ifc1.PrintOut("interface 1");

        IIfc2 ifc2 = mc as IIfc2;
        ifc2.PrintOut("interface 2");
    }
}

//output:
// IIfc1:  interface 1
// IIfc2:  interface 2
