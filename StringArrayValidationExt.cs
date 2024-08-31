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
		/// <param name="value">The <see cref="string"/> array to check.</param>
		/// <returns>a <see cref="bool"/> value where <see cref="bool">true</see> represents success, and <see cref="bool">false</see> represents failure.</returns>
		public static bool IsValid(this string[] value) => value is not null && value.Length > 0;

	}
}