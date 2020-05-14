using System;

///泛型的栈
class MyStack<T>
{
    T[] StackArray;
    int StackPointer = 0;

    public void Push(T x)
    {
        if(!IsStackFull)
            StackArray[StackPointer++] = x;
    }

    public T pop()
    {
        return(!IsStackEmpty) ? StackArray[--StackPointer] :  StackArray[0];
    }

    const int MaxStack = 10;
    bool IsStackFull
    {
        get{return StackPointer >= MaxStack;}
    }

    bool IsStackEmpty
    {
        get{return StackPointer <= 0;}
    }

    public MyStack()
    {
        StackArray = new T[MaxStack];
    }

    public void Print()
    {
        for(int i = StackPointer-1; i >= 0; i--)
            Console.WriteLine("Value: {0}", StackArray[i]);
    }
}

class Program
{
    static void Main()
    {
        MyStack<int> StackInt = new MyStack<int>();
        MyStack<string> StackString = new MyStack<string>();

        StackInt.Push(3);
        StackInt.Push(5);
        StackInt.Push(7);
        StackInt.Push(9);
        StackInt.Print();

        StackString.Push("This is fun");
        StackString.Push("Hi there!");
        StackString.Print();
    }
}

//output:
// Value: 9
// Value: 7
// Value: 5
// Value: 3
// Value: Hi there!
// Value: This is fun
