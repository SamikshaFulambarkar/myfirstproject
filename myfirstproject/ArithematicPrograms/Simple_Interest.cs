using System;
using System.Collections.Generic;
using System.Text;

namespace myfirstproject.ArithematicPrograms
{
    class Simple_Interest
    {
        static void Main(string[] args)
        {
            int P, R, T;
            double SI;
            P = 3600;
            R = 7; 
            T = 5;
            SI = (P * R * T)/100;
            Console.WriteLine("SI=" + SI);
        }
        
    }

    class Conversion
    {
        static void Main(string[] args)
        {
            int cm;
            double m, km;
            cm = 6540;
            m = 6540 / 100;
            km = 6540 / 100000;
            Console.WriteLine("Enter Length in cm=" + cm + "cm");
            Console.WriteLine("\n Convert cm to m=" + m + "m");
            Console.WriteLine("\n Convert cm to km=" + km + "km");
        }
    }

    class Convert_Demo
    {
        static void Main(string[] args)
        {
            int C;
            double F;
            C = 20;
            F = (C * 1.8) + 32;
            Console.WriteLine("Enter the temperature in celcius=" + C + "C");
            Console.WriteLine("\nConvert Celcius to Fahrenheit=" + F + "F");
        }
    }

    class Convert_2
    {
        static void Main(string[] args)
        {
            int F;
            double C;
            F = 80;
            C = (F - 32) * 0.5556;
            Console.WriteLine("Enter the temperature in Fahrenheit=" + F + "F");
            Console.WriteLine("\nConvert Fahrenheit to celcius=" + C + "C");
        }
    }

    class Convert_3
    {
        static void Main(string[] args)
        {
            int ndays, year, week, days, Days_in_week;
            Days_in_week = 7;
            Console.WriteLine("Enter the number of days");
            ndays = int.Parse(Console.ReadLine());
            year = ndays / 365;
            week = (ndays % 365) / Days_in_week;
            days = (ndays % 365) % Days_in_week;
            Console.WriteLine("{0} is equivalent to {1}years , {2}weeks and {3}days" , ndays , year , week , days);
            Console.ReadLine();
        }
    }
}
