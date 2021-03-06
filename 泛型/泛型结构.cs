using System;

///泛型结构
struct PieceOfData<T>
{
    public PieceOfData(T value)
    {
        _data = value;
    }

    private T _data;
    public T Data
    {
        get { return _data; }
        set { _data = value; }
    }
}

class Program
{
    static void Main()
    {
        var intData = new PieceOfData<int>(10);
        var stringData = new PieceOfData<string>("Hi there.");

        Console.WriteLine("intData = {0}", intData.Data);
        Console.WriteLine("stringData = {0}", stringData.Data);
    }
}

//output:
// intData = 10
// stringData = Hi there.
