using System;

///is运算符 转换不成功抛出InvalidCastException
class Employee: Person
{}

class Person
{
    public string Name = "Anonymous";
    public int Age = 25;
}

class Program
{
    static void Main()
    {
        Employee bill = new Employee();
        Person p;

        if(bill is Person)
        {
            p = bill;
            Console.WriteLine("Person Info: {0}, {1}", p.Name, p.Age);
        }
    }
}

//output:
// Person Info: Anonymous, 25
