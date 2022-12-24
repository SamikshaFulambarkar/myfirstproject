using System;
using System.Collections.Generic;
using System.Text;

namespace myfirstproject.ExceptionTask
{
    class ExceptionClass1
    {
        static string s = null;
        static void Main(string[] args)
        {
            try
            {
                if(s==null)
                {
                    throw new Exception();
                }
            }
            catch(Exception n)
            {
                Console.WriteLine("Handled.........."+n.ToString());
            }
            Console.WriteLine("Hello...");
        }
    }
    class ExceptionClass2
    {
        static string s = null;
        static void Main(string[] args)
        {
            try
            {
                s.ToLower();
            }
            catch (Exception n)
            {
                Console.WriteLine("Handled.........." + n.ToString());
            }
            Console.WriteLine("Hello...");
        }
    }
    class TestException
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello");
            int sum = 0;
            try
            {
                int x = 10 / sum;
            }
            catch(DivideByZeroException e)
            {
                Console.WriteLine("Handled......"+e.ToString());
            }
            Console.WriteLine("Hi");
            Console.WriteLine("Good");
        }
    }
    class TestException1
    {
        static void Main(string[] args)
        {
            int[] a = { 5, 6, 7 };
            try
            {
                a[4] = 89;
            }
            catch (Exception)
            {
                Console.WriteLine("Handled......" );
            }
            Console.WriteLine("Done");
        }
    }
    class TestException2
    {
        static void Main(string[] args)
        {
            int sum = 0;
            try
            {
                Console.WriteLine(10 / sum);
            }
            catch
            {
                Console.WriteLine("Handled......");
            }
            finally
            {
                Console.WriteLine("Finally executed");
            }
        }
    }
    class TestException3
    {
        static void Main(string[] args)
        {
            int sum = 2;
            try
            {
                Console.WriteLine(10 / sum);
            }
            finally
            {
                Console.WriteLine("Finally executed");
            }
            Console.WriteLine("hiii");
        }
    }
    class Multicatch
    {
        static void Main(string[] args)
        {
            int sum = 0;
            try
            {
                int[] a = new int[3];
                Console.WriteLine(a[4] / sum);
            }
            catch(DivideByZeroException e)
            {
                Console.WriteLine("//////////////"+e.ToString());
            }
            catch(IndexOutOfRangeException e1)
            {
                Console.WriteLine(".................."+e1.ToString());
            }
            catch(Exception e2)
            {
                Console.WriteLine(e2.ToString()+".....................");
            }
        }
    }
   class TestException4
    {
        public static void Check(int age)
        {
            if(age<18)
            {
                throw new Exception("Invalid age for driving........");
            }
            else
            {
                Console.WriteLine("age is valid for driving test.......");
            }
            Console.WriteLine("hiiiiii");
        }
        static void Main(string[] args)
        {
            try
            {
                TestException4.Check(20);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.WriteLine("Good");
        }
    }
    class NestedTryCatch
    {
        static void Main(string[] args)
        {
            int count = 0;
            try
            {
                count++;
                try
                {
                    count++;
                    try
                    {
                        count++;
                        throw new Exception();
                    }
                    catch(Exception e1)
                    {
                        count++;
                        throw e1;
                    }
                }
                catch(Exception e)
                {
                    count++;
                    throw e;
                }
            }
            catch
            {
                Console.WriteLine(count);
            }
        }
    }
}
