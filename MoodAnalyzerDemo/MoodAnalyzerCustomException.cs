using System;
using System.Collections.Generic;
using System.Text;

namespace MoodAnalyzerDemo
{
    public class MoodAnalyzerCustomException : Exception
    {
        public enum ExceptionType
        {
            NULL_VALUE,
            EMPTY_VALUE
               
        }   
        readonly ExceptionType Type;
        public MoodAnalyzerCustomException(ExceptionType type, string message) : base(message) 
        {
            this.Type = type;
            
            
        }
    }
}
