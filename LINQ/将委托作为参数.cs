using System;
using System.Linq;

///将委托作为参数
class Program
{
    static void Main()
    {
        int[] intArray = new int[] {3, 4, 5, 6, 7, 9};

        var countOdd = intArray.Count(n => n % 2 == 1);

        Console.WriteLine("Count of odd numbers: {0}", countOdd);
    }
}

//output:
//Count of odd numbers: 4
