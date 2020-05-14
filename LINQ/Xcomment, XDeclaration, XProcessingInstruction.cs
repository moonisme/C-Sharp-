using System;
using System.Xml.Linq;

/// Xcomment, XDeclaration, XProcessingInstruction
class Program
{
    static void Main()
    {
        XDocument xd = new XDocument(
            new XDeclaration("1.0", "utf-8", "yes"),
            new XComment("This is a comment"),
            new XProcessingInstruction("xml-stylesheet", @"href=""stories.css"" type=""text/css"""),
            new XElement("root",
                new XElement("first"),
                new XElement("second")
            )
        );

        Console.WriteLine(xd);      //不显示声明
    }
}

//output:
// <!--This is a comment-->
// <?xml-stylesheet href="stories.css" type="text/css"?>
// <root>
//   <first />
//   <second />
// </root>
