namespace VAdvanceStringLibrary
{
	/// <summary>
	/// String extension for calculating string value similarities.
	/// </summary>
	public static class StringSimilarTextExt
	{
		/// <summary>
		/// Calculates the similarity between the <paramref name="source"/> and the <paramref name="value"/>.
		/// </summary>
		/// <param name="source">The source string value.</param>
		/// <param name="value">The string value to compare the source to.</param>
		/// <param name="percent">The percentage value to use.</param>
		/// <returns>the percentage of similarity between the two string values.</returns>
		public static double SimilarText(this string source, string value, int percent = -1)
		{
			if(source.IsValid(value))
			{
				int pos1=-1, pos2=-1, max=0, l;
				for(int p = 0;p<source.Length;++p)
					for(int q = 0;q<value.Length;++q)
					{
						for(l=0;(p+l<source.Length) && (q+l<value.Length) && source.Substring(p+l, 1)==value.Substring(q+l, 1);++l) { }
						if(l>max)
						{
							max=l;
							pos1=p;
							pos2=q;
						}
					}
				double similarity=max;
				if(pos1>-1&&pos2>-1)
					similarity+=source.Substring(0, pos1).SimilarText(value.Substring(0, pos2), percent);
				if((pos1 + max < source.Length) && (pos2 + max < value.Length))
					similarity+=source.Substring(pos1+max, source.Length-pos1-max).SimilarText(value.Substring(pos2+max, value.Length-pos2-max), percent);
				return similarity*200 / (source.Length+value.Length);
			}
			return source==null && value==null ? 100 : 0;
		}

	}
}