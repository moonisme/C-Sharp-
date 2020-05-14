using System;
using System.Collections;

///IEnumerator接口
class Program
{
    static void Main()
    {
        int[] MyArray = {10, 11, 12, 13};

        IEnumerator ie = MyArray.GetEnumerator();

        while(ie.MoveNext())
        {
            int i = (int) ie.Current;
            Console.WriteLine("{0}", i);
        }
    }
}

//output:
// 10
// 11
// 12
// 13
