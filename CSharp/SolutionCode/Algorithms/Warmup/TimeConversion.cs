using System.Globalization;
using System.Text;

namespace SolutionCode.Algorithms.Warmup;

public class TimeConversion
{
    public class Result
    {
        /*
         * Complete the 'timeConversion' function below.
         *
         * The function is expected to return a STRING.
         * The function accepts STRING s as parameter.
         */


        public static string timeConversion(string s)
        {
            int hour = Int32.Parse(s.Substring(0, 2));
            int minute = Int32.Parse(s.Substring(3, 2));
            int second = Int32.Parse(s.Substring(6, 2));
            string amPM = s.Substring(8, 2);

            StringBuilder sb = new StringBuilder();

            if (hour == 12 && amPM == "AM")
                sb.Append("00");
            else if (hour == 12 && amPM == "PM")
                sb.Append("12");
            else if (amPM == "PM")
                sb.Append(12 + hour);
            else
                sb.Append(hour.ToString().PadLeft(2, '0'));


            sb.Append(":");
            sb.Append(minute.ToString().PadLeft(2, '0'));

            sb.Append(":");
            sb.Append(second.ToString().PadLeft(2, '0'));

            return sb.ToString();
        }

        public static string timeConversionWithTimeStruct(string s)
        {
            TimeOnly timeOnly = TimeOnly.Parse(s);

            return timeOnly.ToString("HH:mm:ss");
        }
    }
}