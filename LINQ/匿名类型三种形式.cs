using System;

///匿名类型三种形式
class Other
{
    static public string Name = "Marry Jones";
}

class Program
{
    static void Main()
    {
        string Major = "History";

        var student = new {Age = 19, Other.Name, Major};    //赋值形式，成员访问，标识符

        Console.WriteLine("{0}, Age {1}, Major: {2}", student.Name, student.Age, student.Major);
    }
}

//output:
// Marry Jones, Age 19, Major: History
