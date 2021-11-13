using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Palindrome.Test;

[TestClass]
public class UniqueWordsTest
{

    [TestMethod]
    public void HasUniqueWords_Multiple()
    {
        string testParagraph = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.";
        var counts = UniqueWords.FindUniqueWordsAndCounts(testParagraph);

        Assert.AreEqual(63, counts.Count, "Unexpected number of unique words");
    }

    [TestMethod]
    public void HasUniqueWords_One()
    {
        string testParagraph = "cat cat cat.";
        var counts = UniqueWords.FindUniqueWordsAndCounts(testParagraph);

        Assert.AreEqual(1, counts.Count, "Unexpected number of unique words");
        Assert.AreEqual(counts["cat"], 3, "Unexpected number of cats");
    }

    [TestMethod]
    public void HasUniqueWords_Empty()
    {
        string testParagraph = "";
        var counts = UniqueWords.FindUniqueWordsAndCounts(testParagraph);

        Assert.AreEqual(0, counts.Count, "Unexpected number of unique words");
    }

    [TestMethod]
    public void HasUniqueWords_Space()
    {
        string testParagraph = " ";
        var counts = UniqueWords.FindUniqueWordsAndCounts(testParagraph);

        Assert.AreEqual(0, counts.Count, "Unexpected number of unique words");
    }
}