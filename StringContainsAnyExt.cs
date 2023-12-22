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
		/// <param name="value"></param>
		/// <param name="values"></param>
		/// <returns></returns>
		public static bool ContainsAny(this string value, params string[] values) => !value.IsEmpty() && values.IsValid() && values.Any(q=>value.Contains(q));
		/// <summary>
		/// Determines if all of the <paramref name="values"/> were found in the <paramref name="value"/>.
		/// </summary>
		/// <param name="value"></param>
		/// <param name="values"></param>
		/// <returns></returns>
		public static bool ContainsAll(this string value, params string[] values) => !value.IsEmpty() && values.IsValid() && values.All(q=>value.Contains(q));

	}
}
