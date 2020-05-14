using System;
using System.Linq;

///查询
class Program
{
    public class Student
    {
        public int ID_1;
        public string LastName;
    }

    public class CourseStudent
    {
        public string CourseName;
        public int ID_2;
    }

    static Student[] students = new Student[]
    {
        new Student {ID_1 = 1, LastName = "Carson"},
        new Student {ID_1 = 2, LastName = "Klassen"},
        new Student {ID_1 = 3, LastName = "Fleming"},
    };

    static CourseStudent[] studentsInCourses = new CourseStudent[]
    {
        new CourseStudent {CourseName = "Art", ID_2 = 1},
        new CourseStudent {CourseName = "Art", ID_2 = 2},
        new CourseStudent {CourseName = "History", ID_2 = 1},
        new CourseStudent {CourseName = "History", ID_2 = 3},
        new CourseStudent {CourseName = "Physics", ID_2 = 3},
    };

    static void Main()
    {
        var query = from s in students join c in studentsInCourses on s.ID_1 equals c.ID_2
                    where c.CourseName == "History"
                    select s.LastName;
        
        foreach(var q in query)
            Console.WriteLine("Student taking History: {0}", q);
    }
}

//output:
// Student taking History: Carson
// Student taking History: Fleming
