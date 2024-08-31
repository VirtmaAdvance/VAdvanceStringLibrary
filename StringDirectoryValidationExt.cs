namespace VAdvanceStringLibrary
{
	/// <summary>
	/// Provides directory validation extension methods for the string class.
	/// </summary>
	public static class StringDirectoryValidationExt
	{
		/// <summary>
		/// Determines if the <paramref name="value"/> references an existing directory path.
		/// </summary>
		/// <param name="value">The <see cref="string"/> representation of the directory path to validate.</param>
		/// <returns>a <see cref="bool"/> value representation of the result from the validation where <see cref="bool">true</see> represents success, and <see cref="bool">false</see> represents failure.</returns>
		public static bool IsDirectory(this string value) => value.IsValid() && Directory.Exists(value);

	}
}