using System;using System.Net;
using System.Diagnostics;

///不使用异步的示例
class MyDownloadString
{
    Stopwatch sw = new Stopwatch();

    public void DoRun()
    {
        const int LargeNumber = 6000000;
        sw.Start();

        int t1 = CountCharacters(1, "http://www.microsoft.com");
        int t2 = CountCharacters(2, "https://www.youtube.com/?tab=w1&gl=TW");

        CountToALargeNumber(1, LargeNumber);
        CountToALargeNumber(2, LargeNumber);
        CountToALargeNumber(3, LargeNumber);
        CountToALargeNumber(4, LargeNumber);

        Console.WriteLine("Chars in http://www.microsoft.com :  {0}", t1);
        Console.WriteLine("Chars in https://www.youtube.com/?tab=w1&gl=TW :  {0}", t2);
    }

    private int CountCharacters(int id, string uriString)
    {
        WebClient wc1 = new WebClient();
        Console.WriteLine("Starting call {0}:   {1} ms", id, sw.Elapsed.TotalMilliseconds);

        string result = wc1.DownloadString(new Uri(uriString));
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
// Starting call 1:   9.1841 ms
//  Call 1 completed:    732.6728 ms
// Starting call 2:   732.7545 ms
//  Call 2 completed:    1739.1419 ms
//     End counting 1:    1750.8557 ms
//     End counting 2:    1762.3955 ms
//     End counting 3:    1773.9089 ms
//     End counting 4:    1785.4421 ms
// Chars in http://www.microsoft.com :  180301
// Chars in https://www.youtube.com/?tab=w1&gl=TW :  266398
