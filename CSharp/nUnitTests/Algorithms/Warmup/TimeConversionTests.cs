using nUnitTests.Test_Data;
using SolutionCode.Algorithms.Warmup;

namespace nUnitTests;

public class TimeConversionTests
{
    [SetUp]
    public void Setup()
    {
        
    }

    [TestCaseSource(typeof(TimeConversionTestData), nameof(TimeConversionTestData.TestCases))]
    public string TestRandomTimes(string input)
    {
        return TimeConversion.Result.timeConversion(input);
    }
    
    [TestCaseSource(typeof(TimeConversionTestData), nameof(TimeConversionTestData.TestCases))]
    public string TestExamplesWithTimeOnly(string input)
    {
        return TimeConversion.Result.timeConversionWithTimeStruct(input);
    }
}