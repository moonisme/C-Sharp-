using System;

///不同类实现一个接口
interface ILiveBirth
{
    string BabyCalled();
}

class Animal
{}

class Cat: Animal, ILiveBirth
{
    string ILiveBirth.BabyCalled()
    {
        return "kitten";
    }
}

class Dog: Animal, ILiveBirth
{
    string ILiveBirth.BabyCalled()
    {
        return "puppy";
    }
}

class Bird: Animal
{}

class Program
{
    static void Main()
    {
        Animal[] animalArray = new Animal[3];
        animalArray[0] = new Cat();
        animalArray[1] = new Dog();
        animalArray[2] = new Bird();

        foreach(Animal a in animalArray)
        {
            ILiveBirth b = a as ILiveBirth;
            if(b != null)
                Console.WriteLine("Baby is called: {0}", b.BabyCalled());
        }
    }
}

//output
// Baby is called: kitten
// Baby is called: puppy
