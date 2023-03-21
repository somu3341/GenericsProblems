using GenericsProblems;
using System;
using System.Globalization;
using System.IO;
using System.Security.Cryptography;
namespace GenericsProblems
{
    class Program
    {
        static void Main(string[] args)
        {
            MaximumGeneric<int> maximum1 = new MaximumGeneric<int>(12, 82, 43);
            maximum1.FindMaxNum();
            MaximumGeneric<float> maximum2 = new MaximumGeneric<float>(11, 8, 42);
            maximum2.FindMaxNum();
            MaximumGeneric<string> maximum3 = new MaximumGeneric<string>("Apple", "Peach", "Banana");
            maximum3.FindMaxNum();
        }
    }

}

