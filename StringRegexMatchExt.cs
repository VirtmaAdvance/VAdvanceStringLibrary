using System.Text.RegularExpressions;

namespace VAdvanceStringLibrary
{
	/// <summary>
	/// Provides string extension methods for regex match operations.
	/// </summary>
	public static class StringRegexMatchExt
	{
		/// <summary>
		/// Determines if the <paramref name="input"/> matches the <paramref name="pattern"/>.
		/// </summary>
		/// <param name="input">The <see cref="string"/> input to analyze.</param>
		/// <param name="pattern">The regex pattern.</param>
		/// <param name="options">The regular expression pattern matching options.</param>
		/// <returns><see cref="bool">true</see> upon success, <see cref="bool">false</see> otherwise.</returns>
		public static bool IsMatch(this string? input, string pattern, RegexOptions options) => input.NotNullOrEmpty() && Regex.IsMatch(input!, pattern, options);
		/// <inheritdoc cref="IsMatch(string?, string, RegexOptions)"/>
		public static bool IsMatch(this string? input, string pattern) => input.NotNullOrEmpty() && Regex.IsMatch(input!, pattern);
		/// <inheritdoc cref="Regex.Match(string?, string, RegexOptions)"/>
		public static Match? Match(this string? input, string pattern, RegexOptions options) => input.NotNullOrEmpty() ? Regex.Match(input!, pattern, options) : null;
		/// <inheritdoc cref="Regex.Match(string?, string, RegexOptions)"/>
		public static Match? Match(this string? input, string pattern) => input.NotNullOrEmpty() ? Regex.Match(input!, pattern) : null;
		/// <inheritdoc cref="Regex.Matches(string?, string, RegexOptions)" path="//*[not(self::returns)]"/>
		/// <returns>an array of <see cref="System.Text.RegularExpressions.Match"/> objects.</returns>
		public static Match[] Matches(this string? input, string pattern, RegexOptions options) => input.NotNullOrEmpty() ? Regex.Matches(input!, pattern, options)?.ToArray() ?? [] : [];
		/// <inheritdoc cref="Regex.Matches(string?, string, RegexOptions)" path="//*[not(self::returns)]"/>
		/// <returns>an array of <see cref="System.Text.RegularExpressions.Match"/> objects.</returns>
		public static Match[] Matches(this string? input, string pattern) => input.NotNullOrEmpty() ? Regex.Matches(input!, pattern)?.ToArray() ?? [] : [];

	}
}