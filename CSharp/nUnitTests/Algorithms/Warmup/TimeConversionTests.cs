using nUnitTests.Test_Data;
using SolutionCode.Algorithms.Warmup;

namespace nUnitTests;



[Parallelizable(ParallelScope.Fixtures)]
public class TimeConversionTests
{
    [TestCaseSource(typeof(TimeConversionTestData), nameof(TimeConversionTestData.TestCases))]
    public string Manual(string input)
    {
        return TimeConversion.Result.manual(input);
    }

    [TestCaseSource(typeof(TimeConversionTestData), nameof(TimeConversionTestData.TestCases))]
    public string Struct(string input)
    {
        return TimeConversion.Result.withStruct(input);
    }
}