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
			if(lnkPath.IsFile())
			{
				if(lnkPath.GetExtension()=="lnk")
				{
					WshShell shell = new ();
					IWshShortcut shortcut = (IWshShortcut)shell.CreateShortcut(lnkPath);
					string path=shortcut.TargetPath;
					if(!path.IsFile())
						if(path.Contains("Program Files (x86)"))
							path=path.Replace("Program Files (x86)", "Program Files");
					return path;
				}
			}
			return null;
		}

	}
}