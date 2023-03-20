using GenericsProblems;
using System;
using System.Globalization;
using System.IO;
using System.Security.Cryptography;

MaximumGeneric maximumGeneric = new MaximumGeneric();
maximumGeneric.Integer<int>(1, 29, 6);
maximumGeneric.Integer<float>(29, 2, 5);
maximumGeneric.Integer<string>("Apple", "Banana", "Peach");
