using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace StringReverser
{
    public class StringValidator
    {
        public void ValidateString(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                throw new Exception("Cannot reverse null or empty string");
            }
            else if (input.Length > 100)
            {
                throw new Exception("String should not be over 100 characters");
            }
            else if (!IsStringInEnglish(input))
            {
                throw new Exception("Only English characters are allowed");
            }
        }

        private bool IsStringInEnglish(string input)
        {
            var regex = new Regex("^[a-zA-Z0-9. -_?]*$");
            return regex.IsMatch(input);
        }
    }
}
