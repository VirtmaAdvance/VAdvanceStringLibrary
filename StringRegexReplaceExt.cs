using System.Text.RegularExpressions;

namespace VAdvanceStringLibrary
{
	/// <summary>
	/// Provides string extension methods for string replacement operations.
	/// </summary>
	public static class StringRegexReplaceExt
	{
		/// <inheritdoc cref="Regex.Replace(string?, string, string?, RegexOptions)" path="//*[not(self::returns)]"/>
		public static string? Replace(this string? input, string pattern, string? replacement, RegexOptions options) => Regex.Replace(input??"", pattern, replacement??"", options);
		/// <inheritdoc cref="Regex.Replace(string?, string, string?, RegexOptions)" path="//*[not(self::returns)]"/>
		public static string? Replace(this string? input, string pattern, string? replacement) => Regex.Replace(input ?? "", pattern, replacement ?? "");

	}
}