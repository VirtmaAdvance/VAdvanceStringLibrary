namespace VAdvanceStringLibrary
{
	/// <summary>
	/// Provides string validation methods.
	/// </summary>
	public static class StringValidationExt
	{
		/// <summary>
		/// Determines if the <paramref name="value"/> is valid for use.
		/// </summary>
		/// <param name="value"></param>
		/// <returns></returns>
		public static bool IsValid(this string value) => !IsNullOrEmpty(value) &&NotNullOrEmpty(value.TrimEnds());
		/// <summary>
		/// Determines if the <paramref name="value"/> is null nor empty.
		/// </summary>
		/// <param name="value"></param>
		/// <returns></returns>
		public static bool IsNullOrEmpty(this string value) => string.IsNullOrEmpty(value);
		/// <summary>
		/// Determines if the <paramref name="value"/> is not null nor empty.
		/// </summary>
		/// <param name="value"></param>
		/// <returns></returns>
		public static bool NotNullOrEmpty(this string value) => !value.IsNullOrEmpty();

	}
}