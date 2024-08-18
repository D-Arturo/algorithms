using Algorithms.SequenceSum;

namespace AlgorithmsTests.SequenceSum;

public class AlgorithmShould
{
    [Theory]
    [InlineData(1, 1, 1, 1)]
    [InlineData(2, 2, 2, 2)]
    [InlineData(2,4,2, 6)]
    [InlineData(2,6,2, 12)]
    [InlineData(1,5,1, 15)]
    [InlineData(1,5,3, 5)]
    [InlineData(5,1,3, 0)]
    public void ReturnCalculatedSequenceValue(int start, int end, int step, int expected)
    {
        Assert.Equal(expected, Algorithm.SequenceCalculator(start, end, step));
    }
    
    [Theory]
    [InlineData(new int []{}, 1, 0)]
    [InlineData(new int[] { 1, 2, 3, 4 }, 1, 10)]
    [InlineData(new int[] { 1, 2, 3}, 2, 4)]
    [InlineData(new int[] { 2, 2, 3, 3, 4, 4 }, 2, 9)]
    public void ReturnCalculatedSupermarketQueueValue(int[] customers, int queuesAvailable, int expectedTime)
    {
        Assert.Equal(expectedTime, Algorithm.QueueTime(customers, queuesAvailable));
    }
}