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
		public static TIn[] Merge<TIn>(this TIn[] source, params TIn[] values)
		{
			if(source is null)
				source=Array.Empty<TIn>();
			if(values is null)
				values=Array.Empty<TIn>();
			TIn[] res=source;
			int i=source.GetLength();
			int len=source.GetLength()+values.GetLength();
			Array.Resize(ref res, len);
			for(;i<len;i++)
				res[i]=values[i];
			return res;
		}

	}
}
