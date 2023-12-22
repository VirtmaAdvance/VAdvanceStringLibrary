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
		public static bool IsValid(this string? value) => !IsNullOrEmpty(value) && NotNullOrEmpty(value?.TrimEnds());
		/// <inheritdoc cref="IsValid(string)"/>
		/// <summary>
		/// Determines if the <paramref name="value"/> is valid for use as well as the <paramref name="values"/>.
		/// </summary>
		/// <remarks>Useful for condensed validation of multiple string values.</remarks>
		/// <param name="value"></param>
		/// <param name="values"></param>
		/// <returns></returns>
		public static bool IsValid(this string? value, params string[] values) => value.IsValid() && values.All(q=>q.IsValid());
		/// <summary>
		/// Determines if the <paramref name="value"/> is an empty string.
		/// </summary>
		/// <param name="value"></param>
		/// <exception cref="ArgumentNullException"></exception>
		/// <returns></returns>
		public static bool IsEmpty(this string? value) => string.IsNullOrEmpty(value);
		/// <summary>
		/// Determines if the <paramref name="value"/> is not an empty string value.
		/// </summary>
		/// <param name="value"></param>
		/// <returns></returns>
		public static bool NotEmpty(this string? value) => !IsEmpty(value);
		/// <summary>
		/// Determines if the <paramref name="value"/> is null nor empty.
		/// </summary>
		/// <param name="value"></param>
		/// <returns></returns>
		public static bool IsNullOrEmpty(this string? value) => string.IsNullOrEmpty(value);
		/// <summary>
		/// Determines if the <paramref name="value"/> is not null nor empty.
		/// </summary>
		/// <param name="value"></param>
		/// <returns></returns>
		public static bool NotNullOrEmpty(this string? value) => !value.IsNullOrEmpty();

	}
}