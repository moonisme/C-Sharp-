using System;

///矩形数组
namespace _array
{
    class Program
    {
        static void Main()
        {
            int total = 0;
            int[,] arr1 = {{10, 11}, {12, 13}};

            foreach(int element in arr1)
            {
                total += element;
                Console.WriteLine("Element: {0}, Current Total: {1}", element, total);
            }
        }
    }
}

//output:
// Element: 10, Current Total: 10
// Element: 11, Current Total: 21
// Element: 12, Current Total: 33
// Element: 13, Current Total: 46
