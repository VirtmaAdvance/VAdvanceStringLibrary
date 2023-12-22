using IWshRuntimeLibrary;

namespace VAdvanceStringLibrary
{
	/// <summary>
	/// Provides an extension method to get the absolute path from an .lnk file.
	/// </summary>
	public static class StringPathLnkExt
	{
		/// <summary>
		/// Gets the target path of the <paramref name="lnkPath"/>.
		/// </summary>
		/// <param name="lnkPath">A <see cref="string"/> representation of an existing lnk file path.</param>
		/// <returns>the target path from the <paramref name="lnkPath"/> upon success, null otherwise.</returns>
		public static string? GetPathFromLnk(this string lnkPath)
		{
			if(lnkPath.IsFile() && lnkPath.GetExtension()=="lnk")
			{
				string path=GetShortcut(lnkPath).TargetPath;
				return (!path.IsFile()) && path.Contains("Program Files (x86)") ? path.Replace("Program Files (x86)", "Program Files") : path;
			}
			return null;
		}

		private static IWshShortcut GetShortcut(string path) => (IWshShortcut)(new WshShell()).CreateShortcut(path);

	}
}