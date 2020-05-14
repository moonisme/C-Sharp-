using System;

///Array方法
namespace _array
{
    class Program
    {
        public static void PrintArray(int[] a)
        {
            foreach(var x in a)
                Console.Write("{0} ", x);
            Console.WriteLine("");
        }

        static void Main()
        {
            int[] arr = new int[] { 15, 20, 5, 25, 10};
            PrintArray(arr);

            Array.Sort(arr);
            PrintArray(arr);

            Array.Reverse(arr);
            PrintArray(arr);

            Console.WriteLine("");
            Console.WriteLine("Rank = {0}, Length = {1}", arr.Rank, arr.Length);
            Console.WriteLine("GetLength(0)     = {0}", arr.GetLength(0));
            Console.WriteLine("GetType()        = {0}", arr.GetType());
        }
    }
}

//output:
// 15 20 5 25 10 
// 5 10 15 20 25 
// 25 20 15 10 5 

// Rank = 1, Length = 5
// GetLength(0)     = 5
// GetType()        = System.Int32[]
