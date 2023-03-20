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
            MaximumGeneric maximum = new MaximumGeneric();
            maximum.FindMaxInt(12, 82, 5);
            maximum.FindMaxFloat(15, 2, 23);
            maximum.FindMaxString("Apple", "Peach", "Banana");

        }
    }

}

