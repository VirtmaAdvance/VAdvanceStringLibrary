using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VAdvanceStringLibrary.Services.Internals.Arrays
{
	internal static class IntArrayInfoExt
	{

		public static int GetLength<TIn>(this TIn[] source) => source is null ? 0 : source.Length;

	}
}
