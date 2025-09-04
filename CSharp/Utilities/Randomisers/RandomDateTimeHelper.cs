namespace Utilities.Randomisers;

public static class RandomDateTimeHelper
{
    public static TimeOnly RandomTimeOnly()
    {
        Random randomGen = new Random();
        
        return TimeOnly.FromDateTime(DateTime.Now).AddHours(randomGen.Next(-23, 23)).AddMinutes(randomGen.Next(-59, 59));
    }
}