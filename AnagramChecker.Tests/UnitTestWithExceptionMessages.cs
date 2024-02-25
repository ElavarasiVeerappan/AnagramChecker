using NUnit.Framework;
using AnagramChecker;
using NUnit.Framework.Legacy;
using System.ComponentModel;

namespace AnagramChecker.Tests
{
    [TestFixture]
    public class AnagramCheckerTests
    {
        /// <summary>
        /// The method should return true if the words are anagrams of each other.
        /// “evil” is an anagram of “vile”.
        /// </summary>
        [Test]
        public void WordsAreAnagrams_ValidAnagramLowerCasetest1_ReturnsTrue()
        {
            // Arrange
            var anagramChecker = new AnagramChecker();

            // Act
            bool result = anagramChecker.WordsAreAnagrams("evil", "vile");

            // Assert
            ClassicAssert.IsTrue(result);
        }
        /// <summary>
        /// The method should return true if the words are anagrams of each other.
        /// “cheater” is an anagram of “teacher”.
        /// </summary>
         [Test]
        public void WordsAreAnagrams_ValidAnagramLowerCasetest2_ReturnsTrue()
        {
            // Arrange
            var anagramChecker = new AnagramChecker();

            // Act
            bool result = anagramChecker.WordsAreAnagrams("cheater", "teacher");

            // Assert
            ClassicAssert.IsTrue(result);
        }
        /// <summary>
        /// All checks should be case insensitive.
        /// “cheater” is an anagram of “TEACHER”.
        /// </summary>
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
        /// <summary>
        /// The method should return false if the words are not anagrams of each other.
        /// “vale” is not an anagram of “vile”.
        /// </summary>
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
        /// <summary>
        /// The method should return false if the words are identical.
        /// “evil” is not an anagram of “evil”.
        /// </summary>
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
        /// <summary>
        /// “real fun” is not considered an anagram of “funeral” for this implementation and would
        /// throw an exception as one argument contains a space.
        /// </summary>
        [Test]
        public void WordsAreAnagrams_InvalidAnagramOneArgumentWithSpace_ThrowsException()
        {
            // Arrange
            var anagramChecker = new AnagramChecker();

            // Act
            string errorMessage = "";
            try
            {
                anagramChecker.WordsAreAnagrams("real fun", "funeral");
            }
            catch (ArgumentException ex)
            {
                // Capture the exception message
                errorMessage = ex.Message;
            }

            // Assert
            Assert.Fail($"{errorMessage}");
        }
        /// <summary>
        /// “forty five” is not considered an anagram of “over fifty” for this implementation and would
        /// throw an exception as both arguments contain spaces.
        /// </summary>

        [Test]
        public void WordsAreAnagrams_InvalidAnagramBothArgumentWithSpaces_ThrowsException()
        {
            // Arrange
            var anagramChecker = new AnagramChecker();

            // Act
            string errorMessage = "";
            try
            {
                anagramChecker.WordsAreAnagrams("forty five", "over fifty");
            }
            catch (ArgumentException ex)
            {
                // Capture the exception message
                errorMessage = ex.Message;
            }

            // Assert
            Assert.Fail($"{errorMessage}");

        }
        /// <summary>
        /// An exception should be thrown if either argument is null or empty.
        /// null as either argument throws an exception.
       /// “” as either argument throws an exception.
        /// </summary>
        [Test]
        public void WordsAreAnagrams_NullFirstArgument_ThrowsException()
        {
                  
            // Arrange
            var anagramChecker = new AnagramChecker();

            // Act
            string errorMessage = "";
            try
            {
                anagramChecker.WordsAreAnagrams(null, "vile");
            }
            catch (ArgumentException ex)
            {
                // Capture the exception message
                errorMessage = ex.Message;
            }

            // Assert
            Assert.Fail($"{errorMessage}");
           
        }

        [Test]
        public void WordsAreAnagrams_NullSecondArgument_ThrowsException()
        {
            // Arrange
            var anagramChecker = new AnagramChecker();

            // Act
            string errorMessage = "";
            try
            {
                anagramChecker.WordsAreAnagrams("evil", null);
            }
            catch (ArgumentException ex)
            {
             // Capture the exception message
                errorMessage = ex.Message;
            }

            // Assert
            Assert.Fail($"{errorMessage}");
        }

        [Test]
        public void WordsAreAnagrams_EmptyFirstArgument_ThrowsException()
        {
            // Arrange
           var anagramChecker = new AnagramChecker();

            // Act
            string errorMessage = "";
            try
            {
                anagramChecker.WordsAreAnagrams("", "vile");
            }
            catch (ArgumentException ex)
            {
                // Capture the exception message
                errorMessage = ex.Message;
            }

            // Assert
            Assert.Fail($"{errorMessage}");

        }

        [Test]
        public void WordsAreAnagrams_EmptySecondArgument_ThrowsException()
        {
            // Arrange
           
            var anagramChecker = new AnagramChecker();

            // Act
            string errorMessage = "";
            try
            {
                anagramChecker.WordsAreAnagrams("evil", "");
            }
            catch (ArgumentException ex)
            {
                // Capture the exception message
                errorMessage = ex.Message;
            }

            // Assert
            Assert.Fail($"{errorMessage}");
        }
        /// <summary>
        /// An exception should be thrown if either argument contains a non-alpha character (i.e. only A to Z are
        /// valid, whitespace is invalid).
        /// “dollar$” as either argument throws an exception.
        /// </summary>
        [Test]
        public void WordsAreAnagrams_InvalidCharacterInFirstArgument_ThrowsException()
        {
            // Arrange
           
            var anagramChecker = new AnagramChecker();

            // Act
            string errorMessage = "";
            try
            {
                anagramChecker.WordsAreAnagrams("dollar$", "vile");
            }
            catch (ArgumentException ex)
            {
                // Capture the exception message
                errorMessage = ex.Message;
            }

            // Assert
            Assert.Fail($"{errorMessage}");
        }
        /// <summary>
        /// An exception should be thrown if either argument contains a non-alpha character (i.e. only A to Z are
        /// valid, whitespace is invalid).
        /// “number1fan” as either argument throws an exception.
        /// </summary>
        [Test]
        public void WordsAreAnagrams_InvalidCharacterInSecondArgument_ThrowsException()
        {
            // Arrange
           
            var anagramChecker = new AnagramChecker();

            // Act
            string errorMessage = "";
            try
            {
                anagramChecker.WordsAreAnagrams("evil", "number1fan");
            }
            catch (ArgumentException ex)
            {
                // Capture the exception message
                errorMessage = ex.Message;
            }

            // Assert
            Assert.Fail($"{errorMessage}");
        }
        /// <summary>
        /// “contains a space” as either argument throws an exception.
        /// </summary>

        [Test]
        public void WordsAreAnagrams_ArgumentWithSpace_ThrowsException()
        {
            // Arrange
            
            var anagramChecker = new AnagramChecker();

            // Act
            string errorMessage = "";
            try
            {
                anagramChecker.WordsAreAnagrams("evil", "contains a space");
            }
            catch (ArgumentException ex)
            {
                // Capture the exception message
                errorMessage = ex.Message;
            }

            // Assert
            Assert.Fail($"{errorMessage}");
        }
    }
}
