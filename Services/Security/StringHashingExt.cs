using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VAdvanceStringLibrary.Services.Security
{
	/// <summary>
	/// Provides hashing extension methods for the <see cref="String"/> class.
	/// </summary>
	public static class StringHashingExt
	{

		public static string Hash(this string source, HashingAlgorithms algorithm)
		{
			if(source.NotEmpty() && !algorithm.HasFlag(HashingAlgorithms.Normal))
			{

			}
		}

	}
}
