namespace VAdvanceStringLibrary
{
	/// <summary>
	/// Provides an extension method to reverse a string value for the string class.
	/// </summary>
	public static class StringReverseExt
	{
		/// <summary>
		/// Reverses the <paramref name="value"/>.
		/// </summary>
		/// <param name="value"></param>
		/// <returns></returns>
		public static string Reverse(this string value)
		{
			if(value.IsValid())
			{
				string res="";
				foreach(char c in value)
					res=c+res;
				return res;
			}
			return value;
		}

	}
}