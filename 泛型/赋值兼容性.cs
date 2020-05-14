using System;

///赋值兼容性
class Animal
{
    public int NumberOfLegs = 4;
}

class Dog: Animal
{}

class Program
{
    static void Main()
    {
        Animal a1 = new Animal();
        Animal a2 = new Dog();

        Console.WriteLine("Number of dog legs:{0}", a2.NumberOfLegs);
    }
}

//output:
// Number of dog legs:4
