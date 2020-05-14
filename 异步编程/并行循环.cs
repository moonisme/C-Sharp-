using System;
using System.Threading.Tasks;

///并行循环

class Program
{
    static void Main()
    {
        Parallel.For(0, 15, i => Console.WriteLine("The square of {0} is {1}", i, i*i));

        string[] squares = new string[] {"We", "hold", "these", "truths", "to", "be", "self-evident", 
                                         "that", "all","men", "are", "created", "equal"};
        Parallel.ForEach(squares, i => Console.WriteLine(string.Format("{0} has {1} letters", i, i.Length)));
    }
}

//output:
// The square of 1 is 1
// The square of 0 is 0
// The square of 9 is 81
// The square of 11 is 121
// The square of 12 is 144
// The square of 13 is 169
// The square of 14 is 196
// The square of 2 is 4
// The square of 5 is 25
// The square of 4 is 16
// The square of 7 is 49
// The square of 6 is 36
// The square of 8 is 64
// The square of 10 is 100
// The square of 3 is 9
// We has 2 letters
// be has 2 letters
// that has 4 letters
// self-evident has 12 letters
// all has 3 letters
// are has 3 letters
// men has 3 letters
// created has 7 letters
// equal has 5 letters
// hold has 4 letters
// these has 5 letters
// to has 2 letters
// truths has 6 letters