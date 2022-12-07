using System;
using System.Collections.Generic;
using System.Text;

namespace myfirstproject.ArrProgram
{
    class Upper_String_Method_Arr
    {
        static void Main(string[] args)
        {
            string myName = "myName is Samiksha";
            myName = myName.ToUpper();
            Console.WriteLine(myName);
        } 
    }
    class Lower_String_Method_Arr
    {
        static void Main(string[] args)
        {
            string myName = "myName is RITA";
            myName = myName.ToLower();
            Console.WriteLine(myName);
        }
    }
    class Trim_String_Method_Arr
    {
        static void Main(string[] args)
        {
            string myName = "myName is AKANSHA";
            myName = myName.Trim();
            Console.WriteLine(myName);
        }
    }
    class TrimEnd_String_Method_Arr
    {
        static void Main(string[] args)
        {
            string myName = "myName is SHRIKANT";
            myName = myName.TrimEnd();
            Console.WriteLine(myName+" "+"Done");
        }
    }
    class TrimStart_String_Method_Arr
    {
        static void Main(string[] args)
        {
            string myName = "myName is SHRIKANT";
            myName = myName.TrimStart();
            Console.WriteLine(myName + " " + "Done");
        }
    }
    class Contains_String_Method_Arr
    {
        static void Main(string[] args)
        {
            string myName = "myName is SUDHANSHU";
            bool isContains = myName.Contains("SUDHANSHU1");
            Console.WriteLine(isContains);
        }
    }
    class Char_String_Method_Arr
    {
        static void Main(string[] args)
        {
            string myName = "myName is SWAYAM";
            char[] charArray = myName.ToCharArray();
            foreach(char c in charArray)
            {
                Console.WriteLine(c);
            }
        }
    }
    class Substring_String_Method_Arr
    {
        static void Main(string[] args)
        {
            string myName = "myName is SARTHAK";
            myName = myName.Substring(0, 6);
            Console.WriteLine(myName);
        }
    }
    class StartWith_String_Method_Arr
    {
        static void Main(string[] args)
        {
            string myName = "myName is VAISHALI";
            bool isContains = myName.StartsWith("my");
            Console.WriteLine(isContains);
        }
    }
    class SplitSentence_String_Method_Arr
    {
        static void Main(string[] args)
        {
            string myName = "myName/is/SANDEEP";
            string[] breakMysentence = myName.Split('/');
            foreach(string data in breakMysentence)
                Console.WriteLine(data);
        }
    }
}
