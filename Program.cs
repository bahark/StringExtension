using System;
using System.Linq;

namespace StringExtension
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter String to Check Is Palindromic or Not : ");
            var stringSample = Console.ReadLine();
            Console.WriteLine("************");

            Console.WriteLine("Check By C# Default Functiond : " + stringSample.SequenceEqual(stringSample.Reverse()));
            Console.WriteLine("************");

            Console.WriteLine("Check withoutLoop : " + stringSample.IsPalindromicString());
            Console.WriteLine("************");

            Console.WriteLine("Check With Loop : " + stringSample.IsPalindromicStrinUsingLoop());
            Console.WriteLine("************");

            Console.Write("FINDING Palindromic String in TestabccbaTest : ");
            Console.WriteLine("TestabccbaTest".FindPalindromicString());
            Console.WriteLine("************");


            //این قسمت مربوط به جایگزین کردن دو حرف پشت سر هم میشود
            Console.Write("Replace String  abdef : ");
            Console.WriteLine("abdef".GetReplacedString());
            Console.WriteLine("************");

            Console.Write("Replace String  abdef (Consider replaced letter that here is c) : ");
            Console.WriteLine("abdef".ConsiderReplacedString());
            Console.WriteLine("************");

            Console.Read();
        }













    }
}
