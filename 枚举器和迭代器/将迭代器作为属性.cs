using System;
using System.Collections;

///将迭代器作为属性

class Spectrum
{
    bool _listFromUVtoIR;

    string[] colors = {"violet", "blue", "cyan", "green", "yellow", "orange", "red"};

    public Spectrum(bool listFromUVtoIR)
    {
        _listFromUVtoIR = listFromUVtoIR;
    }

    public IEnumerator GetEnumerator()
    {
        return _listFromUVtoIR ? UVtoIR : IRtoUV;
    }

    public IEnumerator UVtoIR
    {
        get
        {
            for(int i = 0; i < colors.Length; i++)
                yield return colors[i];
        }
    }

    public IEnumerator IRtoUV
    {
        get
        {
            for(int i = colors.Length - 1; i >= 0; i--)
                yield return colors[i];
        }
    }
}

class Program
{   
    static void Main()
    {
        Spectrum startUV = new Spectrum(true);
        Spectrum startIR = new Spectrum(false);

        foreach(string color in startUV)
            Console.Write("{0} ", color);
        Console.WriteLine();

        foreach(string color in startIR)
            Console.Write("{0} ", color);
        Console.WriteLine();
    }
}

//output:
// violet blue cyan green yellow orange red 
// red orange yellow green cyan blue violet 
