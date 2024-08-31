namespace VAdvanceStringLibrary
{
	/// <summary>
	/// Provides file validation extension methods for the string class.
	/// </summary>
	public static class StringFileValidationExt
	{
		/// <summary>
		/// Determines if the <paramref name="value"/> references an existing file path.
		/// </summary>
		/// <param name="value">The <see cref="string"/> value to analyze.</param>
		/// <returns>a <see cref="bool"/> value representation of the result from the validation where <see cref="bool">true</see> represents success, and <see cref="bool">false</see> represents failure.</returns>
		public static bool IsFile(this string value) => value.IsValid() && File.Exists(value);

	}
}