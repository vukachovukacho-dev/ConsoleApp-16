using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp_16
{
    internal class pair<T1, T2>
    {
        public T1 First { get; set; }
        public T2 Second { get; set; }

        
        public pair(T1 first, T2 second)
        {
            First = first;
            Second = second;
        }
        public void Print()
        {
            Console.WriteLine($"first: {First}, second: {Second}");
        }
    }
}
