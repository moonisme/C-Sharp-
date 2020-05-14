using System;
using System.Linq;

///group子句

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
                    group student by student.Major;
        
        foreach(var s in query)
        {
            Console.WriteLine("{0}", s.Key);

            foreach(var t in s)
                Console.WriteLine("---{0}, {1}", t.LName, t.FNname);
        }
    }
}

//output:
// History
// ---Jones, Mary
// ---Fleming, Carol
// CompSci
// ---Smith, Bob
