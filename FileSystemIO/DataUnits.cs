namespace VAdvanceStringLibrary.FileSystemIO
{
	/// <summary>
	/// Provides a means to identify a data unit.
	/// </summary>
	[Flags]
	public enum DataUnits
	{
		/// <summary>
		/// Represents the numerical value is measured in bytes (8 bits).
		/// </summary>
		B=0x0,
		/// <summary>
		/// Indicates the value has been simplified by a given factor.
		/// </summary>
		KB=0x1,
		/// <inheritdoc cref="KB"/>
		MB=0x2,
		/// <inheritdoc cref="KB"/>
		GB=0x4,
		/// <inheritdoc cref="KB"/>
		TB=0x8,
		/// <inheritdoc cref="KB"/>
		PB=0x10,
		/// <inheritdoc cref="KB"/>
		EB=0x20,
		/// <inheritdoc cref="KB"/>
		ZB=0x40,
		/// <inheritdoc cref="KB"/>
		YB=0x80,
		/// <inheritdoc cref="KB"/>
		BB=0x100,
	}
}
