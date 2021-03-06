using System;

///协变
class Animal
{
    public int Legs = 4;
}

class Dog: Animal
{}

delegate T Factory<out T>();

class Program
{
    static Dog MakeDog()
    {
        return new Dog();
    }

    static void Main()
    {
        Factory<Dog> dogMaker = MakeDog;
        Factory<Animal> animalMaker = dogMaker;

        Console.WriteLine(animalMaker().Legs.ToString());
    }
}

//output:
// 4
