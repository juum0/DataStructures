using System;
using System.Collections.Generic;

namespace StringReverseStack
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter your string");
            string word = Console.ReadLine();
            Stack<char> sWords = new Stack<char>();
            foreach (char c in word)
                sWords.Push(c);
            foreach (char c in word)
                Console.Write(sWords.Pop());
        }

    }
}
