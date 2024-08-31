namespace VAdvanceStringLibrary
{
	/// <summary>
	/// Provides an extension method to split a string for the string class.
	/// </summary>
	public static class StringSplitExt
	{
		/// <summary>
		/// Gets a <see cref="string"/> array that contains the sub-string values within the source string value, or the source string value within the array.
		/// </summary>
		/// <param name="stringValue">The source <see cref="string"/> value.</param>
		/// <param name="subStringValue">The <see cref="string"/> value to split the <paramref name="stringValue"/> at.</param>
		/// <returns>a <see cref="string"/> array of the substring values.</returns>
		public static string[] Split(this string stringValue, string subStringValue) => stringValue.NotEmpty() && subStringValue.NotEmpty() && stringValue.Contains(subStringValue) ? stringValue.Split(subStringValue) : new string[] { stringValue };

	}
}