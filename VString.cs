using System.Collections;
using System.Text;
using VAdvanceStringLibrary.Services.Internals.Numerical;

namespace VAdvanceStringLibrary
{
	/// <summary>
	/// A derivable <see cref="string"/> equivalent class.
	/// </summary>
	public class VString : IEquatable<VString>, IComparable<VString>, IDisposable, IEnumerable<char>, IFormattable, IConvertible
	{

		private string? _value;
		/// <summary>
		/// The <see cref="string"/> value.
		/// </summary>
		public string Value
		{
			get => _value??"";
			protected set
			{
				_value=value;
				_byteArray=Encoder.GetBytes(_value);
			}
		}
		/// <summary>
		/// Gets the length of the substringValue.
		/// </summary>
		public int Length => Value?.Length??-1;
		/// <summary>
		/// Gets or sets the value at the given <paramref name="index"/>.
		/// </summary>
		/// <param name="index"></param>
		/// <returns></returns>
		/// <exception cref="IndexOutOfRangeException"></exception>
		public char this[int index]
		{
			get => InRange(index) ? Value![index] : throw new IndexOutOfRangeException();
			set
			{
				if(Value is null)
					Value=value.ToString();
				else
				{
					if (InRange(index))
					{
						string beginning = Value.Substring(0, index - 1);
						int calc = index + 1;
						string ending = Value.Substring(calc, Length - calc);
						Value = beginning + value + ending;
					}
					else if(index.NearestTo(0, Length)==0)
						Value=value.ToString()+Value;
					else
						Value+=value.ToString();
				}
			}
		}
		private Encoding _encoder=Encoding.Unicode;
		/// <summary>
		/// The <see cref="Encoding"/> object being used.
		/// </summary>
		public Encoding Encoder
		{
			get => _encoder;
			set
			{
				if(value is not null && value!=_encoder)
				{
					byte[] tmp=_encoder.GetBytes(Value);
					_encoder=value;
					ByteArray=tmp;
				}
			}
		}
		private byte[] _byteArray=Array.Empty<byte>();
		/// <summary>
		/// The byte array representation of the stored string value.
		/// </summary>
		public byte[] ByteArray
		{
			get => _byteArray;
			set
			{
				_byteArray=value;
				_value=Encoder.GetString(_byteArray);
			}
		}
		/// <summary>
		/// The data size of the string value.
		/// </summary>
		public long Size => ByteArray.LongLength;


		/// <inheritdoc cref="VString(string)"/>
		public VString() : this("") { }
		/// <summary>
		/// Creates a new instance of the <see cref="VString"/> class.
		/// </summary>
		/// <param name="value"></param>
		public VString(string value)
		{
			Value=value;
		}
		/// <inheritdoc cref="VString(string)"/>
		public VString(params char[] value) => Value=value.GetString();
		/// <inheritdoc cref="VString(string)"/>
		public static explicit operator VString(string value) => new(value);
		/// <inheritdoc cref="VString(string)"/>
		public static explicit operator VString(char value) => new(value);
		/// <inheritdoc cref="VString(string)"/>
		public static explicit operator VString(byte value) => new(value.ToString());
		/// <inheritdoc cref="VString(string)"/>
		public static explicit operator VString(sbyte value) => new(value.ToString());
		/// <inheritdoc cref="VString(string)"/>
		public static explicit operator VString(int value) => new(value.ToString());
		/// <inheritdoc cref="VString(string)"/>
		public static explicit operator VString(uint value) => new(value.ToString());
		/// <inheritdoc cref="VString(string)"/>
		public static explicit operator VString(ushort value) => new(value.ToString());
		/// <inheritdoc cref="VString(string)"/>
		public static explicit operator VString(short value) => new(value.ToString());
		/// <inheritdoc cref="VString(string)"/>
		public static explicit operator VString(ulong value) => new(value.ToString());
		/// <inheritdoc cref="VString(string)"/>
		public static explicit operator VString(long value) => new(value.ToString());
		/// <inheritdoc cref="VString(string)"/>
		public static explicit operator VString(double value) => new(value.ToString());
		/// <inheritdoc cref="VString(string)"/>
		public static explicit operator VString(decimal value) => new(value.ToString());
		/// <inheritdoc cref="VString(string)"/>
		public static explicit operator VString(float value) => new(value.ToString());
		/// <inheritdoc cref="VString(string)"/>
		public static explicit operator VString(bool value) => new(value ? "TRUE" : "FALSE");
		/// <inheritdoc cref="VString(string)"/>
		public static explicit operator VString(System.Net.NetworkInformation.NetworkInterface value) => new(value.Name);
		/// <inheritdoc cref="VString(string)"/>
		public static explicit operator VString(System.Net.IPAddress value) => new(value.ToString());
		/// <inheritdoc cref="VString(string)"/>
		public static explicit operator VString(DateTime value) => new(value.ToString("MM-dd-yyyy | HH:mm:ss tt"));

