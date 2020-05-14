using System;

///多步用户自定义转换
class Employee: Person
{}

class Person
{
    public string Name;
    public int Age;

    public static implicit operator int(Person p)
    {
        return p.Age;
    }
}

class Program
{
    static void Main()
    {
        Employee bill = new Employee();
        bill.Name = "William";
        bill.Age = 25;
        
        float fVar = bill;
        Console.WriteLine("Person Info: {0}, {1}", bill.Name, fVar);
    }
}

//output:
// Person Info: William, 25
