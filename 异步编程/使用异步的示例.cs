using System;
using System.Net;
using System.Diagnostics;
using System.Threading.Tasks;

///使用异步的示例

class MyDownloadString
{
    Stopwatch sw = new Stopwatch();

    public void DoRun()
    {
        const int LargeNumber = 6000000;
        sw.Start();

        Task<int> t1 = CountCharactersAsync(1, "http://www.microsoft.com");
        Task<int> t2 = CountCharactersAsync(2, "https://www.youtube.com/?tab=w1&gl=TW");

        CountToALargeNumber(1, LargeNumber);
        CountToALargeNumber(2, LargeNumber);
        CountToALargeNumber(3, LargeNumber);
        CountToALargeNumber(4, LargeNumber);

        Console.WriteLine("Chars in http://www.microsoft.com :  {0}", t1.Result);
        Console.WriteLine("Chars in https://www.youtube.com/?tab=w1&gl=TW :  {0}", t2.Result);    
    }

    private async Task<int> CountCharactersAsync(int id, string uriString)
    {
        WebClient wc = new WebClient();
        Console.WriteLine("Starting call {0}:   {1} ms", id, sw.Elapsed.TotalMilliseconds);

        string result = await wc.DownloadStringTaskAsync(new Uri(uriString));
        Console.WriteLine(" Call {0} completed:    {1} ms", id, sw.Elapsed.TotalMilliseconds);

        return result.Length;
    }

    private void CountToALargeNumber(int id, int value)
    {
        for(long i = 0; i < value; i++);
        Console.WriteLine("    End counting {0}:    {1} ms", id, sw.Elapsed.TotalMilliseconds);
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
// Starting call 1:   13.4051 ms
// Starting call 2:   159.027 ms
//     End counting 1:    180.0397 ms
//     End counting 2:    192.0296 ms
//     End counting 3:    206.6693 ms
//     End counting 4:    226.6649 ms
//  Call 1 completed:    718.0544 ms
// Chars in http://www.microsoft.com :  179295
//  Call 2 completed:    1411.0416 ms
// Chars in https://www.youtube.com/?tab=w1&gl=TW :  269016
