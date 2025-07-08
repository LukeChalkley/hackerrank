using Utilities.Randomisers;

namespace nUnitTests.Test_Data;

public class TimeConversionTestData
{
    public static IEnumerable<TestCaseData> TestCases
    {
        get
        {
            for (int i = 0; i < 100; i++)
            {
                TimeOnly randomTime = RandomDateTimeHelper.RandomTimeOnly();
                yield return new TestCaseData(randomTime.ToString("hh:mm:sstt")).Returns(
                    randomTime.ToString("HH:mm:ss"));
            }
        }
    }
}