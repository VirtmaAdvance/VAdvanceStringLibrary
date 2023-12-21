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
		/// <param name="value"></param>
		/// <returns></returns>
		public static bool IsFile(this string value) => value.IsValid() && File.Exists(value);

	}
}