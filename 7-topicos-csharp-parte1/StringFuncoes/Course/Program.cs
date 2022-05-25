using System;

namespace Course
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

            string s6 = original.Replace('a', 'x'); // case sensitive
            string s7 = original.Replace("abc", "xy");

            bool b1 = String.IsNullOrEmpty(original);
            bool b2 = String.IsNullOrWhiteSpace(original);

            Console.WriteLine("Original: -{0}-", original);
            Console.WriteLine("ToUpper: -{0}-", s1);
            Console.WriteLine("ToLower: -{0}-", s2);
            Console.WriteLine("Trim: -{0}-", s3);
            Console.WriteLine("IndexOf('bc'): {0}", n1);
            Console.WriteLine("LastIndexOf('bc'): {0}", n2);
            Console.WriteLine("Substring(3): -{0}-", s4);
            Console.WriteLine("Substring(3,5): -{0}-", s5);
            Console.WriteLine("Replace('a', 'x'): -{0}-", s6);
            Console.WriteLine("Replace('abc', 'xy'): -{0}-", s7);
            Console.WriteLine("IsNullOrEmpty: {0}", b1);
            Console.WriteLine("IsNullOrWhiteSpace: {0}", b2);
        }
    }
}
