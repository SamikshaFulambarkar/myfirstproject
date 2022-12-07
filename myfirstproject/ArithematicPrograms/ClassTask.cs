using System;
using System.Collections.Generic;
using System.Text;

namespace myfirstproject.ArithematicPrograms
{
    class ClassTask
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter any number");
            int num = int.Parse(Console.ReadLine());
            int sum = 0;
            while(num>0)
            {
                int r = num % 10;
                if(r%2!=0)
                {
                    sum = sum + r;
                }
                num = num / 10;
            }
            Console.WriteLine(sum);
        }
    }
    class ClassTask_1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter any number");
            int num = int.Parse(Console.ReadLine());
            int sum = 0, temp, r;
            temp = num;
            while (num > 0)
            {
                r = num % 10;
                sum = (sum * 10) + r;
                num = num / 10;
            }
            if(temp==sum)
            {
                Console.WriteLine("palindrome number");
            }
            else
            {
                Console.WriteLine("not palindrome");
            }
        }
    }
    class ClassTask_3
    {
        static void Main(string[] args)
        {
            for(int i=1; i<=10; i++)
            {
                for(int j=1; j<=10; j++)
                {
                    Console.Write(i*j+" ");
                }
                Console.WriteLine(" ");
            }
        }
    }
    class ClassTask_4
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter any number");
            int num = int.Parse(Console.ReadLine());
            int count = 0;
            if (num == 0 || num == 1)
                count = 1;
            {
                for(int i=2; i<=num/2; i++)
                {
                    if(num%i==0)
                    {
                        count = 1;
                        break;
                    }
                }
            }
            if(count==0)
            {
                Console.WriteLine("prime number");
            }
            else
            {
                Console.WriteLine("not prime number");
            }
        }
    }
    class ClassTask_5
    {
        static void Main(string[] args)
        {
            int i, num = 1, count;
            while(num<=100)
            {
                count = 0;
                i = 2;
                while(i<=num/2)
                {
                    if(num%i==0)
                    {
                        count++;
                        break;
                    }
                    i++;
                }
                if(count==0 && num!=1)
                {
                    Console.WriteLine(num);
                }
                num++;
            }
        }
    }
}

