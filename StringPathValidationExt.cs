namespace VAdvanceStringLibrary
{
	/// <summary>
	/// Provides path validation extension methods for the string class.
	/// </summary>
	public static class StringPathValidationExt
	{
		/// <summary>
		/// Determines if the <paramref name="value"/> references an existing file or directory path.
		/// </summary>
		/// <param name="value">The <see cref="string"/> representation of a file system path.</param>
		/// <returns>a <see cref="bool"/> value representation of the result from the validation where <see cref="bool">true</see> represents success, and <see cref="bool">false</see> represents failure.</returns>
		public static bool PathExists(this string value) => value.IsFile() || value.IsDirectory();

	}
}