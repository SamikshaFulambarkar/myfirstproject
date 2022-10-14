using System;
using System.Collections.Generic;
using System.Text;

namespace myfirstproject.ArithematicPrograms
{
    class Percentage
    {
        static void Main(string[] args)
        {
            int eng, math, phy, chem, bio, total;
            double  avg ;
            eng = 75;
            math = 89;
            phy = 72;
            chem = 76;
            bio = 84;
            total = eng + math + phy + chem + bio;
            Console.WriteLine("Total of 5 Subjects=" + total);
            avg = total / 5;
            Console.WriteLine("\n Average of 5 Subjects=" + avg);  
            Console.WriteLine("\nPercentage of 5 subject=" + avg + "%");
        }
    }
}
