namespace VAdvanceStringLibrary.Services.Internals.Arrays
{
	internal static class IntArrayGetExt
	{
		/// <summary>
		/// Gets the array or an empty array if null.
		/// </summary>
		/// <typeparam name="TIn"></typeparam>
		/// <param name="array"></param>
		/// <returns></returns>
		public static TIn[] Get<TIn>(this TIn[]? array) => array is null ? Array.Empty<TIn>() : array;

	}
}
