namespace Algorithms.SequenceSum;

public class Algorithm
{
    public static int SequenceCalculator(int start, int end, int step)
    {
        var accumulated = 0;
        for (var i = start; i <= end; i += step)
        {
            accumulated += i;
        }

        return accumulated;
    }

    public static int QueueTime(int[] customers, int queuesAvailable)
    {
        if (queuesAvailable == 1) return customers.Length == 0 ? 0 : customers.Sum();
        
        var queue1 = new List<int>();
        var queue2 = new List<int>();
        
        foreach (var customer in customers)
        {
            if (queue1.Count == 0)
            {
                queue1.Add(customer);
                continue;
            }

            if (queue2.Count == 0)
            {
                queue2.Add(customer);
                continue;
            }

            AssignToQueue(customer);
        }

        return CalculateWaitingTime();

        void AssignToQueue(int customer)
        {
            if (queue1.Sum() > queue2.Sum())
            {
                queue2.Add(customer);
            }
            else
            {
                queue1.Add(customer);
            }
        }

        int CalculateWaitingTime()
        {
            return queue1.Sum() >= queue2.Sum() ? queue1.Sum() : queue2.Sum();
        }
    }
}