using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace VAdvanceStringLibrary
{
	/// <summary>
	/// Provides length extension methods for the string class.
	/// </summary>
	public static class StringLengthExt
	{
		/// <summary>
		/// Gets the length of the <paramref name="value"/>.
		/// </summary>
		/// <param name="value">A <see cref="string"/> value.</param>
		/// <returns></returns>
		public static int Count(this string value) => value?.Length??0;

	}
}
