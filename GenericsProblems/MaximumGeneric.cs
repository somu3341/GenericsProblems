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
        public void FindMaxString(string a, string b, string c)
        {
            if (a.CompareTo(b) > 0 && a.CompareTo(c) > 0)
                Console.WriteLine("a is Maximum");
            if (b.CompareTo(a) > 0 && b.CompareTo(a) > 0)
                Console.WriteLine("b is Maximum");
            if (c.CompareTo(a) > 0 && c.CompareTo(b) > 0)
                Console.WriteLine("c is Maximum");
        }
    }
        
}
    
