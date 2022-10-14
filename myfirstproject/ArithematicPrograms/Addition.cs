using System;
using System.Collections.Generic;
using System.Text;

namespace myfirstproject.ArithematicPrograms
{
    class Addition
    {
        static void Main(string[]args)
        {
            int num1, num2, result;
            num1 = 23;
            num2 = 45;
            result = num1 + num2;
            Console.WriteLine("Addition=" + result);
        }
    }

    class Subtraction
    {
        static void Main(string[]args)
        {
            int num1, num2, result;
            num1 = 50;
            num2 = 30;
            result = num1 - num2;
            Console.WriteLine("Subtraction=" + result);
        }
    }

    class Multiplication
    {
        static void Main(string[]args)
        {
            int num1, num2, result;
            num1 = 5;
            num2 = 6;
            result = num1 * num2;
            Console.WriteLine("Multiplication=" + result);
        }
    }

    class Division
    {
        static void Main(string[]args)
        {
            int num1, num2, result;
            num1 = 15;
            num2 = 3;
            result = num1 / num2;
            Console.WriteLine("Division=" + result);
        }
    }

    class Area_of_rectangle
    {
        static void Main(string[]args)
        {
            int l, b, result;
            l = 5;
            b = 3;
            result = l * b;
            Console.WriteLine("Area of Rectangle=" + result);
        }
    
    }

    class Area_of_Square
    {
        static void Main(string[]args)
        {
            int side1, side2, result;
            side1 = 4;
            side2 = 4;
            result = side1 * side2;
            Console.WriteLine("Area of Square=" + result);
        }
    }

    class Cube
    {
        static void Main(string[] args)
        {
            int num, result;
            num = 3;
            result = num * num * num;
            Console.WriteLine("Cube=" + result);
        }
    }

    class Area_of_Circle
    {
        static void Main(string[]args)
        {
            int r = 5;
            double result;
            result = 3.14 * r * r;
            Console.WriteLine("Area of Circle=" + result);
        }
    }

    class Area_of_Triangle
    {
        static void Main(string[]args)
        {
            int b, h;
            double result;
            b = 6;
            h = 4;
            result = 0.5 * b * h;
            Console.WriteLine("Area of Triangle=" + result);
        }
    }

    class Swap_of_two_numbers
    {
        static void Main(string[]args)
        {
            int num1, num2, num3;
            num1 = 5;
            num2 = 3;
            Console.WriteLine("Before swapping");
            Console.WriteLine("\nFirst number=" + num1);
            Console.WriteLine("\nSecond number=" + num2);
            num3 = num1;
            num1 = num2;
            num2 = num3;
            Console.WriteLine("\nAfter swapping");
            Console.WriteLine("\nFirst number=" + num1);
            Console.WriteLine("\nSecond number=" + num2);
        }
    }

    class Perimeter_of_Rectangle
    {
        static void Main(string[] args)
        {
            int l, b, result;
            l = 7;
            b = 4;
            result = 2 * (l + b);
            Console.WriteLine("Perimeter of Rectangle=" + result);
        }
    }

    class Area_of_an_Equilateral_Triangle
    {
        static void Main(string[] args)
        {
            int side;
            double result;
            side = 7;
            result = 0.433 * side * side;
            Console.WriteLine("Area of an Equilateral Triangle=" + result);
        }
    }

    class Expression
    {
        static void Main(string[] args)
        {
            double a, b, c, d, result;
            a = 25.5;
            b = 3.5;
            c = 40.5;
            d = 4.5;
            result = ((a * b - b * b) / (40.5 - 4.5));
            Console.WriteLine("Expression=" + result);
        }
    }
        
    class Expression_2
    {
        static void Main(string[] args)
        {
            double a, b, result;
            a = 4.0;
            b = 1.0;
            result = a * (1 - (b / 3) + (b / 5) - (b / 7) + (b / 9) - (b / 11));
            Console.WriteLine("Expression=" + result);
        }
    }
     
}
