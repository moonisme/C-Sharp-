using System;

///构造函数
namespace constructor
{
    class Class1
    {
        int id;
        string Name;

        public Class1() { id = 28; Name = "Nemo"; }
        public Class1(int val) { id = val; Name = "Nemo"; }
        public Class1(String name) { Name = name; }

        public void SoundOff()
        {
            Console.WriteLine("Name {0}, Id {1}", Name, id);
        }
    }
    class Program
    {
        static void Main()
        {
            Class1 a = new Class1();
            Class1 b = new Class1(7);
            Class1 c = new Class1("Bill");

            a.SoundOff();
            b.SoundOff();
            c.SoundOff();
        }
    }
}
