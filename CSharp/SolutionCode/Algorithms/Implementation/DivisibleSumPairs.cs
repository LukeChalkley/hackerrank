namespace SolutionCode.Algorithms.Warmup;

public class DivisibleSumPairs
{
    /// <summary>
    /// 
    /// </summary>
    /// <param name="n">Length of the array. Between 2 and 100.</param>
    /// <param name="k">The integer divisor. Will be between 1 and 100.</param>
    /// <param name="ar">Array of length 2 to 100.</param>
    /// <returns></returns>
    public static int divisibleSumPairs(int n, int k, List<int> ar)
    {
        int pairCount = 0;
        List<int> sortedArr = ar.OrderBy(x => x).ToList();

        for (int i = 0; i < n; i++)
        {
            for (int j = i + 1; j < n; j++)
            {
                if ((sortedArr[i] + sortedArr[j]) % k == 0)
                {
                    ++pairCount;
                }
            }
        }
        
        return pairCount;
    }
}