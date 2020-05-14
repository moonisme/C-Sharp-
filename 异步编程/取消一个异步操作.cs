using System;
using System.Threading.Tasks;
using System.Threading;

///取消一个异步操作

class MyClass
{
    public async Task RunAsync(CancellationToken ct)
    {
        if(ct.IsCancellationRequested)
            return;
        await Task.Run(() => CycleMethod(ct), ct);
    }

    void CycleMethod(CancellationToken ct)
    {
        Console.WriteLine("Starting CycleMethod");

        const int max = 5;
        for(int i = 0; i < max; i++)
        {
            if(ct.IsCancellationRequested)
                return;
            Thread.Sleep(1000);
            Console.WriteLine(" {0} of {1} iterations completed", i + 1, max);
        }
    }
}

class Program
{
    static void Main()
    {
        CancellationTokenSource cts = new CancellationTokenSource();
        CancellationToken token = cts.Token;

        MyClass mc = new MyClass();
        Task t = mc.RunAsync(token);

        Thread.Sleep(3000);
        cts.Cancel();

        t.Wait();
        Console.WriteLine("Was Cancelled: {0}", token.IsCancellationRequested);
    }
}

//output:
// Starting CycleMethod
//  1 of 5 iterations completed
//  2 of 5 iterations completed
//  3 of 5 iterations completed
// Was Cancelled: True
