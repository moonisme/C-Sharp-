using System;

///交错数组
namespace _array
{
    class Program
    {
        static void Main()
        {
            int total = 0;
            int[][] arr1 = new int[2][];
            arr1[0] = new int[] {10, 11};
            arr1[1] = new int[] {12, 13, 14};

            foreach(int[] array in arr1)
            {
                Console.WriteLine("Starting new array");
                foreach(int item in array)
                {
                    total += item;
                    Console.WriteLine(" Item: {0}, Current Total: {1}", item, total);
                }
            }
        }
    }
}

//output:
// Starting new array
//  Item: 10, Current Total: 10
//  Item: 11, Current Total: 21
// Starting new array
//  Item: 12, Current Total: 33
//  Item: 13, Current Total: 46
//  Item: 14, Current Total: 60
