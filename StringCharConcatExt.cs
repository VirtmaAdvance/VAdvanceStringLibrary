namespace VAdvanceStringLibrary
{
	/// <summary>
	/// String character contacentation extension methods.
	/// </summary>
	public static class StringCharConcatExt
	{
		/// <summary>
		/// Compresses the array of chars into a single string value.
		/// </summary>
		/// <param name="source">The array of characters to convert.</param>
		/// <returns>the <see cref="string"/> representation of the character array conversion.</returns>
		public static string GetString(this char[] source)
		{
			string res="";
			foreach(var sel in source)
				res+=sel;
			return res;
		}

	}
}