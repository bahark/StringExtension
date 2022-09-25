using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StringExtension
{
    public static class StringExtension
    {

        //این متد برای تشخیص اینکه رشته ای از ابتدا و انتها به یک حالت خوانده میشود - بدون استفاده از حلقه 
        public static bool IsPalindromicString(this string sampleString)
        {
            string first = sampleString.Substring(0, sampleString.Length / 2);
            char[] arr = sampleString.ToCharArray();

            Array.Reverse(arr);

            string temp = new string(arr);
            string second = temp.Substring(0, temp.Length / 2);

            return first.Equals(second);
        }

        //این متد برای تشخیص اینکه رشته ای از ابتدا و انتها به یک حالت خوانده میشود - با استفاده از حلقه 
        public static bool IsPalindromicStrinUsingLoop(this string smapleString)
        {
            var reverseString = string.Empty;

            for (int i = smapleString.Length - 1; i >= 0; i--)
            {
                reverseString += smapleString[i].ToString();
            }
            if (reverseString == smapleString)
                return true;
            else
                return false;
        }

        //این متد برای پیدا کردن رشته ای است که از ابتدا و انتها به یک شکل خوانده میشود
        public static string FindPalindromicString(this string sampleString)
        {
            int lenghtOfString = sampleString.Length;

            // All subStrings of length 1
            // are palindromes
            int maxLength = 1, start = 0;


            for (int i = 0; i < sampleString.Length; i++)
            {
                for (int j = i; j < sampleString.Length; j++)
                {
                    int flag = 1;

                    for (int k = 0; k < (j - i + 1) / 2; k++)
                        if (sampleString[i + k] != sampleString[j - k])
                            flag = 0;

                    if (flag != 0 && (j - i + 1) > maxLength)
                    {
                        start = i;
                        maxLength = j - i + 1;
                    }
                }
            }

            return PrintPalindromicString(sampleString, start, start + maxLength - 1);
        }

        static string PrintPalindromicString(string sampleString, int startIndex, int lastIndex)
        {
            var palindromicString = string.Empty;
            for (int i = startIndex; i <= lastIndex; ++i)

                palindromicString += sampleString[i].ToString();

            //palindromicString.Concat(palindromicString);
            return palindromicString;
        }


         //این قسمت مربوط به جایگزین کردن دو حرف پشت سر هم میشود
        //در این حالت کاراکتر جدید که جایگزین شده در نظر گرفته نمیشود
        public static string GetReplacedString(this string sampleString)
        {
            var replaceDIctionary = new Dictionary<string, string> { { "ab", "c" }, { "cd", "e" }, { "ef", "g" } };

            for (int i = 0; i < sampleString.Length - 1; i++)
            {
                var key = sampleString.Substring(i, 2);
                if (replaceDIctionary.ContainsKey(key))
                    sampleString = sampleString.Replace(sampleString.Substring(i, 2), replaceDIctionary[key]);
            }
            return sampleString;
        }

        // در این حالت کاراکتر جدید که جایگزین شده در جایگزینی های بعدی در نظر گرفته میشود.
        public static string ConsiderReplacedString(this string sampleString)
        {
            var replaceDIctionary = new Dictionary<string, string> { { "ab", "c" }, { "cd", "e" }, { "ef", "g" } };
            sampleString = replaceDIctionary.Aggregate(sampleString, (result, s) => result.Replace(s.Key, s.Value));
            return sampleString;
        }
    }
}
