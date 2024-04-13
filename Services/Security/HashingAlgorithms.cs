namespace VAdvanceStringLibrary.Services.Security
{
	/// <summary>
	/// Provides a list of available hashing algorithms.
	/// </summary>
	[Flags]
	public enum HashingAlgorithms : long
	{
		/// <summary>
		/// The string value is not hashed.
		/// </summary>
		Normal,
		/// <summary>
		/// A hashing algorithm.
		/// </summary>
		Md2,
		/// <inheritdoc cref="Md2"/>
		Md4,
		/// <inheritdoc cref="Md2"/>
		Md5,
		/// <inheritdoc cref="Md2"/>
		Sha1,
		/// <inheritdoc cref="Md2"/>
		Sha224,
		/// <inheritdoc cref="Md2"/>
		Sha256,
		/// <inheritdoc cref="Md2"/>
		Sha384,
		/// <inheritdoc cref="Md2"/>
		Sha512x224,
		/// <inheritdoc cref="Md2"/>
		Sha512x256,
		/// <inheritdoc cref="Md2"/>
		Sha512,
		/// <inheritdoc cref="Md2"/>
		Sha3x224,
		/// <inheritdoc cref="Md2"/>
		Sha3x256,
		/// <inheritdoc cref="Md2"/>
		Sha3x384,
		/// <inheritdoc cref="Md2"/>
		Sha3x512,
		/// <inheritdoc cref="Md2"/>
		Ripemd128,
		/// <inheritdoc cref="Md2"/>
		Ripemd160,
		/// <inheritdoc cref="Md2"/>
		Ripemd256,
		/// <inheritdoc cref="Md2"/>
		Ripemd320,
		/// <inheritdoc cref="Md2"/>
		Whirlpool,
		/// <inheritdoc cref="Md2"/>
		Tiger128x3,
		/// <inheritdoc cref="Md2"/>
		Tiger160x3,
		/// <inheritdoc cref="Md2"/>
		Tiger192x3,
		/// <inheritdoc cref="Md2"/>
		Tiger128x4,
		/// <inheritdoc cref="Md2"/>
		Tiger160x4,
		/// <inheritdoc cref="Md2"/>
		Tiger192x4,
		/// <inheritdoc cref="Md2"/>
		Snefru,
		/// <inheritdoc cref="Md2"/>
		Snefru256,
		/// <inheritdoc cref="Md2"/>
		Gost,
		/// <inheritdoc cref="Md2"/>
		GostCrypto,
		/// <inheritdoc cref="Md2"/>
		Adler32,
		/// <inheritdoc cref="Md2"/>
		Crc32,
		/// <inheritdoc cref="Md2"/>
		Crc32b,
		/// <inheritdoc cref="Md2"/>
		Crc32c,
		/// <inheritdoc cref="Md2"/>
		Fnv132,
		/// <inheritdoc cref="Md2"/>
		Fnv1a32,
		/// <inheritdoc cref="Md2"/>
		Fnv164,
		/// <inheritdoc cref="Md2"/>
		Fnv1a64,
		/// <inheritdoc cref="Md2"/>
		Joaat,
		/// <inheritdoc cref="Md2"/>
		Murmur3a,
		/// <inheritdoc cref="Md2"/>
		Murmur3c,
		/// <inheritdoc cref="Md2"/>
		Murmur3f,
		/// <inheritdoc cref="Md2"/>
		Xxh32,
		/// <inheritdoc cref="Md2"/>
		Xxh64,
		/// <inheritdoc cref="Md2"/>
		Xxh3,
		/// <inheritdoc cref="Md2"/>
		Xxh128,
		/// <inheritdoc cref="Md2"/>
		Haval128x3,
		/// <inheritdoc cref="Md2"/>
		Haval160x3,
		/// <inheritdoc cref="Md2"/>
		Haval192x3,
		/// <inheritdoc cref="Md2"/>
		Haval224x3,
		/// <inheritdoc cref="Md2"/>
		Haval256x3,
		/// <inheritdoc cref="Md2"/>
		Haval128x4,
		/// <inheritdoc cref="Md2"/>
		Haval160x4,
		/// <inheritdoc cref="Md2"/>
		Haval192x4,
		/// <inheritdoc cref="Md2"/>
		Haval224x4,
		/// <inheritdoc cref="Md2"/>
		Haval256x4,
		/// <inheritdoc cref="Md2"/>
		Haval128x5,
		/// <inheritdoc cref="Md2"/>
		Haval160x5,
		/// <inheritdoc cref="Md2"/>
		Haval192x5,
		/// <inheritdoc cref="Md2"/>
		Haval224x5,
		/// <inheritdoc cref="Md2"/>
		Haval256x5,

	}
}
