using System;

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
        static void Main(string[] args)
        {
            //write a method that checks if each word in the string starts with lower case and if so, print true.
            //Fadekemi is a great C# developer--- returns false
            //fadekemi will build face recognition library in one week  ---returns true(it has to be true, literally)
            string str1 = "Fadekemi is a great C# developer";
            string str2 = "fadekemi will build face recognition library in one week";
            Console.WriteLine(FlagUpperCaseWords(str1));  //false
            Console.WriteLine(FlagUpperCaseWords(str2));  //true

        }
    }
}
