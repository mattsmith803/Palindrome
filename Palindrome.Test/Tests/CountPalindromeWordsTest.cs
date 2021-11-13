using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Palindrome.Test;

[TestClass]
public class CountPalindromeWordsTest
{

    [TestMethod]
    public void HasPalindromes_3outof3()
    {
        string testParagraph = "Anna civic wow";
        var count = PalindromeFinder.CountPalindromeWords(testParagraph);

        Assert.AreEqual(3, count, "Unexpected number of palindromes");
    }

    [TestMethod]
    public void HasPalindromes_2outof3()
    {
        string testParagraph = "Anna george civic";
        var count = PalindromeFinder.CountPalindromeWords(testParagraph);

        Assert.AreEqual(2, count, "Unexpected number of palindromes");
    }

    [TestMethod]
    public void HasPalindromes_19outof21()
    {
        string testParagraph = "Anna george civic kayak level madam mom noon racecar radar redder refer dog repaper rotator rotor sagas solos stats tenet wow";
        var count = PalindromeFinder.CountPalindromeWords(testParagraph);

        Assert.AreEqual(19, count, "Unexpected number of palindromes");
    }

    [TestMethod]
    public void HasPalindromes_None()
    {
        string testParagraph = "george dog cat";
        var count = PalindromeFinder.CountPalindromeWords(testParagraph);

        Assert.AreEqual(0, count, "Unexpected number of palindromes");
    }
}