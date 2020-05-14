using System;

///索引器
namespace _indexer
{
    class Class1
    {
        int Temp0;
        int Temp1;
        public int this[int index]
        {
            get 
            { 
                return ( 0 == index ) ? Temp0 : Temp1; 
            }
            set 
            { 
                if( 0 == index )
                    Temp0 = value;
                else
                    Temp1 = value;  
            }
        }
    }
    class Program
    {
        static void Main()
        {
            Class1 a = new Class1();

            Console.WriteLine("Values -- T0: {0}, T1: {1}", a[0], a[1]);
            a[0] = 15;
            a[1] = 20;
            Console.WriteLine("Values -- T0: {0}, T1: {1}", a[0], a[1]);
        }
    }
}