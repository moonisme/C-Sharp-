using System;
using System.Xml.Linq;

///增加节点

class Program
{
    static void Main()
    {
        XDocument xd = new XDocument(
            new XElement("root",
                new XElement("first")
            )
        );

        Console.WriteLine("Orginal tree");
        Console.WriteLine(xd);
        Console.WriteLine();

        XElement rt = xd.Element("root");
        rt.Add(new XElement("second"));
        rt.Add(new XElement("third"),
               new XComment("Important Comment"),
               new XElement("fourth"));

        Console.WriteLine("Modified tree");
        Console.WriteLine(xd);
    }
}

//output:
// Orginal tree
// <root>
//   <first />
// </root>

// Modified tree
// <root>
//   <first />
//   <second />
//   <third />
//   <!--Important Comment-->
//   <fourth />
// </root>
