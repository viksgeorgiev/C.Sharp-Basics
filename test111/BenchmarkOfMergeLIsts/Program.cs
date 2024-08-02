using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

class Program
{
    static void Main()
    {
        List<double> list1 = Enumerable.Range(0, 10000000).Select(i => (double)i).ToList();
        List<double> list2 = Enumerable.Range(5000, 10000000).Select(i => (double)i).ToList();

        var stopwatch = new Stopwatch();

        // Measure performance of the original approach
        stopwatch.Start();
        OriginalApproach(list1, list2);
        stopwatch.Stop();
        Console.WriteLine($"Original Approach Time: {stopwatch.ElapsedMilliseconds} ms");

        // Measure performance of the improved approach
        stopwatch.Reset();
        stopwatch.Start();
        ImprovedApproach(list1, list2);
        stopwatch.Stop();
        Console.WriteLine($"Improved Approach Time: {stopwatch.ElapsedMilliseconds} ms");
    }

    static void OriginalApproach(List<double> list1, List<double> list2)
    {
        List<double> merged = new List<double>();

        if (list1.Count != list2.Count)
        {
            merged = MergeLists(list1, list2, Math.Min(list1.Count, list2.Count));

            if (list1.Count > list2.Count)
            {
                merged.AddRange(GetRemainingElements(list2.Count, list1));
            }
            else
            {
                merged.AddRange(GetRemainingElements(list1.Count, list2));
            }
        }
        else
        {
            merged = MergeLists(list1, list2, Math.Min(list1.Count, list2.Count));
        }
    }

    static IEnumerable<double> GetRemainingElements(int count, List<double> list)
    {
        return list.GetRange(count, list.Count - count);
    }

    static List<double> MergeLists(List<double> list1, List<double> list2, int count)
    {
        List<double> merged = new List<double>();
        for (int i = 0; i < count; i++)
        {
            merged.Add(list1[i]);
            merged.Add(list2[i]);
        }
        return merged;
    }

    static void ImprovedApproach(List<double> list1, List<double> list2)
    {
        List<double> merged = new List<double>();

        int minLength = Math.Min(list1.Count, list2.Count);

        for (int i = 0; i < minLength; i++)
        {
            merged.Add(list1[i]);
            merged.Add(list2[i]);
        }

        if (list1.Count > list2.Count)
        {
            merged.AddRange(list1.Skip(minLength));
        }
        else if (list2.Count > list1.Count)
        {
            merged.AddRange(list2.Skip(minLength));
        }
    }
}