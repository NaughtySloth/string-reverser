using System;
using System.Collections.Generic;
using System.Text;

namespace StringReverser
{
    public class SentenceReverser : IStringReverser
    {
        private readonly StringValidator _stringValidator = new StringValidator();

        public void PrintReversedStrings(List<string> stringList)
        {
            foreach(var str in stringList)
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

                var originalWords = str.Split(" ");

                StringBuilder sb = new StringBuilder();

                for (int i = originalWords.Length - 1; i >= 0; i--)
                {
                    sb.Append(originalWords[i]);
                    sb.Append(" ");
                }

                Console.WriteLine(sb.ToString());
            }


            //var reverseWords = new List<string>();

            //for (int i = originalWords.Length - 1; i > 0; i--)
            //{
            //    var word = originalWords[i];

            //    reverseWords.Add(word);
            //    reverseWords.Add(" ");
            //}

            //return string.Concat(reverseWords);
        }
    }
}
