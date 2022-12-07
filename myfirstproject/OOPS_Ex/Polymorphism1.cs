using System;
using System.Collections.Generic;
using System.Text;

namespace myfirstproject.OOPS_Encapsulation
{
    class Polymorphism1
        //Method Overloading//
    {
        int a, b;
        public void GetInfo(int a, int b)
        {
            this.a = a;
            this.b = b;
        }
        public void GetInfo()
        {
            this.a = 1;
            this.b = 8;
        }
        public void GetInfo(int n)
        {
            a = b = n;
        }
        public int Greatest()
        {
            if (a > b)
                return a;
            else
                return b;
        }
        public void PutInfo()
        {
            Console.WriteLine("Greatest is:=" + Greatest());
        }
        static void Main(string[] args)
        {
            Polymorphism1 P = new Polymorphism1();
            P.GetInfo();
            P.PutInfo();
        }
    }
}
