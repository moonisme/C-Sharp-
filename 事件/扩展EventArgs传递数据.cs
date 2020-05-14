using System;

///扩展EventArgs传递数据
public class IncrementerEventArgs: EventArgs
{
    public int IterationCount
    {
        get;
        set;
    }
}

class Incrementer
{
    public event EventHandler<IncrementerEventArgs> CountedADozen;

    public void DoCount()
    {
        IncrementerEventArgs args = new IncrementerEventArgs();

        for(int i = 1; i < 100; i++)
            if(i % 12 == 0 && CountedADozen != null)
            {
                args.IterationCount = i;
                CountedADozen(this, args);   
            }
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
        incrementer.CountedADozen += IncrementDozensCount;
    }

    void IncrementDozensCount(object source, IncrementerEventArgs e)
    {
        Console.WriteLine("Incremented at iteration: {0} in {1}", e.IterationCount, source.ToString());
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
// Incremented at iteration: 12 in Incrementer
// Incremented at iteration: 24 in Incrementer
// Incremented at iteration: 36 in Incrementer
// Incremented at iteration: 48 in Incrementer
// Incremented at iteration: 60 in Incrementer
// Incremented at iteration: 72 in Incrementer
// Incremented at iteration: 84 in Incrementer
// Incremented at iteration: 96 in Incrementer
// Number of dozens = 8
