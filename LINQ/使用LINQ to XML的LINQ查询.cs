using System;
using System.Xml.Linq;
using System.Linq;

///使用LINQ to XML的LINQ查询

class Program
{
    static void Main()
    {
        XDocument xd = new XDocument(
            new XElement("MyElements",
                new XElement("first",
                    new XAttribute("color", "red"),
                    new XAttribute("size", "small")),
                new XElement("second",
                    new XAttribute("color", "red"),
                    new XAttribute("size", "medium")),
                new XElement("third",
                    new XAttribute("color", "blue"),
                    new XAttribute("size", "large")))
        );

        XElement rt = xd.Element("MyElements");

        var xyz = from e in rt.Elements()
                  where e.Name.ToString().Length == 5
                  select e;
        
        foreach(XElement x in xyz)
            Console.WriteLine(x.Name.ToString());
        
        Console.WriteLine();
        foreach(XElement x in xyz)
            Console.WriteLine("Name: {0}, color: {1}, size: {2}", x.Name, x.Attribute("color").Value, x.Attribute("size").Value);
        
        var zyx = from e in rt.Elements()
                  select new {e.Name, color = e.Attribute("color")};     //创建匿名类型
        
        foreach(var x in zyx)
            Console.WriteLine(x);
        
        Console.WriteLine();
        foreach(var x in zyx)
            Console.WriteLine("{0, -6}, color: {1, -7}", x.Name, x.color.Value);
    }
}

//output:
// first
// third

// Name: first, color: red, size: small
// Name: third, color: blue, size: large
// { Name = first, color = color="red" }
// { Name = second, color = color="red" }
// { Name = third, color = color="blue" }

// first , color: red    
// second, color: red    
// third , color: blue  
