using System;
using System.Collections.Generic;
using System.Linq;

public static class SumOfMultiples
{
    public static int Sum(IEnumerable<int> multiples, int max)
    {
        var numbers = new HashSet<int>();

        foreach (var multiple in multiples)
        {
            for (var i = multiple; i < max; i += multiple)
            {
                numbers.Add(i);
            }
        }

        return numbers.Sum();
    }
}