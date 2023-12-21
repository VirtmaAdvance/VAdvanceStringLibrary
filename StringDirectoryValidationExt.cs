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
		/// <param name="value"></param>
		/// <returns></returns>
		public static bool IsDirectory(this string value) => value.IsValid() && Directory.Exists(value);

	}
}