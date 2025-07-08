using System.Text;
using SolutionCode.Algorithms.Warmup;
using Utilities.Randomisers;

namespace ConsoleRunner;

class Program
{
    static void Main(string[] args)
    {
        Random hourRandom = new Random();
        Random minuteRandom = new Random();
        Random secondRandom = new Random();
        
        Random amPMRandom = new Random();
        
        for (int i = 0; i < 100; i++)
        {
            TimeOnly randomTime = RandomDateTimeHelper.RandomTimeOnly();
            string format = randomTime.ToString("hh:mm:sstt");
            
            string resultManual = TimeConversion.Result.timeConversion(format);
            string resultStruct = TimeConversion.Result.timeConversionWithTimeStruct(format);

            Console.WriteLine($"Test Case {i + 1}");
            Console.WriteLine($"\tInput {format}");
            Console.WriteLine($"\t\tTimeConversion.Result.timeConversion: {resultManual}");
            Console.WriteLine($"\t\tTimeConversion.Result.timeConversionWithTimeStruct: {resultStruct}");
        }
    }
}