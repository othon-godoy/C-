﻿using System;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string original = "abcde FGHIJ ABC abc DEFG   ";

            string s1 = original.ToUpper();
            string s2 = original.ToLower();

            string s3 = original.Trim();

            int n1 = original.IndexOf("bc");
            int n2 = original.LastIndexOf("bc");

            string s4 = original.Substring(3);
            string s5 = original.Substring(3, 5);

            string s6 = original.Replace('a', 'x');
            string s7 = original.Replace("abc", "kk");

            bool b1 = String.IsNullOrEmpty(original);
            bool b2 = String.IsNullOrWhiteSpace(original);

            int num1 = 17;
            string s8 = num1.ToString("F2");

            Console.WriteLine($"Original: {original}-");
            Console.WriteLine($"ToUpper: {s1}-");
            Console.WriteLine($"ToLower: {s2}-");
            Console.WriteLine($"Trim: {s3}-");
            Console.WriteLine($"IndexOf('bc'): {n1}");
            Console.WriteLine($"Last IndexOf('bc'): {n2}");
            Console.WriteLine($"Substring(3): {s4}-");
            Console.WriteLine($"Substring(3,5): {s5}-");
            Console.WriteLine($"Replace('a','x'): {s6}-");
            Console.WriteLine($"Replace('abc','kk'): {s7}-");
            Console.WriteLine($"IsNullOrEmpty(original): {b1}");
            Console.WriteLine($"IsNullOrWhiteSpace(original): {b2}");
            Console.WriteLine($"num1.ToString('F2'): {s8}-");
        }
    }
}
