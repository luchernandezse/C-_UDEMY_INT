using System;
using System.Collections.Generic;

partial class Program
{
    public class Stack
    {
        public List<object> _list = new List<object>();

        public Stack()
        {

        }
        public void Push(object num)
        {
            if (num == null)
            {
                throw new InvalidOperationException("Cannot add null object");
            }
            _list.Insert(0,num);
        }
        public object Pop()
        {
            int elem = _list.Count;
            if (elem < 1)
            {
                throw new InvalidOperationException("No elements to show");

            }
            object a= _list[0];
            _list.RemoveAt(0);
            return a;
            
            
        }
        public void Clear()
        {
            _list.Clear();
        }
    }
}