using System;

///数组
namespace _array
{
    class Program
    {
        static void Main()
        {
            var arr = new int[,] {{0, 1, 2}, {10, 11, 12}};

            for(int i = 0; i<2; i++)
                for(int j = 0; j<3; j++)
                    Console.WriteLine("Element [{0},{1}] is {2}", i, j, arr[i,j]);
        }
    }
}

//output:
// Element [0,0] is 0
// Element [0,1] is 1
// Element [0,2] is 2
// Element [1,0] is 10
// Element [1,1] is 11
// Element [1,2] is 12
