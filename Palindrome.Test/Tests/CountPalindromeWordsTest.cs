using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Palindrome.Test;

[TestClass]
public class CountPalindromeWordsTest
{
    [TestMethod]
    [DataRow("", 0)]
    [DataRow(" ", 0)]
    [DataRow("Anna civic wow", 3)]
    [DataRow("Anna george wow", 2)]
    [DataRow("Anna george civic kayak level madam mom noon racecar radar redder refer dog repaper rotator rotor sagas solos stats tenet wow", 19)]
    [DataRow("george dog cat", 0)]
    public void HasPalindromes_Empty(string paragraph, int expectedCount)
    {
        var count = PalindromeFinder.CountPalindromeWords(paragraph);

        Assert.AreEqual(expectedCount, count, "Unexpected number of palindromes");
    }
}