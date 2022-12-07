using System;
using System.Collections.Generic;
using System.Text;

namespace myfirstproject.OOPS_Encapsulation
{
    class OutKeyword
    {
        public static void arithmetic(int x, int y, out int a, out int s, out int m, out int d)
        {
            a = x + y;
            s = x - y;
            m = x * y;
            d = x / y;
        }
        static void Main(string[] args)
        {
            int a, b, add, sub, mul, div;
            Console.WriteLine("Enter first number");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number");
            b = int.Parse(Console.ReadLine());
            arithmetic(a, b, out add, out sub, out mul, out div);
            Console.WriteLine("Addition: "+add);
            Console.WriteLine("Subtraction: "+sub);
            Console.WriteLine("Multiplication: "+mul);
            Console.WriteLine("Division: "+div);
        }
    }
    class ParamKeyword
    {
        public static void Add(params int[] nos)
        {
            int sum = 0;
            foreach (int n in nos)
                sum = sum + n;
            Console.WriteLine("Addition of "+nos.Length+" Parameters is "+sum);
        }
        public static void AddName(params string[] names)
        {
            string s = "";
            foreach (string str in names)
                s = s + str;
            Console.WriteLine("Concatinates string is "+s);
        }
        static void Main(string[] args)
        {
            Add();
            Add(1, 2);
            Add(1, 2, 3);
            Add(1, 2, 3, 4, 5);
            Add(1, 2, 3, 12, 50, 18, 10);
            AddName("Hello");
        }
    }
    class ParamKeyword2
    {
        public static void Add(params int[] nos)
        {
            int sum = 0;
            foreach (int n in nos)
                sum = sum + n;
            int Avg = sum / nos.Length;
            Console.WriteLine("Average " + Avg);
        }
        static void Main(string[] args)
        {
            Add(1, 2);
            Add(1, 2, 3);
            Add(1, 2, 3, 4, 5);
            Add(1, 2, 3, 12, 50, 18, 10);
        }
    }
}
