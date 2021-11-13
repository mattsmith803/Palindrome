using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Palindrome.Test;

[TestClass]
public class CountPalindromeSentenceTest
{
    [TestMethod]
    public void IsPalindromeSentence_True()
    {
        string testParagraph = "Wow wow wow.";
        var count = PalindromeFinder.CountPalindromeSentences(testParagraph);

        Assert.AreEqual(1, count, "Unexpected number of palindromes");
    }

    [TestMethod]
    public void IsPalindromeSentence_False()
    {
        string testParagraph = "Wow dog wow.";
        var count = PalindromeFinder.CountPalindromeSentences(testParagraph);

        Assert.AreEqual(0, count, "Unexpected number of palindromes");
    }

    [TestMethod]
    public void HasPalindromeSentence_3outof3()
    {
        string testParagraph = "Wow wow wow. bob bob bob. Civic bob Civic.";
        var count = PalindromeFinder.CountPalindromeSentences(testParagraph);

        Assert.AreEqual(3, count, "Unexpected number of palindromes");
    }

    [TestMethod]
    public void HasPalindromeSentence_2outof3()
    {
        string testParagraph = "Wow wow wow. Dog dog dog. Civic bob Civic.";
        var count = PalindromeFinder.CountPalindromeSentences(testParagraph);

        Assert.AreEqual(2, count, "Unexpected number of palindromes");
    }

    [TestMethod]
    public void HasPalindromeSentence_1outof3()
    {
        string testParagraph = "Wow wow wow. Dog dog dog. dog bob wow.";
        var count = PalindromeFinder.CountPalindromeSentences(testParagraph);

        Assert.AreEqual(1, count, "Unexpected number of palindromes");
    }

    [TestMethod]
    public void HasPalindromeSentence_0outof3()
    {
        string testParagraph = "Wow dog wow. Dog dog dog. dog bob wow.";
        var count = PalindromeFinder.CountPalindromeSentences(testParagraph);

        Assert.AreEqual(0, count, "Unexpected number of palindromes");
    }

    [TestMethod]
    public void HasPalindromeSentenceWithNonAlphanumeric()
    {
        string testParagraph = "Go hang a salami, I'm a lasagna hog.";
        var count = PalindromeFinder.CountPalindromeSentences(testParagraph);

        Assert.AreEqual(1, count, "Unexpected number of palindromes");
    }

    [TestMethod]
    public void HasPalindromeSentenceWithTwoNonAlphanumeric()
    {
        string testParagraph = "Go hang a salami, I'm a lasagna hog. Don't nod.";
        var count = PalindromeFinder.CountPalindromeSentences(testParagraph);

        Assert.AreEqual(2, count, "Unexpected number of palindromes");
    }
}