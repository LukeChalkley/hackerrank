using SolutionCode.Algorithms.Warmup;

namespace nUnitTests.Algorithms.Implementation;

public class DivisibleSumPairTests
{
    [SetUp]
    public void Setup()
    {
        
    }
    
    [Theory]
    public void TestHackerrankExample()
    {
        List<int> arr =  new List<int> {1,2,3,4,5,6};
        int divisor = 5;
        
        int numPairs = DivisibleSumPairs.divisibleSumPairs(arr.Count, divisor, arr);
        
        Assert.That(numPairs, Is.EqualTo(3));
    }
    
    [Theory]
    public void TestHackerrankExample2()
    {
        List<int> arr = new List<int> { 1, 3, 2, 6, 1, 2 };
        int divisor = 3;
        
        int numPairs = DivisibleSumPairs.divisibleSumPairs(arr.Count, divisor, arr);
        
        Assert.That(numPairs, Is.EqualTo(5));
    }
}