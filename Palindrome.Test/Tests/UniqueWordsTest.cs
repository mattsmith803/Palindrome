using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Palindrome.Test;

[TestClass]
public class UniqueWordsTest
{

    [TestMethod]
    [DataRow("", 0)]
    [DataRow(" ", 0)]
    [DataRow("Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 63)]
    [DataRow("cat cat cat.", 1, "cat", 3)]
    public void HasUniqueWords(string paragraph, int expectedCount, string uniqueWord = "", int? expectedWordCount = null)
    {
        var counts = WordFinder.FindUniqueWordsAndCounts(paragraph);

        Assert.AreEqual(expectedCount, counts.Count, "Unexpected number of unique words");

        if (expectedWordCount != null)
        {
            Assert.AreEqual(counts[uniqueWord], expectedWordCount, "Unexpected number of cats");
        }
    }
}