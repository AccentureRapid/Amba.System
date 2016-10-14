using System.Text.RegularExpressions;

namespace Amba.System
{
    public static class RegexCollection
    {
        public static string HtmlToText = @"<[^>]*>|&[a-zA-Z]+;|&#[0-9]+;|<!--(.*?)-->";
        public static Regex HtmlToTextRegex = new Regex(HtmlToText, RegexOptions.Compiled | RegexOptions.Singleline);
    }
}