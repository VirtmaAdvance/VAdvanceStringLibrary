using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VAdvanceStringLibrary.FileSystemIO
{
	/// <summary>
	/// Stores a data value.
	/// </summary>
	public struct DataValue
	{

		/// <summary>
		/// The value represented as in bytes.
		/// </summary>
		public readonly long ByteValue;
		private readonly InternalDataValueItem DataInfo;
		/// <summary>
		/// The simplified value of the <see cref="ByteValue"/>.
		/// </summary>
		public double Value => DataInfo.Value;
		/// <summary>
		/// The unit value that the <see cref="Value"/> was simplified to.
		/// </summary>
		public string Unit => DataInfo.Unit;


		/// <inheritdoc cref="DataValue(long, int)"/>
		public DataValue(long value)
		{
			ByteValue=value;
			DataInfo=new(value);
		}
		/// <summary>
		/// Creates a new instance of the <see cref="DataValue"/> struct object.
		/// </summary>
		/// <param name="value">A numerical value representing the data size to process.</param>
		/// <param name="decimalPlaces">A numerical value representing the number of decimal places to view.</param>
		public DataValue(long value, int decimalPlaces)
		{
			ByteValue=value;
			DataInfo=new(value, decimalPlaces);
		}
		/// <inheritdoc/>
		public new string ToString() => Value.ToString() + " " + Unit;

	}
}
