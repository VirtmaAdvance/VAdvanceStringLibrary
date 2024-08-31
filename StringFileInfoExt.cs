using System.Text;

namespace VAdvanceStringLibrary
{
	/// <summary>
	/// Provides file information extension methods for the string class.
	/// </summary>
	public static class StringFileInfoExt
	{
		/// <summary>
		/// Determines if the file path has an extension.
		/// </summary>
		/// <param name="value">The <see cref="string"/> value to analyze.</param>
		/// <returns>a <see cref="bool"/> value representation of the result from the validation where <see cref="bool">true</see> represents success, and <see cref="bool">false</see> represents failure.</returns>
		public static bool HasExtension(this string value) => value.IsFile() && Path.HasExtension(value);
		/// <summary>
		/// Gets the extension of the file.
		/// </summary>
		/// <param name="value">The <see cref="string"/> value to analyze.</param>
		/// <returns>a <see cref="bool"/> value representation of the result from the validation where <see cref="bool">true</see> represents success, and <see cref="bool">false</see> represents failure.</returns>
		public static string? GetExtension(this string value) => value.HasExtension() ? Path.GetExtension(value).ToLower() : null;
		/// <summary>
		/// Gets the file name (without it's extension).
		/// </summary>
		/// <param name="value">The <see cref="string"/> value to analyze.</param>
		/// <returns>a <see cref="bool"/> value representation of the result from the validation where <see cref="bool">true</see> represents success, and <see cref="bool">false</see> represents failure.</returns>
		public static string? GetFileName(this string value) => value.IsFile() ? Path.GetFileNameWithoutExtension(value) : null;
		/// <summary>
		/// Gets the size of a file.
		/// </summary>
		/// <param name="value">The <see cref="string"/> value to analyze.</param>
		/// <returns>a <see cref="bool"/> value representation of the result from the validation where <see cref="bool">true</see> represents success, and <see cref="bool">false</see> represents failure.</returns>
		public static long GetFileSize(this string value) => value.GetFileInfo().Length;
		/// <summary>
		/// Gets the <see cref="FileInfo"/> object.
		/// </summary>
		/// <param name="value">The <see cref="string"/> value to analyze.</param>
		/// <returns>a <see cref="bool"/> value representation of the result from the validation where <see cref="bool">true</see> represents success, and <see cref="bool">false</see> represents failure.</returns>
		/// <exception cref="ArgumentException"></exception>
		public static FileInfo GetFileInfo(this string value) => value.IsFile() ? new FileInfo(value) : throw new ArgumentException("The given path does not reference an existing file path.");
		

	}
}