using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Web;

namespace Amba.System.Extensions
{
    public static class StringExtensions
    {
        public static string ToJsBool(this bool flag)
        {
            return flag.ToString().ToLower();
        }

        public static string ToJsString(this string str)
        {
            return HttpUtility.JavaScriptStringEncode(str);
        }

		public static string UpperFirst(this string input)
		{
			if (!input.Any())
				return input;
			var result = input.Substring(0, 1).ToUpper();
			if (input.Length > 1)
				result += input.Substring(1, input.Length - 1);
			return result;
		}

		public static string AppendWords(this string input, string word, int times = 1)
		{
			var builder = new StringBuilder(input);
			for (int i = 1; i <= times; i++)
			{
				builder.Append(word);
			}
			return builder.ToString();
		}

		public static string AppendWithDelimeter(this string input, string value, string delimiter = ",")
		{
			if (input.Any())
				input += delimiter;
			input += value;
			return input;
		}

		public static bool IsMatch(this string input, string pattern, RegexOptions options = RegexOptions.IgnoreCase | RegexOptions.Singleline)
		{
			return Regex.IsMatch(input, pattern, options);
		}

        public static bool IsMatch(this string input, string pattern, out Match match, RegexOptions options = RegexOptions.IgnoreCase | RegexOptions.Singleline)
		{
			match = Regex.Match(input, pattern, options);
			return match.Success;
		}

        public static string RegexRemove(this string input, string pattern, RegexOptions options = RegexOptions.IgnoreCase | RegexOptions.Singleline)
		{
			return Regex.Replace(input, pattern, string.Empty, options);
		}

        public static string RegexReplace(this string input, string pattern, string replacement, RegexOptions options = RegexOptions.IgnoreCase | RegexOptions.Singleline)
		{
			return Regex.Replace(input, pattern, replacement, options);
		}

        public static string RemoveSubstrings(this string input, params string[] substrings)
        {
            string result = input;
            foreach (var pattern in substrings)
            {
                result = result.Replace(pattern, string.Empty);
            }
            return result;
        }

        public static Match RegexMatch(this string input, string pattern, RegexOptions options = RegexOptions.IgnoreCase | RegexOptions.Singleline)
		{
			return Regex.Match(input, pattern, options);
		}

        public static MatchCollection RegexMatches(this string input, string pattern, RegexOptions options = RegexOptions.IgnoreCase | RegexOptions.Singleline)
        {
            return Regex.Matches(input, pattern, options);
        }

        public static string RegexMatchGroup(this string input, string pattern, int groupIdx = 1, string @default = "", RegexOptions options = RegexOptions.IgnoreCase | RegexOptions.Singleline)
        {
            var match = input.RegexMatch(pattern, options);
            if (!match.Success)
            {
                return @default;
            }
            return match.Groups[groupIdx].Value;
        }

        public static string RegexMatchOne(this string input, string pattern, RegexOptions options = RegexOptions.IgnoreCase | RegexOptions.Singleline)
		{
			var match = Regex.Match(input, pattern, options);
			if (match.Success)
				return string.Empty;
			return match.Value;
		}

        public static string[] RegexSplit(this string input, string pattern, RegexOptions options = RegexOptions.IgnoreCase | RegexOptions.Singleline)
		{
            if (input == null)
                return new string[0];
			return Regex.Split(input, pattern, options);			
		}

		public static bool MatchAny(this string input, params string[] patterns)
		{
            return patterns.Any(pattern => Regex.IsMatch(input, pattern, RegexOptions.IgnoreCase));
		}

        public static bool MatchAnyWord(this string input, params string[] patterns)
        {
            return patterns.Any(pattern => Regex.IsMatch(input, String.Format(@"\b{0}\b", pattern), RegexOptions.IgnoreCase));
        }

		public static string DefaultIfEmpty(this string str, string @default)
		{
			return str.IsNullOrEmpty() ? @default : str;
		}

		public static bool IsNullOrEmpty(this string str)
		{
			return string.IsNullOrEmpty(str);
		}

        public static bool IsNullOrWhiteSpace(this string str)
        {
            return string.IsNullOrWhiteSpace(str);
        }

        public static string Join(this IEnumerable<string> strList, string joinStr)
        {
            var result = new StringBuilder();
            foreach(var str in strList)
            {
                if (result.Length == 0)
                    result.Append(joinStr);
                result.Append(str);
            }
            return result.ToString();
        }

        public static Stream ToStream(this string s)
        {
            var stream = new MemoryStream();
            using (var writer = new StreamWriter(stream))
            {
                writer.Write(s);
                writer.Flush();
            }
            stream.Position = 0;
            return stream;
        }

        public static string AddNTimes(this string s, int n, string word)
        {
            var result = new StringBuilder();
            result.AddNTimes(n, word);
            return result.ToString();
        }
	}
    
}
