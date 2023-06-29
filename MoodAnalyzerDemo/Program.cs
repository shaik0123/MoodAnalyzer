using System;

namespace MoodAnalyzerDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Console.WriteLine("enter the string");
            string s = Console.ReadLine();

            MoodAnalyzer mood = new MoodAnalyzer(s);
            mood.AnalyzeMood();
            Console.WriteLine("mood is : "+mood.AnalyzeMood());

        }
    }
}
