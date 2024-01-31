using System.Text.RegularExpressions;

namespace SharedLibrary
{
	public static class StringExtensions
	{
		public static bool IsValidXmlTag(this string value)
		{
			return Regex.IsMatch(value, @"^<([a-z]+)([^<]+)*(?:>(.*)<\/\1>|\s+\/>)$");
		}
		public static bool IsValidPassword(this string value)
		{
			return Regex.IsMatch(value, "^[a-zA-Z0-9_-]{8,}$");
		}
		public static bool IsValidHex(this string value)
		{
			return Regex.IsMatch(value, "^#?([a-fA-F0-9]{3}|[a-fA-F0-9]{6})$");
		}
	}
}