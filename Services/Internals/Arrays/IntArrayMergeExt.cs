namespace VAdvanceStringLibrary.Services.Internals.Arrays
{
	internal static class IntArrayMergeExt
	{
		/// <summary>
		/// Merges two arrays.
		/// </summary>
		/// <typeparam name="TIn"></typeparam>
		/// <param name="source"></param>
		/// <param name="values"></param>
		/// <returns></returns>
		public static TIn[] Merge<TIn>(this TIn[]? source, params TIn[]? values)
		{
			source=source.Get();
			values=values.Get();
			TIn[] res=source;
			return Prv_Merge(res, values);
			//int i=source.Length;
			//int len=i+values.Length;
			//Array.Resize(ref res, len);
			//for(;i<len;i++)
			//	res[i]=values[i];
			//return res;
		}

		private static TIn[] Prv_Merge<TIn>(TIn[] res, TIn[] values)
		{
			int len=res.Length+values.Length;
			Array.Resize(ref res, len);
			for(int i=res.Length;i<len;i++)
				res[i]=values[i];
			return res;
		}

	}
}
