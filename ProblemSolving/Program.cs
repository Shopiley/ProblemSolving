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

        static int[] SortArray(int[] array)
        {
            // I implemented the bubble sort algorithm for this
            int n = array.Length;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n-i-1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        int temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }          
            }
            return array;
        }
        static void Main(string[] args)
        {
            //write a method that checks if each word in the string starts with lower case and if so, print true.
            string str1 = "Alex is a great C# developer";
            string str2 = "fadekemi will build face recognition library in one week ijn";
            Console.WriteLine(FlagUpperCaseWords(str1));  //false
            Console.WriteLine(FlagUpperCaseWords(str2));  //true


            // write a method that returns substring from between two double hash signs (#)
            string word1 = "##abc##def"; // returns abc
            string word2 = "##1278##"; // returns 1278
            Console.WriteLine(DoubleHashSubstring(word1));
            Console.WriteLine(DoubleHashSubstring(word2));

            // write a method that returns sorted array in ascending order.
            int[] nums = { 9, 5, 7, 2, 1, 8 }; // gives {1, 2, 5, 7, 8, 9}
            Console.Write("{ ");
            foreach (var num in SortArray(nums))
            {
                Console.Write(num + ", ");
            }
            Console.Write("}");
        }
    }
}
