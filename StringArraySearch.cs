namespace VAdvanceStringLibrary
{
	/// <summary>
	/// Provides searching extension methods for string arrays.
	/// </summary>
	public static class StringArraySearch
	{
		/// <summary>
		/// Determines if the <paramref name="stringArray"/> contains the <paramref name="substring"/>.
		/// </summary>
		/// <param name="stringArray">The array of string values to search within.</param>
		/// <param name="substring">The substring to look for within each of the string values stored within the <paramref name="stringArray"/>.</param>
		/// <returns>a <see cref="bool"/> value representing the result of the action.</returns>
		public static bool ContainsSubstring(this string[] stringArray, string substring) => stringArray.Any(q => q.Contains(substring));

	}
}