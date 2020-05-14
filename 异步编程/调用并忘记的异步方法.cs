using System;
using System.Threading.Tasks;
using System.Threading;

///调用并忘记的异步方法

static class DoAsyncStuff
{
    public static async void CalculateSumAsync(int i1, int i2)
    {
        int sum = await Task.Run(() => GetSum(i1, i2));
        Console.WriteLine("Value: {0}", sum);
    }

    private static int GetSum(int i1, int i2)
    {
        return i1 + i2;
    }
}

class Program
{
    static void Main()
    {
        DoAsyncStuff.CalculateSumAsync(5, 6);
        Thread.Sleep(200);
        Console.WriteLine("Program Exiting");
    }
}

//output:
// Value: 11
// Program Exiting
