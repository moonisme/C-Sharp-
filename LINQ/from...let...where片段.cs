using System;
using System.Linq;

/// from...let...where片段

class Program
{
    static void Main()
    {
        var groupA = new[] {3, 4, 5, 6};
        var groupB = new[] {6, 7, 8, 9};

        var someInts = from int a in groupA
                       from int b in groupB
                       let sum = a + b
                       where sum >= 11
                       where a == 4
                       select new {a, b, sum};
        
        foreach(var a in someInts)
            Console.WriteLine(a);
    }
}

//output:
// { a = 4, b = 7, sum = 11 }
// { a = 4, b = 8, sum = 12 }
// { a = 4, b = 9, sum = 13 }
