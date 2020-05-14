using System;
using System.Collections;

///使用迭代器创建可枚举类型
class MyClass
{
    public IEnumerator GetEnumerator()
    {
        IEnumerable myEnumerable = BlackAndWhite(); //获取可枚举类型
        return myEnumerable.GetEnumerator();    //获取枚举器
    }

    public IEnumerable BlackAndWhite() //返回可枚举类型
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

        foreach(string shade in mc) //使用类对象
            Console.WriteLine("{0}", shade);

        foreach(string shade in mc.BlackAndWhite()) //使用类枚举器方法
            Console.WriteLine("{0}", shade);
    }
}

//output:
// black
// gray
// white
// black
// gray
// white
