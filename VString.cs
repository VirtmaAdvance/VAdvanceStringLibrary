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
					if(InRange(index))
					{
						string beginning=Value.Substring(0, index-1);
						int calc=index+1;
						string ending=Value.Substring(calc, Length-calc);
						Value=beginning+value+ending;
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
		public VString()
		{
			Value="";
		}
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
		public static explicit operator VString(string value) => new (value);
		/// <inheritdoc cref="VString(string)"/>
		public static explicit operator VString(char value) => new (value);
		/// <summary>
		/// Determines if the <see cref="Value"/> contains the <paramref name="substringValue"/>.
		/// </summary>
		/// <param name="substringValue"></param>
		/// <returns></returns>
		public bool Contains(string substringValue) => Value.Contains(substringValue);
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
		public bool Equals(VString? other)
		{
			return (other is null && this is null) || ((other is not null && this is not null) && other.Value==Value);
		}
		/// <summary>
		/// Compares this value with another.
		/// </summary>
		/// <param name="other"></param>
		/// <returns></returns>
		public int CompareTo(VString? other)
		{
			if(other is null)
				other=new VString("");
			return Value.CompareTo(other.Value);
		}
		/// <summary>
		/// Disposes this object.
		/// </summary>
		public void Dispose()
		{
			Value="";
		}
		/// <summary>
		/// Gets the enumerator.
		/// </summary>
		/// <returns></returns>
		public IEnumerator<char> GetEnumerator()
		{
			return Value.GetEnumerator();
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return Value.GetEnumerator();
		}
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
		public override bool Equals(object? obj)
		{
			if(obj is null && this is null)
				return true;
			if(ReferenceEquals(this, obj))
			{
				return true;
			}

			if(ReferenceEquals(obj, null))
			{
				return false;
			}

			throw new NotImplementedException();
		}
		/// <summary>
		/// Gets the hash code of this object.
		/// </summary>
		/// <returns></returns>
		public override int GetHashCode()
		{
			return Value.GetHashCode();
		}
		/// <summary>
		/// Gets the <see cref="string"/> representation of the stored value.
		/// </summary>
		/// <param name="format"></param>
		/// <param name="formatProvider"></param>
		/// <returns></returns>
		public string ToString(string? format, IFormatProvider? formatProvider)
		{
			return Value.ToString(formatProvider);
		}
		/// <summary>
		/// Gets the <see cref="TypeCode"/> of the value.
		/// </summary>
		/// <returns></returns>
		public TypeCode GetTypeCode()
		{
			return Value.GetTypeCode();
		}
		/// <summary>
		/// Converts this object to a another data type.
		/// </summary>
		/// <param name="provider"></param>
		/// <returns></returns>
		public bool ToBoolean(IFormatProvider? provider)
		{
			return Length>0;
		}
		/// <inheritdoc cref="ToBoolean(IFormatProvider?)"/>
		public byte ToByte(IFormatProvider? provider)
		{
			return Convert.ToByte(Value);
		}
		/// <inheritdoc cref="ToBoolean(IFormatProvider?)"/>
		public char? ToChar(IFormatProvider? provider)
		{
			return Length>0 ? Value[0] : null;
		}
		/// <inheritdoc cref="ToBoolean(IFormatProvider?)"/>
		public DateTime ToDateTime(IFormatProvider? provider)
		{
			return DateTime.Parse(Value, provider);
		}
		/// <inheritdoc cref="ToBoolean(IFormatProvider?)"/>
		public decimal ToDecimal(IFormatProvider? provider)
		{
			return Convert.ToDecimal(Value);
		}
		/// <inheritdoc cref="ToBoolean(IFormatProvider?)"/>
		public double ToDouble(IFormatProvider? provider)
		{
			return Convert.ToDouble(Value);
		}
		/// <inheritdoc cref="ToBoolean(IFormatProvider?)"/>
		public short ToInt16(IFormatProvider? provider)
		{
			return Convert.ToInt16(Value);
		}
		/// <inheritdoc cref="ToBoolean(IFormatProvider?)"/>
		public int ToInt32(IFormatProvider? provider)
		{
			return Convert.ToInt32(Value);
		}
		/// <inheritdoc cref="ToBoolean(IFormatProvider?)"/>
		public long ToInt64(IFormatProvider? provider)
		{
			return Convert.ToInt64(Value);
		}
		/// <inheritdoc cref="ToBoolean(IFormatProvider?)"/>
		public sbyte ToSByte(IFormatProvider? provider)
		{
			return Convert.ToSByte(Value);
		}
		/// <inheritdoc cref="ToBoolean(IFormatProvider?)"/>
		public float ToSingle(IFormatProvider? provider)
		{
			return Convert.ToSingle(Value);
		}
		/// <inheritdoc cref="ToString()"/>
		public string ToString(IFormatProvider? provider)
		{
			return Convert.ToString(Value, provider);
		}/// <inheritdoc cref="ToBoolean(IFormatProvider?)"/>

		public object ToType(Type conversionType, IFormatProvider? provider)
		{
			return Convert.ChangeType(Value, conversionType, provider);
		}
		/// <inheritdoc cref="ToBoolean(IFormatProvider?)"/>
		public ushort ToUInt16(IFormatProvider? provider)
		{
			return Convert.ToUInt16(Value);
		}
		/// <inheritdoc cref="ToBoolean(IFormatProvider?)"/>
		public uint ToUInt32(IFormatProvider? provider)
		{
			return Convert.ToUInt32(Value);
		}
		/// <inheritdoc cref="ToBoolean(IFormatProvider?)"/>
		public ulong ToUInt64(IFormatProvider? provider)
		{
			return Convert.ToUInt64(Value);
		}
		/// <inheritdoc cref="ToBoolean(IFormatProvider?)"/>
		char IConvertible.ToChar(IFormatProvider? provider)
		{
			return Convert.ToChar(Value);
		}
		/// <summary>
		/// Compares this value with another.
		/// </summary>
		/// <param name="left"></param>
		/// <param name="right"></param>
		/// <returns></returns>
		public static bool operator ==(VString left, VString right)
		{
			return ReferenceEquals(left, null) ? ReferenceEquals(right, null) : left.Equals(right);
		}
		/// <inheritdoc cref="operator ==(VString, VString)"/>
		public static bool operator !=(VString left, VString right)
		{
			return !(left==right);
		}
		/// <inheritdoc cref="operator ==(VString, VString)"/>
		public static bool operator <(VString left, VString right)
		{
			return ReferenceEquals(left, null) ? !ReferenceEquals(right, null) : left.CompareTo(right)<0;
		}
		/// <inheritdoc cref="operator ==(VString, VString)"/>
		public static bool operator <=(VString left, VString right)
		{
			return ReferenceEquals(left, null)||left.CompareTo(right)<=0;
		}
		/// <inheritdoc cref="operator ==(VString, VString)"/>
		public static bool operator >(VString left, VString right)
		{
			return !ReferenceEquals(left, null)&&left.CompareTo(right)>0;
		}
		/// <inheritdoc cref="operator ==(VString, VString)"/>
		public static bool operator >=(VString left, VString right)
		{
			return ReferenceEquals(left, null) ? ReferenceEquals(right, null) : left.CompareTo(right)>=0;
		}
	}
}