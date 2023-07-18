using System;
using System.Collections.Generic;
using System.Text;

namespace MoodAnalyserMSTest
{
    public class MoosAnalyserException :Exception
    {
        public enum ExceptionType
        {
            EMPTY_MESSAGE,
            NULL_MESSAGE,
            NO_SUCH_CLASS,
            NO_SUCH_METHOD
           
        }

        public readonly ExceptionType Type;
        public MoosAnalyserException(ExceptionType Type, string message) : base(message)
        {
            this.Type = Type;
        }
    }
}
