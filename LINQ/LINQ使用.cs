using System;
using System.Collections;
using System.Linq;

///LINQ使用

class Program
{
    static void Main()
    {
        int[] numbers = {2, 12, 5, 15};

        IEnumerable lowNums = from n in numbers where n < 10 select n;

        foreach(var x in lowNums)
            Console.Write("{0} ", x);
    }
}

//output:
// 2 5 
