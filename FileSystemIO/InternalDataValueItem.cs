namespace VAdvanceStringLibrary.FileSystemIO
{
	/// <summary>
	/// Internal data value object.
	/// </summary>
	internal struct InternalDataValueItem
	{

		/// <summary>
		/// The simplified value of the <see cref="DataValue"/>.
		/// </summary>
		public readonly double Value;
		/// <summary>
		/// The unit value that the <see cref="Value"/> was simplified to.
		/// </summary>
		public readonly string Unit;


		/// <summary>
		/// Creates a new instance of the <see cref="InternalDataValueItem"/>.
		/// </summary>
		/// <param name="value">The numerical value to process.</param>
		/// <param name="decimalPlaces">The number of decimal places to view.</param>
		public InternalDataValueItem(long value, int decimalPlaces=2)
		{
			const long byteLimit=1024;
			string[] units=GetDataUnits();
			int i=0;
			double size=value;
			while(size>=byteLimit && i<units.Length-1)
			{
				size/=byteLimit;
				i++;
			}
			int tmp=(int)Math.Pow(10,decimalPlaces);
			Value=Math.Floor(size * tmp) / tmp;
			Unit=units[i];
		}

		private static string[] GetDataUnits() => Enum.GetNames(typeof(DataUnits));

	}
}