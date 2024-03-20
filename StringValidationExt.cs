using VAdvanceStringLibrary.Services.Internals.Objects;

namespace VAdvanceStringLibrary
{
	/// <summary>
	/// Provides string validation methods.
	/// </summary>
	public static class StringValidationExt
	{
		/// <inheritdoc cref="IntObjectValidationExt.IsNull(object?)" path="//*[not(self::summary)]" />
		/// <summary>
		/// Determines if the <paramref name="value"/> is valid for use.
		/// </summary>
		public static bool IsValid(this string? value) => !IsNullOrEmpty(value) && NotNullOrEmpty(value?.TrimEnds());
		/// <inheritdoc cref="IsValid(string)" path="//*[self::returns]"/>
		/// <summary>
		/// Determines if the <paramref name="value"/> is valid for use as well as the <paramref name="values"/>.
		/// </summary>
		/// <remarks>Useful for condensed validation of multiple string values.</remarks>
		/// <param name="value">The <see cref="string"/> value to analyze.</param>
		/// <param name="values">Additional values to validate.</param>
		public static bool IsValid(this string? value, params string[] values) => value.IsValid() && values.All(q=>q.IsValid());
		/// <inheritdoc cref="IsValid(string?)" path="//*[self::returns] | //*[self::param]"/>
		/// <summary>
		/// Determines if the <paramref name="value"/> is an empty string.
		/// </summary>
		/// <exception cref="ArgumentNullException"></exception>
		public static bool IsEmpty(this string? value) => value.IsNull() ? throw new ArgumentNullException() : string.IsNullOrEmpty(value);
		/// <inheritdoc cref="IsValid(string?)" path="//*[not(self::summary)]" />
		/// <summary>
		/// Determines if the <paramref name="value"/> is not an empty string value.
		/// </summary>
		public static bool NotEmpty(this string? value) => !IsEmpty(value);
		/// <inheritdoc cref="IsValid(string?)" path="//*[not(self::summary)]" />
		/// <summary>
		/// Determines if the <paramref name="value"/> is null nor empty.
		/// </summary>
		public static bool IsNullOrEmpty(this string? value) => string.IsNullOrEmpty(value);
		/// <inheritdoc cref="IsValid(string?)" path="//*[not(self::summary)]" />
		/// <summary>
		/// Determines if the <paramref name="value"/> is not null nor empty.
		/// </summary>
		public static bool NotNullOrEmpty(this string? value) => !value.IsNullOrEmpty();

	}
}