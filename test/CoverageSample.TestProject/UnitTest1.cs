using CoverageSample.ProjectA;

namespace CoverageSample.TestProjectA;

public class SimpleCalculatorTests
{
    [Fact]
    public void Test1()
    {
        var sut = new SimpleCalculator();

        var result = sut.Add(1,2);

        Assert.Equal(3, result);
    }
}