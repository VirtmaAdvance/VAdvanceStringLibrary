using System.Runtime.InteropServices;
using System.Text.RegularExpressions;

namespace VAdvanceStringLibrary
{
	/// <summary>
	/// Provides soundex operation extension methods for the string class.
	/// </summary>
	public static class StringSoundexExt
	{

		/// <summary>
		/// Calculates the soundex from the string value.
		/// </summary>
		/// <param name="value">The string value that will be calculated.</param>
		/// <returns>a <see cref="string">value</see> representing the soundex of the given value.</returns>
		public static string Soundex(this string value)
		{
			string res=string.Empty;
			if(value.IsValid())
			{
				string str=GetStringReplacementSoundexRef(value);
				res+=value[0].ToUpper();
				for(int i=0;res.Length<Math.Min(4, str.Length+1);i++)
					res+=GetSoundexCodeFromCharacter(str[i]);
				while(res.Length<4)
					res+='0';
			}
			return res;
		}

		private static string GetStringReplacementUpperCase(string value) => Regex.Replace(value.Substring(1,value.Length-1),"[\\s]+","").ToUpper();
		/// <summary>
		/// Gets the string replacement for use by the soundex reference.
		/// </summary>
		/// <param name="value">The <see cref="string"/> value to process.</param>
		/// <returns>the modified <see cref="string"/> value.</returns>
		private static string GetStringReplacementSoundexRef(string value)
		{
			string str=GetStringReplacementUpperCase(value);
			return Regex.Replace(Regex.IsMatch(str, SoundexReferenceData.IgnoredRegex) ? Regex.Replace(str, SoundexReferenceData.IgnoredRegex, "") : str, "(.)\\1{1,}", "$1");
		}
		/// <summary>
		/// Gets the soundex code from the given character value.
		/// </summary>
		/// <param name="value">The character that will be checked.</param>
		/// <returns>a <see cref="char">value</see> representing the soundex code.</returns>
		public static char GetSoundexCodeFromCharacter(char value)
		{
			string v=value.ToString();
			foreach(KeyValuePair<string, char> r in SoundexReferenceData.ItemsRegexChar)
				if(Regex.IsMatch(v, r.Key))
					return r.Value;
			return '0';
		}

	}
}
