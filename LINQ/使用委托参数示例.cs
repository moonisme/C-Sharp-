using System;
using System.Linq;

///使用委托参数示例

class Program
{
    static bool IsOdd(int x)
    {
        return x % 2 == 1;
    }

    static void Main()
    {
        int[] intArray = new int[] {3, 4, 5, 6, 7, 9};

        Func<int, bool> myDel = new Func<int, bool>(IsOdd); //委托对象
        var countOdd = intArray.Count(myDel);

        Console.WriteLine("Count of odd numbers: {0}", countOdd);
    }
}

//output:
// Count of odd numbers: 4
