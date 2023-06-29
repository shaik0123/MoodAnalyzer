using System;
using System.Collections.Generic;
using System.Text;

namespace MoodAnalyzerDemo
{
    public class MoodAnalyzer
    {
        public string s;
        public MoodAnalyzer()
        {

        }
        public MoodAnalyzer(string s) 
        {
            this.s = s;
        }
        public string AnalyzeMood()
        {

            try {
                if (this.s.Equals(string.Empty))
                    throw new MoodAnalyzerCustomException(MoodAnalyzerCustomException.ExceptionType.NULL_VALUE,"mood Shoud not be empty");
            if (this.s.ToLower().Contains("sad"))
            {
                return "SAD";
            }
            else
            {
                return "HAPPY";
            }
            }
            catch
            {
                throw new MoodAnalyzerCustomException(MoodAnalyzerCustomException.ExceptionType.NULL_VALUE, "mood Shoud not be empty");
            }
        }

    }
}
