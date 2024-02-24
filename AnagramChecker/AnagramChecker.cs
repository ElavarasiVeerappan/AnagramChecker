using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnagramChecker
{
    public class AnagramChecker
    {

        //non-static public method
        public bool WordsAreAnagrams(string word1, string word2)
        {
                    
            string firstString = RemoveNonAlphabeticCharacters(word1);
            string secondString = RemoveNonAlphabeticCharacters(word2);

            //Validation Check
            #region
           
            // Check if the words are identical
            if (firstString.Equals(secondString))
            {
                // Two identitical word canot be anagrams
                return false;
            }
    
            // Check if either word is empty
            if (string.IsNullOrEmpty(word1))
            {
                throw new ArgumentException("First argument cannot be empty.");
            }
            else if (string.IsNullOrEmpty(word2))
            {
                throw new ArgumentException("Second argument cannot be empty.");
            }
                    
            // check if either word contain whitespaces
            if (word1.Contains(" ") || word2.Contains(" "))
            {
                if (word1.Contains(" ") && word2.Contains(" "))
                {
                    throw new ArgumentException("Both arguments contain spaces.");
                }
                else
                {
                    throw new ArgumentException("One argument contains a space.");
                }
            }
            // check either argument must contain only alphabetic characters
            if (!word1.All(char.IsLetter))
            {
                throw new ArgumentException("First argument must contain only alphabetic characters.");
            }
            else if(!word2.All(char.IsLetter))
            {
                throw new ArgumentException("Second argument must contain only alphabetic characters.");
            }
            #endregion

            //Convert string to character array  
            char[] firstCharsArray = firstString.ToCharArray();
            char[] secondCharsArray = secondString.ToCharArray();

            //Sort array 
            Array.Sort(firstCharsArray);
            Array.Sort(secondCharsArray);

            //Check two character arrays are in the same order, the SequenceEqual method will return true, indicating that the two words are anagrams. 
            return firstCharsArray.SequenceEqual(secondCharsArray);
        }

        // removes non-alphabetic characters and converts it to the lowercse
        private string RemoveNonAlphabeticCharacters(string input)
        {
            // check if either word contains null
            if (input == null)
            {
                throw new ArgumentNullException();
            }

            return new string(input.ToLower().Where(char.IsLetter).ToArray());
        }
    }
}
