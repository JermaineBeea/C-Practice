using Xunit;
using WeThinkCode;

namespace WeThinkCode.Tests
{
    public class TestKatas
    {
        [Fact]
        public void TestDescendingOrder()
        {
            Assert.Equal(54321, Katas.DescendingOrder(12345));
            Assert.Equal(-54321, Katas.DescendingOrder(-12345));
            Assert.Equal(987654321, Katas.DescendingOrder(123456789));
            Assert.Equal(-987654321, Katas.DescendingOrder(-123456789));
        }

        [Fact]
        public void TestToCamelCase()
        {
            Assert.Equal("theStealthWarrior", Katas.ToCamelCase("the-stealth-warrior"));
            Assert.Equal("TheStealthWarrior", Katas.ToCamelCase("The_Stealth_Warrior"));
        }

        [Fact]
        public void TestVowelCount()
        {
            Assert.Equal(3, Katas.VowelCount("hello world"));
            Assert.Equal(3, Katas.VowelCount("Hello World"));
            Assert.Equal(5, Katas.VowelCount("aeiou"));
            Assert.Equal(0, Katas.VowelCount("bcdfghjklmnpqrstvwxyz"));
        }

        [Fact]
        public void TestFindNextSquare()
        {
            Assert.Equal(121, Katas.FindNextSquare(100));
            Assert.Equal(144, Katas.FindNextSquare(121));
            Assert.Equal(-1, Katas.FindNextSquare(114));
            Assert.Equal(-1, Katas.FindNextSquare(-1));
        }

        [Fact]
        public void TestUniqueLetters()
        {
            Assert.Equal("abcdefwxy", Katas.UniqueLetters("xyaabbbccccdefww", "xyaabbbccccdefww"));
            Assert.Equal("abcdefghijklmnopqrstuvwxyz", Katas.UniqueLetters("abcdefghijklmnopqrstuvwxyz", "abcdefghijklmnopqrstuvwxyz"));
            Assert.Equal("abc", Katas.UniqueLetters("aabbcc", "abc"));
            Assert.Equal("ab", Katas.UniqueLetters("a", "b"));
        }

        [Fact]
        public void TestCreatePhoneNumber()
        {
            Assert.Equal("(123) 456-7890", Katas.CreatePhoneNumber(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 }));
            Assert.Equal("(987) 654-3210", Katas.CreatePhoneNumber(new int[] { 9, 8, 7, 6, 5, 4, 3, 2, 1, 0 }));
            Assert.Equal("(000) 000-0000", Katas.CreatePhoneNumber(new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }));
            Assert.Equal("(111) 111-1111", Katas.CreatePhoneNumber(new int[] { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 }));
        }

        [Fact]
        public void TestPangram()
        {
            Assert.True(Katas.Pangram("The quick brown fox jumps over the lazy dog."));
            Assert.False(Katas.Pangram("Hello World"));
            Assert.True(Katas.Pangram("abcdefghijklmnopqrstuvwxyz"));
            Assert.False(Katas.Pangram("abcde"));
        }

        [Fact]
        public void TestFindOutlier()
        {
            Assert.Equal(11, Katas.FindOutlier(new int[] { 2, 4, 0, 100, 4, 11, 2602, 36 }));
            Assert.Equal(160, Katas.FindOutlier(new int[] { 160, 3, 1719, 19, 11, 13, -21 }));
            Assert.Equal(1, Katas.FindOutlier(new int[] { 2, 6, 8, 10, 1 }));
            Assert.Equal(2, Katas.FindOutlier(new int[] { 1, 3, 5, 7, 2, 9, 11 }));
        }

        [Fact]
        public void TestHighAndLow()
        {
            Assert.Equal("5 1", Katas.HighAndLow("1 2 3 4 5"));
            Assert.Equal("5 -3", Katas.HighAndLow("1 2 -3 4 5"));
            Assert.Equal("9 -5", Katas.HighAndLow("1 9 3 4 -5"));
            Assert.Equal("42 -42", Katas.HighAndLow("42 -42"));
        }
    }
}