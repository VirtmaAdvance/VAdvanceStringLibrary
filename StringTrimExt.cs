namespace VAdvanceStringLibrary
{
	/// <summary>
	/// Provides triming extension methods for the string class.
	/// </summary>
	public static class StringTrimExt
	{
		/// <summary>
		/// Trims whitespace characters (If present) at the beginning and end of the string value.
		/// </summary>
		/// <param name="value"></param>
		/// <returns></returns>
		public static string TrimEnds(this string value) => !string.IsNullOrEmpty(value) ? value.Trim() : "";

	}
}