using System;
using System.Globalization;

namespace ProblemSolving
{
    internal class Program
    {

        static bool FlagUpperCaseWords(string str)
        {
            string[] words = str.Split(' ');

            foreach (var word in words)
            {
                if (char.IsUpper(word[0]))
                {
                    return false;
                }

            }
            return true;
        }

        static string DoubleHashSubstring(string str)
        {
            string result = "";
            int l = 0;
            int r = 0;
            
            while (l < str.Length)
            {
                if (str[l] == '#' && str[l+1] == '#')
                {
                    r = l+2;

                    while (str[r] != '#')
                    {
                        result += str[r];
                        r++;
                    }
                    break;

                }
                l++;
            }
            return result;

        }

        static void Main(string[] args)
        {
            //write a method that checks if each word in the string starts with lower case and if so, print true.
            string str1 = "Fadekemi is a great C# developer";
            string str2 = "fadekemi will build face recognition library in one week";
            Console.WriteLine(FlagUpperCaseWords(str1));  //false
            Console.WriteLine(FlagUpperCaseWords(str2));  //true


            // write a method that returns substring from between two double hash signs (#)
            string word1 = "##abc##def"; 
            string word2 = "##1278##"; 
            Console.WriteLine(DoubleHashSubstring(word1));  // returns abc
            Console.WriteLine(DoubleHashSubstring(word2));  // returns 1278


        }
    }
}
