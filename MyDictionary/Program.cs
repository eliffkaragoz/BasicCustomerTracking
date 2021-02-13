using System;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> myDictionary = new MyDictionary<int, string>();
            myDictionary.Add(1, "A");
            myDictionary.Add(2, "B");
            myDictionary.Add(3, "C");
            myDictionary.Add(4, "D");
            myDictionary.Add(5, "E");
        }
    }
}
