using System;
using System.Collections.Generic;
using System.Text;

namespace myfirstproject.ArithematicPrograms
{
    class Trimorphic
    {
        static void Main(string[] args)
        {
            int cube, LD;
            Console.WriteLine("Enter any number");
            int num = int.Parse(Console.ReadLine());
            cube = num * num * num;
            LD = cube % 10;
            if(num==LD)
            {
                Console.WriteLine("Trimorphic");
            }
            else
            {
                Console.WriteLine("Not Trimorphic");
            }

        }
    }
    class Average
    {
        static void Main(string[] args)
        {
            int x = 0;
            int sum = 0;
            int count = 0;
            Console.WriteLine("Enter any number");
            int num = int.Parse(Console.ReadLine());
            while (num>0)
            {
                x = num % 10;
                num = num / 10;
                Console.WriteLine(num);
                sum = sum + num;
                count++;
            }
            Console.WriteLine(sum);
            Console.WriteLine(count);
            Console.WriteLine("Average" + (sum/count));
        }
    }
    class Table
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter any num");
            int num = int.Parse(Console.ReadLine());
            for(int i=1; i<=10; i++)
            {
                Console.WriteLine(num*i);
            }
        }
    }
}
