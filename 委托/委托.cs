using System;

///委托
delegate void MyDel(int value);

class Program
{
    void PrintLow(int value)
    {
        Console.WriteLine("{0} - Low Value", value);
    }

    void PrintHigh(int value)
    {
        Console.WriteLine("{1} - High Value", value);
    }

    static void Main()
    {
        Program program = new Program();

        MyDel del;

        Random rand = new Random();
        int randomValue = rand.Next(99);

        del = randomValue < 50 ? new MyDel(program.PrintLow) : new MyDel(program.PrintHigh);

        del(randomValue);
    }
}

//output:
// 34 - Low Value
