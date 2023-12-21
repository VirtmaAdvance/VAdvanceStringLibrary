namespace VAdvanceStringLibrary.Systems
{
	/// <summary>
	/// Provides a list of available OS types.
	/// </summary>
	[Flags]
	public enum OperatingSystemFlags
	{
		/// <summary>
		/// Unknown OS.
		/// </summary>
		Unknown=0x0,
		/// <summary>
		/// Windows OS.
		/// </summary>
		Windows=0x1,
		/// <summary>
		/// Linux OS.
		/// </summary>
		Linux=0x2,
		/// <summary>
		/// MAC OS.
		/// </summary>
		Mac=0x3,

	}
}
