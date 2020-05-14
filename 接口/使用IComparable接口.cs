using System;

///使用IComparable接口
class MyClass: IComparable
{
    public int TheValue;
    public int CompareTo(object obj)
    {
        MyClass mc = (MyClass)obj;
        if(this.TheValue < mc.TheValue) return -1;
        if(this.TheValue > mc.TheValue) return 1;
        return 0;
    }
}

class Program
{
    static void PrintOut(string s, MyClass[] mc)
    {
        Console.Write(s);
        foreach(var m in mc)
            Console.Write("{0} ", m.TheValue);
        Console.WriteLine("");
    }

    static void Main()
    {
        var myInt = new [] {20, 4, 16, 9, 2};

        MyClass[] mcArr = new MyClass[5];
        for(int i = 0; i < 5; i++)
        {
            mcArr[i] = new MyClass();
            mcArr[i].TheValue = myInt[i];
        }

        PrintOut("Initial Order: ", mcArr);
        Array.Sort(mcArr);
        PrintOut("Sorted Order: ", mcArr);
    }
}

//output:
// Initial Order: 20 4 16 9 2 
// Sorted Order: 2 4 9 16 20 
