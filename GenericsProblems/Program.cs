using System;
using System.Security.Cryptography;

namespace GenericsProblems
{
    class Program
    {
        static void Main(string[] args)
        {
            MaximumGeneric maximumGeneric = new MaximumGeneric();
            maximumGeneric.Integer<int>(1,29,6);
            maximumGeneric.Float<float>(29,2,5);
        }
    }
}