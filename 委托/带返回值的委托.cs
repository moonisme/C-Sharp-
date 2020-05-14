using System;

///带返回值的委托
delegate int MyDel();
class MyClass
{
    int IntValue = 5;
    public int Add2()
    {
        IntValue +=2;
        return IntValue;
    }

    public int Add3()
    {
        IntValue +=3;
        return IntValue;
    }
}

class Program
{
    static void Main()
    {
        MyClass mc = new MyClass();
        MyDel mDel = mc.Add2;
        mDel += mc.Add3;
        mDel += mc.Add2;

        Console.WriteLine("Value: {0}", mDel());
    }
}

//output:
// Value: 12
