namespace VAdvanceStringLibrary.FileSystemIO
{
	/// <summary>
	/// Provides a set of generalized file system permission flags (Designed to be compatible with all OS types).
	/// </summary>
	[Flags]
	public enum FilePermissionFlags
	{
		/// <summary>
		/// File permissions cannot be determined.
		/// </summary>
		Unknown=0x0,
		/// <summary>
		/// The path item can be shown.
		/// </summary>
		List=0x1,
		/// <summary>
		/// The path item can be read from.
		/// </summary>
		Read=0x2,
		/// <summary>
		/// THe path item can be written to.
		/// </summary>
		Write=0x4,
		/// <summary>
		/// The path item can be executed.
		/// </summary>
		Execute=0x8,

	}
}
