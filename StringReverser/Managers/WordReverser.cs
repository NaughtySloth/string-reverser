using System;
using System.Collections.Generic;
using System.Text;

namespace StringReverser
{
    public class WordReverser : IStringReverser
    {
        private readonly StringValidator _stringValidator = new StringValidator();

        public void PrintReversedStrings(List<string> stringList)
        {
            foreach (var str in stringList)
            {
                try
                {
                    _stringValidator.ValidateString(str);
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Input: {str} failed validation. Reason: {ex.Message}");
                    continue;
                }

                StringBuilder sb = new StringBuilder();

                for (int i = str.Length - 1; i >= 0; i--)
                {
                    sb.Append(str[i]);
                }

                Console.WriteLine(sb.ToString());
            }

        }
    }
}
