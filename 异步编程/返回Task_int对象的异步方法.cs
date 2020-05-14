using System;
using System.Threading.Tasks;

///返回Task<int>对象的异步方法

static class DoAsyncStuff
{
    public static async Task<int> CalculateSumAsync(int i1, int i2)
    {
        int sum = await Task.Run(() => GetSum(i1, i2));
        return sum;
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
        Task<int> value = DoAsyncStuff.CalculateSumAsync(5, 6);
        Console.WriteLine("Value: {0}", value.Result);
    }
}

//output:
// Value: 11