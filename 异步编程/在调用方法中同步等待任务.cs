using System;
using System.Threading.Tasks;
using System.Net;
using System.Diagnostics;

///在调用方法中同步等待任务

class MyDownloadString
{
    Stopwatch sw = new Stopwatch();

    public void DoRun()
    {
        Task<int> t1 = CountCharactersAsync(1, "http://www.microsoft.com");
        Task<int> t2 = CountCharactersAsync(2, "https://www.youtube.com/?tab=w1&gl=TW");

        Task<int>[] tasks = new Task<int>[] {t1, t2};
        Task.WaitAll(tasks);
 //       Task.WaitAny(tasks);

        Console.WriteLine("Task 1: {0} Finished", t1.IsCompleted ? "" : "Not");
        Console.WriteLine("Task 2: {0} Finished", t2.IsCompleted ? "" : "Not");
        Console.Read();
    }

    private async Task<int> CountCharactersAsync(int id, string site)
    {
        WebClient wc = new WebClient();
        string result = await wc.DownloadStringTaskAsync(new Uri(site));
        Console.WriteLine("  Call {0} completed: {1} ms", id, sw.Elapsed.TotalMilliseconds);
        return result.Length;
    }
}

class Program
{
    static void Main()
    {
        MyDownloadString ds = new MyDownloadString();
        ds.DoRun();
    }
}

//output:
//   Call 1 completed: 0 ms
//   Call 2 completed: 0 ms
// Task 1:  Finished
// Task 2:  Finished
