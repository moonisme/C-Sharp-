using System;
using System.Threading.Tasks;

///异常处理和await表达式

class Program
{
    static void Main()
    {
        Task t = BadAsync();
        t.Wait();
        Console.WriteLine("Task Status: {0}", t.Status);
        Console.WriteLine("Task IsFaulted: {0}", t.IsFaulted);
    }

    static async Task BadAsync()
    {
        try
        {
            await Task.Run(() => {throw new Exception();});
        }
        catch
        {
            Console.WriteLine("Exception in BadAsync");
        }
    }
}

//output:
// Exception in BadAsync
// Task Status: RanToCompletion
// Task IsFaulted: False
