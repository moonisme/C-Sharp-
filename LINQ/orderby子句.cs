using System;
using System.Linq;

///orderby子句

class Program
{
    static void Main()
    {
        var students = new[]
        {
            new {LName = "Jones", FNname = "Mary", Age = 19, Major = "History"},
            new {LName = "Smith", FNname = "Bob", Age = 20, Major = "CompSci"},
            new {LName = "Fleming", FNname = "Carol", Age = 21, Major = "History"},
        };
    
    var query = from student in students
                orderby student.Age
                select student;
    
    foreach(var s in query)
        Console.WriteLine("{0}, {1}: {2} - {3}", s.LName, s.FNname, s.Age, s.Major);
    }
}

//output:
// Jones, Mary: 19 - History
// Smith, Bob: 20 - CompSci
// Fleming, Carol: 21 - History
