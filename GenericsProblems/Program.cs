using System;
using System.Security.Cryptography;

namespace GenericsProblems
{
    class Program
    {
        static void Main(string[] args)
        {
            MaximumGeneric maximumGeneric = new MaximumGeneric();
            maximumGeneric.Print<int>(1,29,6);
        }
    }
}