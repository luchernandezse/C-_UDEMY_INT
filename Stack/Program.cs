using System;
using System.CodeDom;

partial class Program
{
    static void Main()
    {
        // Create object _list
        Stack _list = new Stack();

        // Push elements
        _list.Push(1);
        _list.Clear();
        _list.Push("bull");
        _list.Push(3);


        // Pop elements from the stack

        Console.WriteLine(_list.Pop());
        Console.WriteLine(_list.Pop());
        Console.WriteLine(_list.Pop());
        Console.WriteLine(_list.Pop());
        


    }
}