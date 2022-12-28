﻿using System;
using System.Collections.Generic;
using System.Text;

namespace myfirstproject.CollectionDemo
{
    class StackDemo1
    {
        static void Main(string[] args)
        {
            Stack<string> s = new Stack<string>();
            s.Push("red");
            s.Push("green");
            s.Push("blue");
            foreach (var st in s)
            {
                Console.WriteLine(st);
            }
        }
    }
    class StackDemo2
    {
        static void Main(string[] args)
        {
            Stack<string> s = new Stack<string>();
            s.Push("red");
            s.Push("green");
            s.Push("blue");
            foreach(var st in s)
            {
                Console.WriteLine(st);
            }
            Console.WriteLine(".................PEEK..................");
            Console.WriteLine(".................CHECK.................");
            Console.WriteLine(s.Contains("blue"));
            Console.WriteLine(s.Peek());
            Console.WriteLine(".....................");
            foreach(var st in s)
            {
                Console.WriteLine(st);
            }
            s.Pop();
            Console.WriteLine(".........................POP............");
            foreach(var st in s)
            {
                Console.WriteLine(st);
            }
            Console.WriteLine(".......................");
            Console.WriteLine(s.Peek());
            Console.WriteLine(".........................");
            foreach(var st in s)
            {
                Console.WriteLine(st);
            }
            Console.WriteLine("...................Check.............");
            Console.WriteLine(s.Contains("blue"));
        }
    }
}
