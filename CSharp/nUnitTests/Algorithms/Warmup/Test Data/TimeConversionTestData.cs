using Utilities.Randomisers;

namespace nUnitTests.Test_Data;


public class TimeConversionTestData
{
    public static int TEST_CASE_COUNT = 100_000;
    
    public static IEnumerable<TestCaseData> TestCases
    {
        get
        {
            for (int i = 0; i < TEST_CASE_COUNT; i++)
            {
                TimeOnly randomTime = RandomDateTimeHelper.RandomTimeOnly();
                yield return new TestCaseData(randomTime.ToString("hh:mm:sstt")).Returns(
                    randomTime.ToString("HH:mm:ss"));
            }
        }
    }
}