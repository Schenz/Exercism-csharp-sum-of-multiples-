using System;
using System.Collections.Generic;
using System.Linq;

public static class SumOfMultiples
{
    public static int Sum(IEnumerable<int> multiples, int max) => multiples.SelectMany(multiple => Enumerable.Range(1, max).Select(n => n * multiple).Where(n => n < max)).ToHashSet().Sum();
}