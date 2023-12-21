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
		/// <param name="value"></param>
		/// <returns></returns>
		public static bool PathExists(this string value) => value.IsFile() || value.IsDirectory();

	}
}