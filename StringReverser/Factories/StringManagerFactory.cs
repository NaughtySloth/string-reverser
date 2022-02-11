using System;
using System.Collections.Generic;
using System.Text;

namespace StringReverser
{
    public class StringManagerFactory
    {
        public IStringReverser GetStringManager(CommandTypeEnum commandType)
        {
            return commandType == CommandTypeEnum.ReverseSentence ? new SentenceReverser() : (IStringReverser)new WordReverser();
        }
    }
}
