namespace VAdvanceStringLibrary
{
	/// <summary>
	/// Provides case conversion for characters.
	/// </summary>
	public static class ToCaseCharExt
	{
		/// <summary>
		/// Formats the character into an uppercase character.
		/// </summary>
		/// <param name="value"></param>
		/// <returns></returns>
		public static char ToUpper(this char value) => value.ToString().ToUpper()[0];
		/// <summary>
		/// Formats the character into an lowercase character.
		/// </summary>
		/// <param name="value"></param>
		/// <returns></returns>
		public static char ToLower(this char value) => value.ToString().ToLower()[0];

	}
}