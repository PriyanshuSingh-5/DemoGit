using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodAnalyserProblem;

namespace MoodAnalyserMSTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void GivenSADReturnSAD()
        {
            //Arrange
            string expected = "SAD";
            string message = "I am in Sad Mood";
            MoodAnalyser mood = new MoodAnalyser(message);

            //Act

            string actual = mood.AnalyseMood();

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GivenHappyReturnHappy()
        {
            //Arrange
            string expected = "Happy";
            string message = "I am in Happy Mood";
            MoodAnalyser mood = new MoodAnalyser(message);

            //Act

            string actual = mood.AnalyseMood();

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GivennullReturnHappy()
        {
            //Arrange
            string expected = "Happy";
            string message = null;
            MoodAnalyser mood = new MoodAnalyser(message);

            //Act

            string actual = mood.AnalyseMood();

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GivenemptythrowException()
        {
            //Arrange
            try
            {
                string message = "";
                MoodAnalyser mood = new MoodAnalyser(message);
                string actual = mood.AnalyseMood();
            }
            catch (MoosAnalyserException e)
            {
                Assert.AreEqual("Mood should not be Empty", e.Message);
            }
        }
    }
}
