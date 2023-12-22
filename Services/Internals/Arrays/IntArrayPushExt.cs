namespace VAdvanceStringLibrary.Services.Internals.Arrays
{
	/// <summary>
	/// Provides an internal array push extension method.
	/// </summary>
	internal static class IntArrayPushExt
	{
		/// <summary>
		/// Pushes an item or set of items into the array.
		/// </summary>
		/// <typeparam name="TIn">The data-type.</typeparam>
		/// <param name="source">The source array.</param>
		/// <param name="values">The values/items to add to the array.</param>
		public static TIn[] Push<TIn>(this TIn[] source, params TIn[] values)
		{
			source??=Array.Empty<TIn>();
			values??=Array.Empty<TIn>();
			TIn[] res=source;
			Array.Resize(ref res, source.Length+values.Length);
			Array.Copy(values, 0, res, source.Length, values.Length);
			return res;
			//if(source!=null)
			//{
			//	Array.Resize(ref res, source.Length);
			//	for(int i=0;i<source.Length;i++)
			//		res[i]=source[i];
			//}
			//if((values!=null) && values.Length>0)
			//{
			//	int index=res.Length;
			//	Array.Resize(ref res, res.Length+values.Length);
			//	for(int i = 0;i<values.Length;i++)
			//		res[i+index]=values[i];
			//}
			//return res;
		}

	}
}