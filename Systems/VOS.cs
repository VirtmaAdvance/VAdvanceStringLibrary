namespace VAdvanceStringLibrary.Systems
{
	/// <summary>
	/// Provides Operating System information.
	/// </summary>
	public static class VOS
	{
		/// <summary>
		/// The Operating System type currently in use.
		/// </summary>
		public static OperatingSystemFlags OS
		{
			get
			{
				OperatingSystem os=Environment.OSVersion;
				if(os.Platform==PlatformID.Win32NT)
					return OperatingSystemFlags.Windows;
				if(os.Platform==PlatformID.Unix)
					return IsMac() ? OperatingSystemFlags.Mac : OperatingSystemFlags.Linux;
				return OperatingSystemFlags.Unknown;
			}
		}

		private static bool IsMac() => Environment.OSVersion.VersionString.Contains("Darwin");

	}
}
