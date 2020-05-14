using System;

///基类访问
namespace _derived
{
    class SomeClass
    {
        public string Field1 = "Field1 -- In the base class";
    }

    class OtherClass: SomeClass
    {
        new public string Field1 = "Field1 -- in the derived class";

        public void PrintField1()
        {
            Console.WriteLine(Field1);
            Console.WriteLine(base.Field1);
        }
    }

    class Program
    {
        static void Main()
        {
            OtherClass oc = new OtherClass();
            oc.PrintField1();
        }
    }
}
