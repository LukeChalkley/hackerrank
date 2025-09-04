using System.ComponentModel;
using System.Globalization;
using System.Text;
using Microsoft.Extensions.Logging;

namespace SolutionCode.Algorithms.Warmup;

public class BetweenTwoSets
{
    public BetweenTwoSets()
    {

    }
    
    public static int getTotalX(List<int> a, List<int> b)
    {
        return getTotalXAsHashSet(a, b).Count;
    }

    public static HashSet<int> getTotalXAsHashSet(List<int> a, List<int> b)
    {
        var integersBetweenSets = new HashSet<int>();

        return integersBetweenSets;
    }
}