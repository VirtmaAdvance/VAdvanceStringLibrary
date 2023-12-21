namespace VAdvanceStringLibrary.Services.Internals.Numerical
{
	internal static class IntRangeExt
	{
		/// <summary>
		/// Determines if the <paramref name="source"/> is within the range.
		/// </summary>
		/// <param name="source"></param>
		/// <param name="min"></param>
		/// <param name="max"></param>
		/// <returns></returns>
		public static bool InRange(this int source, int min, int max) => source>=min && source<=max;
		/// <summary>
		/// Determines if the <paramref name="source"/> is in between the min and max values.
		/// </summary>
		/// <param name="source"></param>
		/// <param name="min"></param>
		/// <param name="max"></param>
		/// <returns></returns>
		public static bool InBetween(this int source, int min, int max) => source>min && source<max;
		/// <summary>
		/// Determines the nearest value the <paramref name="source"/> is closest to.
		/// </summary>
		/// <param name="source"></param>
		/// <param name="min"></param>
		/// <param name="max"></param>
		/// <returns></returns>
		public static int NearestTo(this int source, int min, int max)
		{
			int distToMin=GetDistanceValue(source, min);
			int distToMax=GetDistanceValue(source, max);
			return distToMin<distToMax ? distToMin : distToMax;
		}

		private static int GetDistanceValue(int a, int b) => Math.Max(a, b) - Math.Min(a, b);

	}
}