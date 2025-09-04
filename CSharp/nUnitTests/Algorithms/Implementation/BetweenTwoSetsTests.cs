using SolutionCode.Algorithms.Warmup;

namespace nUnitTests.Algorithms.Implementation;

[Parallelizable(ParallelScope.Fixtures)]
public class BetweenTwoSetsTests
{
    [SetUp]
    public void Setup()
    {
        
    }
    
    [Theory]
    public void TestHackerrankExample()
    {
        List<int> listA = new List<int> {2, 6};
        List<int> listB = new List<int> {24, 36};
        
        HashSet<int> result = BetweenTwoSets.getTotalXAsHashSet(listA, listB);

        using (Assert.EnterMultipleScope())
        {
            Assert.That(result.Count, Is.EqualTo(2));
            Assert.That(result.Contains(6), Is.True);
            Assert.That(result.Contains(12), Is.True);
        }
    }
    
    [Theory]
    public void TestHackerrankExample2()
    {
        List<int> listA = new List<int> {2, 4};
        List<int> listB = new List<int> {16, 32, 96};
        HashSet<int> result = BetweenTwoSets.getTotalXAsHashSet(listA, listB);

        /*
        using (Assert.EnterMultipleScope())
        {
            Assert.That(result.Count, Is.EqualTo(3));
            Assert.That(result.Contains(4), Is.True);
            Assert.That(result.Contains(8), Is.True);
            Assert.That(result.Contains(16), Is.True);
        }
        */
    }
    
    [Theory]
    public void TestHackerrankExampleFactors()
    {
        List<int> listA = new List<int> {2, 6};
        List<int> listB = new List<int> {24, 36};
        
        
    }
}