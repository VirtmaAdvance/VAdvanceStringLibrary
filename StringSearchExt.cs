using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

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
		/// <param name="haystack"></param>
		/// <param name="needles"></param>
		/// <returns></returns>
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
