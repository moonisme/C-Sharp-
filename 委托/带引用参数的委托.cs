using System;

///带引用参数的委托
delegate void MyDel(ref int X);

class MyClass
{
    public void Add2(ref int x) { x +=2; }
    public void Add3(ref int x) { x +=3; }

    static void Main()
    {
        MyClass mc = new MyClass();

        MyDel myDel = mc.Add2;
        myDel += mc.Add3;
        myDel += mc.Add2;

        int x = 5;
        myDel(ref x);

        Console.WriteLine("Value: {0}", x);
    }
}

//output:
// Value: 12
