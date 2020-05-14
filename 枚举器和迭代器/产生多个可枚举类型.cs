using System;
using System.Collections;

///产生多个可枚举类型
class Spectrum
{
    string[] colors = {"violet", "blue", "cyan", "green", "yellow", "orange", "red"};

    public IEnumerable UVtoIR()
    {
        for(int i = 0; i < colors.Length; i++)
            yield return colors[i];
    }

    public IEnumerable IRtoUV()
    {
        for(int i = colors.Length - 1; i >=0; i--)
            yield return colors[i];
    }
}

class Program
{
    static void Main()
    {
        Spectrum spectrum = new Spectrum();

        foreach(string color in spectrum.UVtoIR())
            Console.Write("{0} ", color);
        Console.WriteLine();

        foreach(string color in spectrum.IRtoUV())
            Console.Write("{0} ", color);
        Console.WriteLine();
    }
}

//output:
// violet blue cyan green yellow orange red 
// red orange yellow green cyan blue violet 
