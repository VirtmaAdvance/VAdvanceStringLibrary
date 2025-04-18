﻿using System.Text.RegularExpressions;

namespace VAdvanceStringLibrary
{
	/// <summary>
	/// Provides an extension method to remove whitespace characters for the string class.
	/// </summary>
	public static class StringRemoveWhitespaceExt
	{
		/// <summary>
		/// Removes all whitespace characters from the <paramref name="value"/>.
		/// </summary>
		/// <param name="value">The <see cref="string"/> value to process.</param>
		/// <returns>the <see cref="string"/> representation of the modification performed.</returns>
		public static string RemoveWhitespace(this string value)
		{
			if (value.IsValid())
			{
				const string pattern = @"(^[\s\n\r\t ]+$)";
				if (Regex.IsMatch(value, pattern))
					value = Regex.Replace(value, pattern, "");
			}
			return value;
		}

	}
}