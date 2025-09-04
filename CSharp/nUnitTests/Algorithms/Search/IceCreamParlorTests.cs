namespace nUnitTests.Algorithms.Search;

public class IceCreamParlorTests
{
    [SetUp]
    public void Setup()
    {
        
    }
    
    [Theory]
    public void TestHackerrankExample()
    {
        int m = 6;
        List<int> costs = new List<int> { 1, 3, 4, 5, 6 };
        
        var result = SolutionCode.Algorithms.Search.IceCreamParlor.icecreamParlor(m, costs);

        Assert.That(result, Is.Not.Null);
        Assert.That(result, Is.Ordered);
        Assert.That(result, Has.Exactly(2).Items);
        Assert.That(result, Contains.Item(1));
        Assert.That(result, Contains.Item(4));
    }
    
    [Theory]
    public void TestHackerrankExample2()
    {
        int m = 4;
        List<int> costs = new List<int> { 1,4,5,3,2 };
        
        var result = SolutionCode.Algorithms.Search.IceCreamParlor.icecreamParlor(m, costs);

        Assert.That(result, Is.Not.Null);
        Assert.That(result, Is.Ordered);
        Assert.That(result, Has.Exactly(2).Items);
        Assert.That(result, Contains.Item(1));
        Assert.That(result, Contains.Item(4));
    }
    
    [Theory]
    public void TestHackerrankExample3()
    {
        int m = 4;
        List<int> costs = new List<int> { 2,2,4,3 };
        
        var result = SolutionCode.Algorithms.Search.IceCreamParlor.icecreamParlor(m, costs);

        Assert.That(result, Is.Not.Null);
        Assert.That(result, Is.Ordered);
        Assert.That(result, Has.Exactly(2).Items);
        Assert.That(result, Contains.Item(1));
        Assert.That(result, Contains.Item(2));
    }
}