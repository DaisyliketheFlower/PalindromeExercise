using System;
using PalindromeExercise;
using Xunit;

namespace PalindromeExerciseTests
{
    public class UnitTest1
    {

        [Theory]
        [InlineData(null, false)]
        [InlineData("", false)]
        [InlineData("Palindrome", false)]
        [InlineData("racecar", true)]
        [InlineData("hello", false)]
        [InlineData("Racecar", true)]
        [InlineData("kayak", true)]
        [InlineData("madam", true)]
        [InlineData("Kayak", true)]
        [InlineData("Daisy", false)]
        [InlineData("Hannah", true)]
        [InlineData("Carly", true)]
        [InlineData("tenet", true)]
        [InlineData("never odd or even", true)]
        [InlineData("was it a cat I saw", true)]
        public void PalindromeTester(string word, bool expected)
        {
            //Arrange
            WordSmith tester = new WordSmith();

            //Act
            var actual = tester.IsAPalindrome(word);

            //Assert
            Assert.Equal(expected, actual);
        }
    }
}

