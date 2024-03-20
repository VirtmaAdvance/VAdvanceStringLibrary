namespace VAdvanceStringLibrary.Services.Internals.Objects
{
	internal static class IntObjectValidationExt
	{
		/// <summary>
		/// Determines if the <paramref name="value"/> is <see langword="null"/>.
		/// </summary>
		/// <param name="value">The value to analyze.</param>
		/// <returns><see cref="bool">true</see> upon success, <see cref="bool">false</see> otherwise.</returns>
		public static bool IsNull(this object? value) => value is null;
		/// <inheritdoc cref="IsNull(object?)" />
		public static bool NotNull(this object? value) => !value.IsNull();

	}
}