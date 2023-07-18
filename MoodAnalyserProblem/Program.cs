using System;

namespace MoodAnalyserProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
           
            //mood.AnalyseMood();
            string Message = "I am in done mood";
            MoodAnalyser mood = new MoodAnalyser(Message);
            Console.WriteLine("The mood is : " + mood.AnalyseMood());
            //MoodAnalyser
        }
    }
}
