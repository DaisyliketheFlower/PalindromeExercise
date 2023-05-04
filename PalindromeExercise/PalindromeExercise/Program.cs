using System;

namespace PalindromeExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            var pal = new WordSmith();

            Console.WriteLine("Please enter a potential palindrome");
            var word = Console.ReadLine();

            var result = pal.IsAPalindrome(word);

            Console.WriteLine((result) ? $"{word}is a Palindrome" : $"{word} is  NOT a Palindrome");
        }
    }
}
