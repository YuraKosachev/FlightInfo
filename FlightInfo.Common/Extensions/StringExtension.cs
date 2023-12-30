
using System.Text.RegularExpressions;

namespace FlightInfo.Common.Extensions
{
    public static class StringExtension
    {
        public static string ReplaceChars(this string str, params (string from, string to)[] replaces)
        {
            foreach (var (from, to) in replaces)
            {
                str = str.Replace(from, to);
            }
            return str;
        }

        //public static string FindAndReplace(this string str, string pattern, string replace)
        //{
        //    var regex = new Regex(pattern, RegexOptions.Compiled);

        //    var matches = regex.Matches(str);

        //    foreach (var match in matches) 
        //    {
            
        //    }
        //    return str;
        //}
    }
}
