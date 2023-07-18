using System;
using System.Collections.Generic;
using System.Text;

using MoodAnalyserMSTest;

namespace MoodAnalyserProblem
{
    public class MoodAnalyser
    {
        public string Message;

        public MoodAnalyser()
        {

        }
        public MoodAnalyser(string Message)
        {
            this.Message = Message;
        }

        public string AnalyseMood()
        {
            try
            {
                if (this.Message.Equals(string.Empty))
                
                    throw new MoosAnalyserException(MoosAnalyserException.ExceptionType.EMPTY_MESSAGE, "Mood should not be Empty");
                
                if (this.Message.ToLower().Contains("sad"))
                {
                    return "SAD";
                }
                else
                {
                    return "Happy";
                }
            }catch
            {
                throw new MoosAnalyserException(MoosAnalyserException.ExceptionType.EMPTY_MESSAGE, "Mood should not be Empty");
            }
        }
    }
}
