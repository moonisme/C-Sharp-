using System;

///派生成员作为实现
interface IIfc1
{
    void PrintOut(string s);
}

class MyBaseClass
{
    public void PrintOut(string s)
    {
        Console.WriteLine("Calling though: {0}", s);
    }
}

class Derived: MyBaseClass, IIfc1
{}

class Program
{
    static void Main()
    {
        Derived d = new Derived();
        d.PrintOut("object.");
    }
}

//output:
// Calling though: object.
