using NUnit.Framework;
using AnagramChecker;
using NUnit.Framework.Legacy;

namespace AnagramChecker.Tests
{
    [TestFixture]
    public class AnagramCheckerTests
    {
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
