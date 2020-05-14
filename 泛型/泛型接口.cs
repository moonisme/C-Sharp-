using System;

///泛型接口
interface IMyIfc<T>
{
    T ReturnIt(T inValue);
}

class Simple: IMyIfc<int>, IMyIfc<string>
{
    public int ReturnIt(int inValue)
    {
        return inValue;
    }

      public string ReturnIt(string inValue)
    {
        return inValue;
    }
}

class Program
{
    static void Main()
    {
        var trivial = new Simple();

        Console.WriteLine("{0}",trivial.ReturnIt(5));
        Console.WriteLine("{0}", trivial.ReturnIt("Hi there."));
    }
}

//output:
// 5
// Hi there.
