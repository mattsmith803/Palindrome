namespace Palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            string testParagraph = @"Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.";
            // testParagraph = @"Anna george civic kayak level madam mom noon racecar radar redder refer dog repaper rotator rotor sagas solos stats tenet wow";
            testParagraph = @"Dammit I'm mad. Evil is a deed as I live. God, am I reviled? I rise, my bed on a sun, I melt. To be not one man emanating is sad. I piss. Alas, it is so late. Who stops to help? Man, it is hot. I'm in it. I tell. I am not a devil. I level  'Mad Dog '. Ah, say burning is, as a deified gulp, In my halo of a mired rum tin. I erase many men. Oh, to be man, a sin. Is evil in a clam? In a trap? No. It is open. On it I was stuck. Rats peed on hope. Elsewhere dips a web. Be still if I fill its ebb. Ew, a spider… eh? We sleep. Oh no! Deep, stark cuts saw it in one position. Part animal, can I live? Sin is a name. Both, one… my names are in it. Murder? I'm a fool. A hymn I plug, deified as a sign in ruby ash, A Goddam level I lived at. On mail let it in. I'm it. Oh, sit in ample hot spots. Oh wet! A loss it is alas (sip). I'd assign it a name. Name not one bottle minus an ode by me:  'Sir, I deliver. I'm a dog' Evil is a deed as I live. Dammit I'm mad.";

            PalindromeFinder.CountPalindroneSentences(testParagraph);

            // testParagraph = Helpers.SanitizeParagraph(testParagraph);
            // PalindromeFinder.CountPalindroneWords(testParagraph);
            // UniqueWords.FindAndPrintUniqueWordsAndCounts(testParagraph);
        }
    }
}