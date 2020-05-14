using System;

///静态构造函数
namespace static_func
{
    class RandomNumberClass
    {
        private static Random RandomKey;

        static RandomNumberClass()
        {
            RandomKey = new Random();
        }

        public int GetRandomNumber()
        {
            return RandomKey.Next();
        }
    }
    class Program
    {
        static void Main()
        {
            RandomNumberClass a = new RandomNumberClass();
            RandomNumberClass b = new RandomNumberClass();

            Console.WriteLine("Next Random #: {0}", a.GetRandomNumber());
            Console.WriteLine("Next Random #: {0}", b.GetRandomNumber());
        }
    }
}
