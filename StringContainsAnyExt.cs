namespace VAdvanceStringLibrary
{
	/// <summary>
	/// Provides extension methods for the string class.
	/// </summary>
	public static class StringContainsAnyExt
	{
		/// <summary>
		/// Determines if any of the <paramref name="values"/> were found in the <paramref name="value"/>.
		/// </summary>
		/// <param name="value">The <see cref="string"/> value to look through.</param>
		/// <param name="values">The <see cref="string"/> values to look for.</param>
		/// <returns>a <see cref="bool"/> representing the result from the search.</returns>
		public static bool ContainsAny(this string value, params string[] values) => !value.IsEmpty() && values.IsValid() && values.Any(q=>value.Contains(q));
		/// <summary>
		/// Determines if all of the <paramref name="values"/> were found in the <paramref name="value"/>.
		/// </summary>
		/// <param name="value">The <see cref="string"/> value to look through.</param>
		/// <param name="values">The <see cref="string"/> values to look for.</param>
		/// <returns>a <see cref="bool"/> representing the result from the search.</returns>
		public static bool ContainsAll(this string value, params string[] values) => !value.IsEmpty() && values.IsValid() && values.All(q=>value.Contains(q));

	}
}