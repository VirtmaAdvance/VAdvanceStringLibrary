namespace VAdvanceStringLibrary
{
	/// <summary>
	/// Provides validation extension methods for string array objects.
	/// </summary>
	public static class StringArrayValidationExt
	{
		/// <summary>
		/// Determines if the <paramref name="value"/> is valid for use.
		/// </summary>
		/// <param name="value"></param>
		/// <returns></returns>
		public static bool IsValid(this string[] value) => value is not null && value.Length > 0;

	}
}