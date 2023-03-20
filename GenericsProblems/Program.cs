using GenericsProblems;
using System;
using System.Globalization;
using System.IO;
using System.Security.Cryptography;

MaximumGeneric maximumGeneric = new MaximumGeneric();
maximumGeneric.Integer<int>(1, 29, 6);
maximumGeneric.Float<float>(29, 2, 5);
maximumGeneric.String<string>("Apple", "Peach", "Banana");
