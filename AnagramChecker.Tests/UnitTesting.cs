using NUnit.Framework;
using AnagramChecker;
using NUnit.Framework.Legacy;
using System.ComponentModel;


namespace AnagramChecker.Tests
{
    [TestFixture]
    public class UnitTesting
    {
        /// <summary>
        /// The Test Methods in this file covers all the conditions mentioned below:
        /// 1) The method should return true if the words are anagrams of each other.
        /// 2) The method should return false if the words are not anagrams of each other.
        /// 3) The method should return false if the words are identical.
        /// 4) All checks should be case insensitive.
        /// 5) An exception should be thrown if either argument is null or empty.
        /// 6) An exception should be thrown if either argument contains a non-alpha character (i.e.only A to Z are
        ///    valid, whitespace is invalid).
        /// </summary>
        [Test]
        public void WordsAreAnagrams_ValidAnagramLowerCase_ReturnsTrue()
        {
            // Arrange
            var anagramChecker = new AnagramChecker();

            // Act
            bool result = anagramChecker.WordsAreAnagrams("evil", "vile");

            // Assert
            ClassicAssert.IsTrue(result);
        }

        [Test]
        public void WordsAreAnagrams_ValidAnagramMixedCase_ReturnsTrue()
        {
            // Arrange
            var anagramChecker = new AnagramChecker();

            // Act
            bool result = anagramChecker.WordsAreAnagrams("cheater", "TEACHER");

            // Assert
            ClassicAssert.IsTrue(result);
        }

        [Test]
        public void WordsAreAnagrams_InvalidAnagram_ReturnsFalse()
        {
            // Arrange
            var anagramChecker = new AnagramChecker();

            // Act
            bool result = anagramChecker.WordsAreAnagrams("vale", "vile");

            // Assert
            ClassicAssert.IsFalse(result);
        }

        [Test]
        public void WordsAreAnagrams_SameWord_ReturnsFalse()
        {
            // Arrange
            var anagramChecker = new AnagramChecker();

            // Act
            bool result = anagramChecker.WordsAreAnagrams("evil", "evil");

            // Assert
            ClassicAssert.IsFalse(result);
        }

        [Test]
        public void WordsAreAnagrams_InvalidAnagramWithSpace_ThrowsException()
        {
            // Arrange
            var anagramChecker = new AnagramChecker();

            // Act and Assert
            Assert.Throws<ArgumentException>(() => anagramChecker.WordsAreAnagrams("real fun", "funeral"));
        }

        [Test]
        public void WordsAreAnagrams_InvalidAnagramWithSpaces_ThrowsException()
        {
            // Arrange
            var anagramChecker = new AnagramChecker();

            // Act and Assert
            Assert.Throws<ArgumentException>(() => anagramChecker.WordsAreAnagrams("forty five", "over fifty"));
        }

        [Test]
        public void WordsAreAnagrams_NullFirstArgument_ThrowsException()
        {
            // Arrange
            var anagramChecker = new AnagramChecker();

            // Act and Assert
            Assert.Throws<ArgumentNullException>(() => anagramChecker.WordsAreAnagrams(null, "vile"));
        }

        [Test]
        public void WordsAreAnagrams_NullSecondArgument_ThrowsException()
        {
            // Arrange
            var anagramChecker = new AnagramChecker();

            // Act and Assert
            Assert.Throws<ArgumentNullException>(() => anagramChecker.WordsAreAnagrams("evil", null));
        }

        [Test]
        public void WordsAreAnagrams_EmptyFirstArgument_ThrowsException()
        {
            // Arrange
            var anagramChecker = new AnagramChecker();

            // Act and Assert
            Assert.Throws<ArgumentException>(() => anagramChecker.WordsAreAnagrams("", "vile"));
        }

        [Test]
        public void WordsAreAnagrams_EmptySecondArgument_ThrowsException()
        {
            // Arrange
            var anagramChecker = new AnagramChecker();

            // Act and Assert
            Assert.Throws<ArgumentException>(() => anagramChecker.WordsAreAnagrams("evil", ""));
        }

        [Test]
        public void WordsAreAnagrams_InvalidCharacterInFirstArgument_ThrowsException()
        {
            // Arrange
            var anagramChecker = new AnagramChecker();

            // Act and Assert
            Assert.Throws<ArgumentException>(() => anagramChecker.WordsAreAnagrams("dollar$", "vile"));
        }

        [Test]
        public void WordsAreAnagrams_InvalidCharacterInSecondArgument_ThrowsException()
        {
            // Arrange
            var anagramChecker = new AnagramChecker();

            // Act and Assert
            Assert.Throws<ArgumentException>(() => anagramChecker.WordsAreAnagrams("evil", "number1fan"));
        }

        [Test]
        public void WordsAreAnagrams_ArgumentWithSpace_ThrowsException()
        {
            // Arrange
            var anagramChecker = new AnagramChecker();

            // Act and Assert
            Assert.Throws<ArgumentException>(() => anagramChecker.WordsAreAnagrams("evil", "contains a space"));
        }
    }
}
