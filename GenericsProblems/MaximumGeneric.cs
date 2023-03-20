using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsProblems
{
    public class MaximumGeneric
    {
       public void FindMaxInt(int a, int b, int c)
        {
            if (a > b && a > c)
                Console.WriteLine("a is Maximum");
            if (b > a && b > c)
                Console.WriteLine("b is Maximum");
            if (c > a && c > b)
                Console.WriteLine("c is Maximum");
        }
        public void FindMaxFloat(float a, float b, float c)
        {
            if (a > b && a > c)
                Console.WriteLine("a is Maximum");
            if (b > a && b > c)
                Console.WriteLine("b is Maximum");
            if (c > a && c > b)
                Console.WriteLine("c is Maximum");
        }
    }
        
}
    
