using System;

/// 事件 发布者订阅者
delegate void Handler();         //声明委托

class Incrementer
{
    public event Handler CountedADozen;      //创建事件并发布

    public void DoCount()
    {
        for(int i = 1; i < 100; i++)
            if(i % 12 == 0 && CountedADozen != null)
                CountedADozen();             //触发
    }
}

class Dozens
{
    public int DozensCount
    {
        get;
        private set;
    }

    public Dozens(Incrementer incrementer)
    {
        DozensCount = 0;
        incrementer.CountedADozen += IncrementDozensCount;     //订阅事件
    }

    void IncrementDozensCount()        //声明事件处理程序
    {
        DozensCount++;
    }
}

class Program
{
    static void Main()
    {
        Incrementer incrementer = new Incrementer();
        Dozens dozensCounter = new Dozens(incrementer);

        incrementer.DoCount();
        Console.WriteLine("Number of dozens = {0}", dozensCounter.DozensCount);
    }
}

//output:
// Number of dozens = 8
