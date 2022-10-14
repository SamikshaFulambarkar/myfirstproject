using System;
using System.Collections.Generic;
using System.Text;

namespace myfirstproject.Assignment_2
{
    class Assgn
    {
        static void Main(string[] args)
        {
            for(int i=1; i<=100; i++)
            {
                if((i%5!=0)&&(i%10!=0))
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
    class Spy_number
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter any number");
            int num = int.Parse(Console.ReadLine());
            int sum = 0, product = 1, rem;
            while(num!=0)
            {
                rem = num % 10;
                sum = sum + rem;
                product = product * rem;
                num = num / 10;
            }
            Console.WriteLine(sum+" "+product);
            if(sum==product)
            {
                Console.WriteLine("Given no. is Spy number");
            }
            else
            {
                Console.WriteLine("Given no. is not Spy number");
            }
            
                
        }
    }
    class Trimorphic_1
    {
        static void Main(string[] args)
        {
            int cube, LD;
            Console.WriteLine("Enter any number");
            int num = int.Parse(Console.ReadLine());
            cube = num * num * num;
            LD = cube % 10;
            if (num == LD)
            {
                Console.WriteLine("Trimorphic");
            }
            else
            {
                Console.WriteLine("Not Trimorphic");
            }

        }
    }
    class Series
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the no. for series");
            int num = int.Parse(Console.ReadLine());
            for (int i = 1; i <= num; i++)
            {
                num = (i * i) + (i * i * i);
            }
            Console.WriteLine(num);

        }
    }
    class fibbo_Series
    {
        static void Main(string[] args)
        {
            int f1 = 0, f2 = 1, f3 = 0;
            for(int i=0; i<=20; i++)
            {
                f3 = f1 + f2;
                Console.WriteLine(f3);
                f1 = f2;
                f2 = f3;
            }
            Console.ReadLine();
        }
    }
    class fact_sum
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter any number");
            int num = int.Parse(Console.ReadLine());
            int temp = num;
            int sum = 0;
            while(num>0)
            {
                int n = num % 10;
                int fact = 1;
                for(int i=1; i<=n; i++)
                {
                    fact = fact * i;
                }
                sum = sum + fact;
                num = num / 10;
            }
            Console.WriteLine(sum);
        }
    }
    class output_1
    {
        static void Main(string[] args)
        {
            int i = 1;
            while(i<=5)
            {
                int j = 1;
                while(j<=5)
                {
                    if(j==2)
                    {
                        break;
                        Console.WriteLine(j);
                    }
                    j++;
                }
                Console.WriteLine(i);
            }
        }
    }
    class output_2
    {
        static void Main(string[] args)
        {
            int i = 1, k = 1;
            while(i++<=5)
            {
                k *= i;
            }
            Console.WriteLine("k="+k+"i="+i);
        }
    }
    class output_3
    {
        static void Main(string[] args)
        {
            int b = 0;
            do
            {
                int a = 2;
                b++;
                Console.WriteLine(a++);
            }
            while (b != 3);
        }
    }
    class output_4
    {
        static void Main(string[] args)
        {
            for(int i=5; i>0; i--)
            {
                int mysteryInt = 100;
                mysteryInt = i;
                Console.WriteLine(mysteryInt);
            }
        }
    }
}
