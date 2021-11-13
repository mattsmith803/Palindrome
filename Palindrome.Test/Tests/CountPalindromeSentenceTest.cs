using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Palindrome.Test;

[TestClass]
public class CountPalindromeSentenceTest
{
    [TestMethod]
    [DataRow("Wow wow wow.", 1)]
    [DataRow("Wow dog wow.", 0)]
    [DataRow("Wow wow wow. bob bob bob. Civic bob Civic.", 3)]
    [DataRow("Wow wow wow. Dog dog dog. Civic bob Civic.", 2)]
    [DataRow("Wow wow wow. Dog dog dog. dog bob wow.", 1)]
    [DataRow("Wow dog wow. Dog dog dog. dog bob wow.", 0)]
    [DataRow("Go hang a salami, I'm a lasagna hog.", 1)]
    [DataRow("Go hang a salami, I'm a lasagna hog. Don't nod.", 2)]
    public void IsPalindromeSentence_True(string paragraph, int expectedCount)
    {
        var count = PalindromeFinder.CountPalindromeSentences(paragraph);

        Assert.AreEqual(expectedCount, count, "Unexpected number of palindromes");
    }
}