		/// <summary>
		/// Determines if the <see cref="Value"/> contains the <paramref name="substringValue"/>.
		/// </summary>
		/// <param name="substringValue"></param>
		/// <returns></returns>
		public bool Contains(string substringValue) => Value.Contains(substringValue);
		/// <summary>
		/// Get sthe number of characters within the string value.
		/// </summary>
		/// <returns>an <see cref="int"/> representation of the number of characters in the string value.</returns>
		public int Count() => Length;
		/// <summary>
		/// Gets the number of instances the given <paramref name="needles"/> were found within the string value.
		/// </summary>
		/// <param name="needles">The <see cref="string"/> values representing the substrings to find within this <see cref="string"/> value.</param>
		/// <returns>an <see cref="int"/> representation of the <paramref name="needles"/> found.</returns>
		public int Count(string needles) => Value.Count(needles);
		/// <summary>
		/// Appends the <paramref name="value"/>.
		/// </summary>
		/// <param name="value"></param>
		public void Append(string value) => Value+=value;
		/// <summary>
		/// Prepends the <paramref name="value"/>.
		/// </summary>
		/// <param name="value"></param>
		public void Prepend(string value) => Value=value+Value;
		/// <summary>
		/// Gets the <see cref="string"/> representation of this object.
		/// </summary>
		/// <returns></returns>
		public new string ToString() => Value??"";
		/// <summary>
		/// Determines if the <paramref name="index"/> references a valid index position in the substringValue.
		/// </summary>
		/// <param name="index"></param>
		/// <returns></returns>
		protected bool InRange(int index) => index>-1 && index<Length;
		/// <summary>
		/// Determines the index position of the given <paramref name="value"/>.
		/// </summary>
		/// <param name="value"></param>
		/// <returns></returns>
		public int IndexOf(string value) => Value.IndexOf(value);
		/// <inheritdoc cref="IndexOf(string)"/>
		public int IndexOf(char value) => Value.IndexOf(value);
		/// <summary>
		/// Compares this value with another.
		/// </summary>
		/// <param name="other"></param>
		/// <returns></returns>
		public bool Equals(VString? other) => (other is null && this is null) || (other is not null && this is not null && other.Value==Value);
		/// <summary>
		/// Compares this value with another.
		/// </summary>
		/// <param name="other"></param>
		/// <returns></returns>
		public int CompareTo(VString? other)
		{
			other??=new VString();
			return Value.CompareTo(other?.Value);
		}
		/// <summary>
		/// Disposes this object.
		/// </summary>
		public void Dispose() => Value="";
		/// <summary>
		/// Gets the enumerator.
		/// </summary>
		/// <returns></returns>
		public IEnumerator<char> GetEnumerator() => Value.GetEnumerator();

