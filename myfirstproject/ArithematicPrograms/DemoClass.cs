using System;
using System.Collections.Generic;
using System.Text;

namespace myfirstproject.ArithematicPrograms
{
    class DemoClass
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the age");
            int age = int.Parse(Console.ReadLine());
           if((age<19)&&(age>13))
            {
                Console.WriteLine("Teenager");
            }
            else
            {
                Console.WriteLine("Not");
            }    
        }
    }
    class Automorphic_no
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter any num");
            int num = int.Parse(Console.ReadLine());
            int sqr=1, count = 0;
            int temp = num;
            while(num>0)
            {
                int digit = num % 10;
                count++;
                num = num / 10;
            }
            Console.WriteLine(count);
            num = temp;
            int power = 1;
            int Base = 10;
            sqr = num * num;
            for (int i = 1; i <= count; i++)
            {
                power=power*Base;
            }
            int last = sqr * power;
            if(num==last)
            {
                Console.WriteLine("Automorphic no.");
            }
            else
            {
                Console.WriteLine("Not automorphic no.");
            }

        }
    }
    class Kaprekar_no
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter any num");
            int num = int.Parse(Console.ReadLine());
            int count = 0, sum = 0;
            int temp = num;
            int sqr = num * num;
            {
                Console.WriteLine(sqr);
            }
            while(num>0)
            {
                count++;
            }
            Console.WriteLine(count);
            num=temp;
            int power = 1;
            int Base = 10;
            for(int i=1; i<=count; i++)
            {
                power = power * Base;
            }
            int digit = num % 10;
            int a = sum + digit;
            if(num==a)
            {
                Console.WriteLine("Kaprekar no.");
            }
            else
            {
                Console.WriteLine("Not Kaprekar no.");
            }
        }
    }
    class harshad_no
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter any num");
            int num = int.Parse(Console.ReadLine());
            int rem = 0, sum = 0;
            int temp=num;
            while(num>0)
            {
                rem = num % 10;
                sum = sum + rem;
                num = num / 10;
            }
            if(temp%sum==0)
            {
                Console.WriteLine("Harshad no.");
            }
            else
            {
                Console.WriteLine("Not harshad no.");
            }
        }
    }
    class plus_pattern
    {
        static void Main(string[] args)
        {
            for(int i=1; i<=5; i++)
            {
                if(i==((5/2)+1))
                {
                    Console.Write("+");
                }
                else
                {
                    for(int j=1; j<=5/2; j++)
                        Console.Write(" ");
                    Console.Write("+");
                }
                Console.Write("\n");
            }
        }
    }
    class series_1
    {
        static void Main(string[] args)
        {
            int sum = 0;
            for (int i = 1; i <= 10; i++)
            {
                sum = (sum * 10) + 1;
                int t = sum + 10;
                Console.Write(" ");
                Console.Write(sum);
            }
            Console.Write(" ");
        }
    }
    class demo_12
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter any number");
            int num = int.Parse(Console.ReadLine());
            if(num%2==0)
            {
                if(num>2 && num<8)
                {
                    Console.WriteLine("green color");
                }
                else
                {
                    Console.WriteLine("red color");
                }
            }
            else
            {
                if(num>8)
                {
                    Console.WriteLine("white color");
                }
                else
                {
                    Console.WriteLine("black color");
                }
            }
        }
    }
    class combo_pattern
    {
        static void Main(string[] args)
        {
            for(int i=1; i<=4; i++)
            {
                if(i%2==0)
                {
                    char ch = 'A';
                    for(int j=1; j<=i; j++)
                        {
                        Console.Write(ch);
                        ch++;
                        }
                }
                else
                {
                    for(int k=1; k<=i; k++)
                    {
                        Console.Write(k);
                    }
                }
            }
            Console.WriteLine(" ");
        }
    }
}
