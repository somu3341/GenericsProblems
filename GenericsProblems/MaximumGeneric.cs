using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsProblems
{
    public class MaximumGeneric
    {

        public void FindMax<M>(M a, M b, M c) where M : IComparable
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
    
