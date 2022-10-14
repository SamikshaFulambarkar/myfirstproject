using System;
using System.Collections.Generic;
using System.Text;

namespace myfirstproject.LoopsDemo
{
    class AllLoops
    {
        static void Main(string[] args)
        {
            for (int i=1; i<=4; i++)
            {
                for (int k=4; k>i; k--)
                {
                    Console.Write(" ");
                }
                for(int j=1; j<=i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
    class Pattern_1
    {
        static void Main(string[] args)
        {
            for(int i=1; i<=5; i++)
            {
                for(int j=5; j>=i; j--)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
        }
    }
    class Pattern_2
    {
        static void Main(string[] args)
        {
            for(char i='A'; i<='D'; i++)
            {
                for(char j='A'; j<=i; j++ )
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
        }
    }
    class Pattern_3
    {
        static void Main(string[] args)
        {
            for(int i=1; i<=4; i++)
            {
                for(int j=1; j<=i; j++)
                    if(j%2==0)
                    {
                        Console.Write("0");
                    }
                else
                    {
                        Console.Write("1");
                    }
                Console.WriteLine();
            }
        }
    }
    class Pattern_4
    {
        static void Main(string[] args)
        {
            for(int i=1; i<=4; i++)
            {
                for(int j=1; j<=i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
    class Pattern_5
    {
        static void Main(string[] args)
        {
            for(char i='A'; i<='D'; i++)
            {
                for(char j='D'; j>=i; j--)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
        }
    }
    class Pattern_6
    {
        static void Main(string[] args)
        {
            for(int i=1; i<=3; ++i)
            {
                for(int j=1; j<=3-1; ++j)
                {
                    Console.Write(i);
                }
                Console.WriteLine();
            }
        }
    }
}
