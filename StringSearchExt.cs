using System.Text.RegularExpressions;

namespace VAdvanceStringLibrary
{
	/// <summary>
	/// Provides search extension methods for the string class.
	/// </summary>
	public static class StringSearchExt
	{
		/// <summary>
		/// Determines the number of times one of the <paramref name="needles"/> was found in the <paramref name="haystack"/>.
		/// </summary>
		/// <param name="haystack">The <see cref="string"/> value to search through.</param>
		/// <param name="needles">The <see cref="string"/>s to look for within the <paramref name="haystack"/>.</param>
		/// <returns>an <see cref="int"/> value representing the number of <paramref name="needles"/> found.</returns>
		public static int Count(this string haystack, params string[] needles)
		{
			int res=0;
			if(haystack.IsValid() && ((needles!=null) && needles.Length>0))
				foreach(string substring in needles)
				{
					string escapedString=Regex.Escape(substring);
					if(Regex.IsMatch(haystack, escapedString))
						res+=Regex.Matches(haystack, escapedString).Count;
				}
			return res;
		}
	}
}