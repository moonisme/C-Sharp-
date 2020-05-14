using System;
using System.Collections;

///使用迭代器创建枚举器
class MyClass
{
    public IEnumerator GetEnumerator()
    {
        return BlackAndWhite();
    }

    public IEnumerator BlackAndWhite()  //返回枚举器
    {
        yield return "black";
        yield return "gray";
        yield return "white";
    }
}

class Program
{
    static void Main()
    {
        MyClass mc = new MyClass();

        foreach(string shade in mc)
            Console.WriteLine(shade);
    }
}

//output:
// black
// gray
// white