		IEnumerator IEnumerable.GetEnumerator() => Value.GetEnumerator();
		/// <summary>
		/// Appends the second value to the first.
		/// </summary>
		/// <param name="a"></param>
		/// <param name="b"></param>
		/// <returns></returns>
		public static VString operator +(VString a, VString b) => new(a.Value+=b.Value);
		/// <summary>
		/// Prepends the second value to the first.
		/// </summary>
		/// <param name="a"></param>
		/// <param name="b"></param>
		/// <returns></returns>
		public static VString operator -(VString a, VString b) => new(a.Value=b.Value+a.Value);
		/// <summary>
		/// Compares this value with another.
		/// </summary>
		/// <param name="obj"></param>
		/// <returns></returns>
		/// <exception cref="NotImplementedException"></exception>
		public override bool Equals(object? obj) => obj is null && this is null || (ReferenceEquals(this, obj) ||(obj is null ? false : throw new NotImplementedException()));
		/// <summary>
		/// Gets the hash code of this object.
		/// </summary>
		/// <returns></returns>
		public override int GetHashCode() => Value.GetHashCode();
		/// <summary>
		/// Gets the <see cref="string"/> representation of the stored value.
		/// </summary>
		/// <param name="format"></param>
		/// <param name="formatProvider"></param>
		/// <returns></returns>
		public string ToString(string? format, IFormatProvider? formatProvider) => Value.ToString(formatProvider);
		/// <summary>
		/// Gets the <see cref="TypeCode"/> of the value.
		/// </summary>
		/// <returns></returns>
		public TypeCode GetTypeCode() => Value.GetTypeCode();
		/// <summary>
		/// Converts this object to a another data type.
		/// </summary>
		/// <param name="provider"></param>
		/// <returns></returns>
		public bool ToBoolean(IFormatProvider? provider) => Length>0;
		/// <inheritdoc cref="ToBoolean(IFormatProvider?)"/>
		public byte ToByte(IFormatProvider? provider) => Convert.ToByte(Value);
		/// <inheritdoc cref="ToBoolean(IFormatProvider?)"/>
		public char? ToChar(IFormatProvider? provider) => Length>0 ? Value[0] : null;
		/// <inheritdoc cref="ToBoolean(IFormatProvider?)"/>
		public DateTime ToDateTime(IFormatProvider? provider) => DateTime.Parse(Value, provider);
		/// <inheritdoc cref="ToBoolean(IFormatProvider?)"/>
		public decimal ToDecimal(IFormatProvider? provider) => Convert.ToDecimal(Value);
		/// <inheritdoc cref="ToBoolean(IFormatProvider?)"/>
		public double ToDouble(IFormatProvider? provider) => Convert.ToDouble(Value);
		/// <inheritdoc cref="ToBoolean(IFormatProvider?)"/>
		public short ToInt16(IFormatProvider? provider) => Convert.ToInt16(Value);
		/// <inheritdoc cref="ToBoolean(IFormatProvider?)"/>
		public int ToInt32(IFormatProvider? provider) => Convert.ToInt32(Value);
		/// <inheritdoc cref="ToBoolean(IFormatProvider?)"/>
		public long ToInt64(IFormatProvider? provider) => Convert.ToInt64(Value);
		/// <inheritdoc cref="ToBoolean(IFormatProvider?)"/>
		public sbyte ToSByte(IFormatProvider? provider) => Convert.ToSByte(Value);
		/// <inheritdoc cref="ToBoolean(IFormatProvider?)"/>
		public float ToSingle(IFormatProvider? provider) => Convert.ToSingle(Value);
		/// <inheritdoc cref="ToString()"/>
		public string ToString(IFormatProvider? provider) => Convert.ToString(Value, provider);
		/// <inheritdoc cref="ToBoolean(IFormatProvider?)"/>
		public object ToType(Type conversionType, IFormatProvider? provider) => Convert.ChangeType(Value, conversionType, provider);
		/// <inheritdoc cref="ToBoolean(IFormatProvider?)"/>
		public ushort ToUInt16(IFormatProvider? provider) => Convert.ToUInt16(Value);
		/// <inheritdoc cref="ToBoolean(IFormatProvider?)"/>
		public uint ToUInt32(IFormatProvider? provider) => Convert.ToUInt32(Value);
		/// <inheritdoc cref="ToBoolean(IFormatProvider?)"/>
		public ulong ToUInt64(IFormatProvider? provider) => Convert.ToUInt64(Value);
		/// <inheritdoc cref="ToBoolean(IFormatProvider?)"/>
		char IConvertible.ToChar(IFormatProvider? provider) => Convert.ToChar(Value);
		/// <summary>
		/// Compares this value with another.
		/// </summary>
		/// <param name="left">The left parameter represents tha first variable to compare.</param>
		/// <param name="right">The second variable represents the second variable to compare to the first variable.</param>
		/// <returns>a <see cref="bool"/> representation of the result.</returns>
		public static bool operator ==(VString left, VString right) => left is null ? right is null : left.Equals(right);
		/// <inheritdoc cref="operator ==(VString, VString)"/>
		public static bool operator !=(VString left, VString right) => !(left==right);
		/// <inheritdoc cref="operator ==(VString, VString)"/>
		public static bool operator <(VString left, VString right) => left is null ? right is not null : left.CompareTo(right)<0;
		/// <inheritdoc cref="operator ==(VString, VString)"/>
		public static bool operator <=(VString left, VString right) => left is null||left.CompareTo(right)<=0;
		/// <inheritdoc cref="operator ==(VString, VString)"/>
		public static bool operator >(VString left, VString right) => left is not null&&left.CompareTo(right)>0;
		/// <inheritdoc cref="operator ==(VString, VString)"/>
		public static bool operator >=(VString left, VString right) => left is null ? right is null : left.CompareTo(right)>=0;


	}
}