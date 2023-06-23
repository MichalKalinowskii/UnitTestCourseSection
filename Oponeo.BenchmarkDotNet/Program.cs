using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Engines;
using BenchmarkDotNet.Running;
using System.Text.RegularExpressions;

namespace Oponeo.BenchmarkDotNet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string test = "1inwsngaognaonaeragvwsinwsngaognaonaerinwsngaognaonaerinwsngaognaonaerinwsngaognaonaerinwsngaognaonaerinwsngaognaonaerinwsngaognaonaeragvwsinwsngaognaonaerinwsngaognaonaerinwsngaognaonaerinwsngaognaonaerinwsngaognaonaerinwsngaognaonaerinwsngaognaonaeragvwsinwsngaognaonaerinwsngaognaonaerinwsngaognaonaerinwsngaognaonaerinwsngaognaonaerinwsngaognaonaerinwsngaognaonaeragvwsinwsngaognaonaerinwsngaognaonaerinwsngaognaonaerinwsngaognaonaerinwsngaognaonaerinwsngaognaonaerinwsngaognaonaeragvwsinwsngaognaonaerinwsngaognaonaerinwsngaognaonaerinwsngaognaonaerinwsngaognaonaerinwsngaognaonaerinwsngaognaonaeragvwsinwsngaognaonaerinwsngaognaonaerinwsngaognaonainwsngaognaonaeragvwsinwsngaognaonaerinwsngaognaonaerinwsngaognaonaerinwsngaognaonaerinwsngaognaonaerinwsngaognaonaerinwsngaognaonaeragvwsinwsngaognaonaerinwsngaognaonaerinwsngaognaonaerinwsngaognaonaerinwsngaognaonaerinwsngaognaonaerinwsngaognaonaeragvwsinwsngaognaonaerinwsngaognaonaerinwsngaognaonaerinwsngaognaonaerinwsngaognaonaerinwsngaognaonaerinwsngaognaonaeragvwsinwsngaognaonaerinwsngaognaonaerinwsngaognaonaerinwsngaognaonaerinwsngaognaonaerinwsngaognaonaerinwsngaognaonaeragvwsinwsngaognaonaerinwsngaognaonaerinwsngaognaonaerinwsngaognaonaerinwsngaognaonaerinwsngaognaonaerinwsngaognaonaeragvwsinwsngaognaonaerinwinwsngaognaonaeragvwsinwsngaognaonaerinwsngaognaonaerinwsngaognaonaerinwsngaognaonaerinwsngaognaonaerinwsngaognaonaerinwsngaognaonaeragvwsinwsngaognaonaerinwsngaognaonaerinwsngaognaonaerinwsngaognaonaerinwsngaognaonaerinwsngaognaonaerinwsngaognaonaeragvwsinwsngaognaonaerinwsngaognaonaerinwsngaognaonaerinwsngaognaonaerinwsngaognaonaerinwsngaognaonaerinwsngaognaonaeragvwsinwsngaognaonaerinwsngaognaonaerinwsngaognaonaerinwsngaognaonaerinwsngaognaonaerinwsngaognaonaerinwsngaognaonaeragvwsinwsngaognaonaerinwsngaognaonaerinwsngaognaonaerinwsngaognaonaerinwsngaognaonaerinwsngaognaonaerinwsngaognaonaeragvwsinwsngaognaonaerinwsngaognaonaerinwsngaognaonaerinwsngaognaonaerinwsngaognaonaerinwsngaognaonaersngaognaonaerinwsngaognaonaerinwsngaognaonaerinwsngaognaonaerinwsngaognaonaererinwsngaognaonaerinwsngaognaonaerinwsngaognaonaer";
            var summary = BenchmarkRunner.Run<StringCheck>();
            StringCheck check = new StringCheck();
            Console.WriteLine(check.CheckStringByParse(test));
            Console.WriteLine(check.CheckStringByLinq(test));
            Console.WriteLine(check.CheckStringByRegex(test));
        }
    }

    [SimpleJob(RunStrategy.ColdStart, iterationCount:100)]
    [MemoryDiagnoser]
    [MinColumn, MaxColumn, MeanColumn, MedianColumn]
    public class StringCheck
    {
        private const string test = "1inwsngaognaonaeragvwsinwsngaognaonaerinwsngaognaonaerinwsngaognaonaerinwsngaognaonaerinwsngaognaonaerinwsngaognaonaerinwsngaognaonaeragvwsinwsngaognaonaerinwsngaognaonaerinwsngaognaonaerinwsngaognaonaerinwsngaognaonaerinwsngaognaonaerinwsngaognaonaeragvwsinwsngaognaonaerinwsngaognaonaerinwsngaognaonaerinwsngaognaonaerinwsngaognaonaerinwsngaognaonaerinwsngaognaonaeragvwsinwsngaognaonaerinwsngaognaonaerinwsngaognaonaerinwsngaognaonaerinwsngaognaonaerinwsngaognaonaerinwsngaognaonaeragvwsinwsngaognaonaerinwsngaognaonaerinwsngaognaonaerinwsngaognaonaerinwsngaognaonaerinwsngaognaonaerinwsngaognaonaeragvwsinwsngaognaonaerinwsngaognaonaerinwsngaognaonainwsngaognaonaeragvwsinwsngaognaonaerinwsngaognaonaerinwsngaognaonaerinwsngaognaonaerinwsngaognaonaerinwsngaognaonaerinwsngaognaonaeragvwsinwsngaognaonaerinwsngaognaonaerinwsngaognaonaerinwsngaognaonaerinwsngaognaonaerinwsngaognaonaerinwsngaognaonaeragvwsinwsngaognaonaerinwsngaognaonaerinwsngaognaonaerinwsngaognaonaerinwsngaognaonaerinwsngaognaonaerinwsngaognaonaeragvwsinwsngaognaonaerinwsngaognaonaerinwsngaognaonaerinwsngaognaonaerinwsngaognaonaerinwsngaognaonaerinwsngaognaonaeragvwsinwsngaognaonaerinwsngaognaonaerinwsngaognaonaerinwsngaognaonaerinwsngaognaonaerinwsngaognaonaerinwsngaognaonaeragvwsinwsngaognaonaerinwinwsngaognaonaeragvwsinwsngaognaonaerinwsngaognaonaerinwsngaognaonaerinwsngaognaonaerinwsngaognaonaerinwsngaognaonaerinwsngaognaonaeragvwsinwsngaognaonaerinwsngaognaonaerinwsngaognaonaerinwsngaognaonaerinwsngaognaonaerinwsngaognaonaerinwsngaognaonaeragvwsinwsngaognaonaerinwsngaognaonaerinwsngaognaonaerinwsngaognaonaerinwsngaognaonaerinwsngaognaonaerinwsngaognaonaeragvwsinwsngaognaonaerinwsngaognaonaerinwsngaognaonaerinwsngaognaonaerinwsngaognaonaerinwsngaognaonaerinwsngaognaonaeragvwsinwsngaognaonaerinwsngaognaonaerinwsngaognaonaerinwsngaognaonaerinwsngaognaonaerinwsngaognaonaerinwsngaognaonaeragvwsinwsngaognaonaerinwsngaognaonaerinwsngaognaonaerinwsngaognaonaerinwsngaognaonaerinwsngaognaonaersngaognaonaerinwsngaognaonaerinwsngaognaonaerinwsngaognaonaerinwsngaognaonaererinwsngaognaonaerinwsngaognaonaerinwsngaognaonaer";

        [Benchmark]
        [Arguments(test)]
        public bool CheckStringByParse(string text)
        {
            double number;
            for(int i=0; i<text.Length; i++)
            {
                Double.TryParse(text[i].ToString(), out number);
                if (number != 0 || text[i]=='0')
                {
                    return false;
                }
            }
            return true;
        }

        [Benchmark]
        [Arguments(test)]
        public bool CheckStringByLinq(string text) 
        {
            if(text.All(char.IsDigit)) return false;
            return true;
        }

        [Benchmark]
        [Arguments(test)]
        public bool CheckStringByRegex(string text) 
        {
            Regex rx= new Regex(@"\d");
            if (rx.IsMatch(text))
                return false;
            return true;
        }

    }
}