using System;

///泛型委托
delegate void MyDelegate<T>(T value);

class Simple
{
    static public void PrintString(string s)
    {
        Console.WriteLine(s);
    }

    static public void PrintUpperString(string s)
    {
        Console.WriteLine("{0}", s.ToUpper());
    }
}

class Program
{
    static void Main()
    {
        var myDel = new MyDelegate<string>(Simple.PrintString);
        myDel += Simple.PrintUpperString;
        myDel("Hi There.");
    }
}

//output:
// Hi There.
// HI THERE.