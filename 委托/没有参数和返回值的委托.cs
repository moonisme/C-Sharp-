using System;

///没有参数和返回值的委托
delegate void PrintFunction();

class Test
{
    public void Print1()
    {
        Console.WriteLine("Print1 -- instance");
    }

    public static void Print2()
    {
        Console.WriteLine("Print2 -- static");
    }
}

class Program
{
    static void Main()
    {
        Test t = new Test();
        PrintFunction pf;

        pf = t.Print1;

        pf += Test.Print2;
        pf += t.Print1;
        pf += Test.Print2;

        if(null != pf)
            pf();
        else
            Console.WriteLine("Delegate is empty");
    }
}

//output:
// Print1 -- instance
// Print2 -- static
// Print1 -- instance
// Print2 -- static
