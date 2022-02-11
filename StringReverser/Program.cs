using System;
using System.Collections.Generic;
using System.Linq;

namespace StringReverser
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            var wordList = new List<string>
            {
                "Word1",
                "Word2!!",
                "",
                "Škafiškafnjak",
                "    Word"
            };

            var sentenceList = new List<string>
            {
                "Simple sentence.",
                "    Sentence with space at start",
                "Sentence with space at the end     ",
                "Sentence with a special letter đ "
            };

            var stringManagerFactory = new StringManagerFactory();

            var sentenceReverser = stringManagerFactory.GetStringManager(CommandTypeEnum.ReverseSentence);

            var wordReverser = stringManagerFactory.GetStringManager(CommandTypeEnum.ReverseWord);

            sentenceReverser.PrintReversedStrings(sentenceList);
            wordReverser.PrintReversedStrings(wordList);
        }
    }
}
