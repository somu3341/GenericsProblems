using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsProblems
{
    public class MaximumGeneric<M> where M : IComparable
    {
        public M a, b, c;
        public MaximumGeneric(M a, M b, M c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public void FindMaxNum() 
        {
            if (this.a.CompareTo(this.b) > 0 && this.a.CompareTo(this.c) > 0)
                Console.WriteLine("a is Maximum");
            if (this.b.CompareTo(this.a) > 0 && this.b.CompareTo(this.a) > 0)
                Console.WriteLine("b is Maximum");
            if (this.c.CompareTo(this.a) > 0 && this.c.CompareTo(this.b) > 0)
                Console.WriteLine("c is Maximum");
        }
    }
        
}
    
