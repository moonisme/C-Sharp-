using System;
using System.Xml.Linq;

///使用XML特性

class program
{
    static void Main()
    {
        XDocument xd = new XDocument(
            new XElement("root",
                new XAttribute("color", "red"),
                new XAttribute("size", "large"),
                new XElement("first")
            )
        );

        Console.WriteLine(xd);
        Console.WriteLine();

        XElement rt = xd.Element("root");

        XAttribute color = rt.Attribute("color");   //获取特性
        XAttribute size = rt.Attribute("size");

        Console.WriteLine("color is {0}", color.Value);
        Console.WriteLine("size is {0}", size.Value);
        Console.WriteLine();

        rt.Attribute("color").Remove();     //移除color特性
        rt.SetAttributeValue("size", null); //移除size特性

        rt.SetAttributeValue("size", "medium");
        rt.SetAttributeValue("width", "narrow");

        Console.WriteLine(xd);
    }
}

//output:
// <root color="red" size="large">
//   <first />
// </root>

// color is red
// size is large

// <root size="medium" width="narrow">
//   <first />
// </root>
