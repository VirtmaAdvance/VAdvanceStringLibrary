using VAdvanceStringLibrary.FileSystemIO;

namespace VAdvanceStringLibrary
{
	/// <summary>
	/// Provides path security extension methods for the string class.
	/// </summary>
	public static class StringPathSecurityExt
	{
		/// <summary>
		/// Used to store path access information.
		/// </summary>
		private static readonly PathAccess s_pathAccess = new ();
		/// <summary>
		/// Determines if the <paramref name="path"/> is accessible/readable.
		/// </summary>
		/// <param name="path">The <see cref="string"/> representation of an existing file or directory path.</param>
		/// <returns>a <see cref="bool">boolean</see> value representing the success of the operation where <see cref="bool">true</see> represents success, and <see cref="bool">false</see> otherwise.</returns>
		public static bool HasAccess(this string path) => s_pathAccess.HasAccess(path);

	}
}