using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Palindrome.Test;

[TestClass]
public class FindWordWithLetterTest
{
    [TestMethod]
    [DataRow("", "", 0)]
    [DataRow(" ", " ", 0)]
    [DataRow("wow dog bob", "o", 3)]
    [DataRow("wow cat bob", "o", 2)]
    [DataRow("civic cat bob", "o", 1)]
    [DataRow("civic cat bob. racecar wow taco.", "o", 3)]
    public void HasWordsWithLetter(string paragraph, string letter, int expectedCount)
    {
        string testParagraph = paragraph;
        var words = WordFinder.FindWordsWithLetter(testParagraph, letter);

        Assert.AreEqual(expectedCount, words.Count, "Unexpected number of words with letter");
    }
}