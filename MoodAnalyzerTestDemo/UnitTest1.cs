using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodAnalyzerDemo;

namespace MoodAnalyzerTestDemo
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void GivenSadReturnSad()
        {
            string expected = "SAD";
            string mgs = "mood is sad";
            MoodAnalyzer res = new MoodAnalyzer(mgs);
            string actual = res.AnalyzeMood();

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void GivenHappyReturnhappy()
        {
            string expected = "HAPPY";
            string mgs = "mood is HAPPY";
            MoodAnalyzer res1 = new MoodAnalyzer(mgs);
            string actual = res1.AnalyzeMood();

            Assert.AreEqual(expected, actual);
        }
       /* [TestMethod]
        public void GivenNullReturnhappy()
        {
            string expected = "HAPPY";
            string mgs = null;
            MoodAnalyzer res1 = new MoodAnalyzer(mgs);
            string actual = res1.AnalyzeMood();

            Assert.AreEqual(expected, actual);
        }*/
        [TestMethod]
        public void GivenNullThrowException()
        {
            try { 
            string expexted = " ";
            MoodAnalyzer ex = new MoodAnalyzer(expexted);
            string actual = ex.AnalyzeMood();
            }
            catch (MoodAnalyzerCustomException ex) 
            {
                Assert.AreEqual("mood Shoud not be empty", ex.Message);

            }




        }
    }
}
