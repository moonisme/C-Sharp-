using System;
using System.Xml.Linq;

///创建，保存，加载XML文档

class Program
{
    static void Main()
    {
        XDocument employees1 = 
            new XDocument(
                new XElement("Employees",
                    new XElement("Name", "Bob Smith"),
                    new XElement("Name", "Sally Jones")
            )
        );

        employees1.Save("EmployeesFile.xml");

        XDocument employees2 = XDocument.Load("EmployeesFile.xml");

        Console.WriteLine(employees2);
    }
}

//output:
// <Employees>
//   <Name>Bob Smith</Name>
//   <Name>Sally Jones</Name>
// </Employees>
