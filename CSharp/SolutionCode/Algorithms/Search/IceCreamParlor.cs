namespace SolutionCode.Algorithms.Search;

public static class IceCreamParlor
{
    /// <summary>
    /// 
    /// </summary>
    /// <param name="m">Total pooled money available.</param>
    /// <param name="arr">List of prices of each ice cream.</param>
    /// <returns></returns>
    public static List<int> icecreamParlor(int m, List<int> arr)
    {
        List<int> result = new List<int>();
        int iceCreamCount = arr.Count;
        SortedSet<int> resSet = new SortedSet<int>();

        // We CANNOT perform an ordering of arr because
        // we need the initial indexes to return.

        for (int firstIndex = 0; firstIndex < iceCreamCount; firstIndex++)
        {
            for (int secondIndex = 0; secondIndex < iceCreamCount; secondIndex++)
            {
                if (firstIndex != secondIndex)
                {
                    if (arr[firstIndex] + arr[secondIndex] == m)
                    {
                        resSet.Add(firstIndex += 1);
                        resSet.Add(secondIndex += 1);
                    }
                }
            }
        }
        
        return resSet.ToList();
    }
}