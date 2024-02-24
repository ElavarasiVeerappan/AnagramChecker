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

        
            string firstString = CleanString(word1);
            string secondString = CleanString(word2);

            //Validation Check
            #region
            if (firstString.Equals(secondString))
            {
                return false;
            }
      
            // Check if either word is empty
            if (string.IsNullOrEmpty(word1))
            {
                throw new ArgumentException("First argument cannot be empty.");
            }

            if (string.IsNullOrEmpty(word2))
            {
                throw new ArgumentException("Second argument cannot be empty.");
            }

            // check if either word contain whitespaces
            if (string.IsNullOrWhiteSpace(word1))
            {
                throw new ArgumentException("Input cannot be empty or contain only whitespaces.", nameof(word1));
            }
            else if (string.IsNullOrWhiteSpace(word2))
            {
                throw new ArgumentException("Input cannot be empty or contain only whitespaces.", nameof(word2));
            }
         
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

            char[] firstCharsArray = firstString.ToCharArray();
            char[] secondCharsArray = secondString.ToCharArray();
            Array.Sort(firstCharsArray);
            Array.Sort(secondCharsArray);

            return firstCharsArray.SequenceEqual(secondCharsArray);
        }

       
        private string CleanString(string input)
        {
            if (input == null)
            {
                throw new ArgumentNullException();
            }

            return new string(input.ToLower().Where(char.IsLetter).ToArray());
        }
    }
}
