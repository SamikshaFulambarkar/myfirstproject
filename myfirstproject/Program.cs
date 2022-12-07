using System;

namespace myfirstproject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
    class OperatorUsed
    {
        static void Main(string[] args)
        {
            int a=10, b=10, c;
            c = a + b++;
            Console.WriteLine(c+" "+a+" "+b);
            c = a + (++b);
            Console.WriteLine("\n"+c+" "+a+" "+b);
        }
    }
    class Op1
    {
        static void Main(string[] args)
        {
            //int a = 10;
            //Console.WriteLine($"{a++} {a++} {++a}");
            //Console.WriteLine($"{a++} {--a} {--a} {a++} {++a}");
            int a = 5, b = 2, c;
            c = a * b + (a++ + --b) - b;
            Console.WriteLine(a+" "+b+" "+c);
        }
    }
    class Op2
    {
        static void Main(string[] args)
        {
            int i, kk;
            i = 6 / 4 + 4 / 4 + 8 - 2 + 5 / 8;
            kk = 3 / 2 * 4 + 3 / 8 + 3;
            Console.WriteLine(i+"  "+kk);
        }
    }
}
