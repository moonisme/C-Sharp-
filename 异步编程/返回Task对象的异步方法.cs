using System;
using System.Threading.Tasks;

///返回Task对象的异步方法

static class DoAsyncStuff
{
    public static async Task CalculateSumAsync(int i1, int i2)
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
        Task someTask = DoAsyncStuff.CalculateSumAsync(5, 6);
        someTask.Wait();
        Console.WriteLine("Async stuff is done");
    }
}

//output:
// Value: 11
// Async stuff is done
