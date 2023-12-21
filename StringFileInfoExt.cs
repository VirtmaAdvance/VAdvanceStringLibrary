using System.Text;

namespace VAdvanceStringLibrary
{
	/// <summary>
	/// Provides file information extension methods for the string class.
	/// </summary>
	public static class StringFileInfoExt
	{
		/// <summary>
		/// Determines if the file path has an extension.
		/// </summary>
		/// <param name="value"></param>
		/// <returns></returns>
		public static bool HasExtension(this string value) => value.IsFile() && Path.HasExtension(value);
		/// <summary>
		/// Gets the extension of the file.
		/// </summary>
		/// <param name="value"></param>
		/// <returns></returns>
		public static string? GetExtension(this string value) => value.HasExtension() ? Path.GetExtension(value) : null;
		/// <summary>
		/// Gets the file name (without it's extension).
		/// </summary>
		/// <param name="value"></param>
		/// <returns></returns>
		public static string? GetFileName(this string value) => value.IsFile() ? Path.GetFileNameWithoutExtension(value) : null;
		/// <summary>
		/// Gets the size of a file.
		/// </summary>
		/// <param name="value"></param>
		/// <returns></returns>
		public static long GetFileSize(this string value) => value.GetFileInfo().Length;
		/// <summary>
		/// Gets the <see cref="FileInfo"/> object.
		/// </summary>
		/// <param name="value"></param>
		/// <returns></returns>
		/// <exception cref="ArgumentException"></exception>
		public static FileInfo GetFileInfo(this string value) => value.IsFile() ? new FileInfo(value) : throw new ArgumentException("The given path does not reference an existing file path.");
		/// <summary>
		/// Deletes a file.
		/// </summary>
		/// <param name="value"></param>
		public static void DeleteFile(this string value)
		{
			if(value.IsFile())
				File.Delete(value);
		}
		/// <inheritdoc cref="CreateFile(string, byte[])"/>
		public static void CreateFile(this string value)
		{
			value.CreateFile(Array.Empty<byte>());
		}
		/// <inheritdoc cref="CreateFile(string, byte[])"/>
		public static void CreateFile(this string value, string content)
		{
			value.CreateFile(content, Encoding.Unicode);
		}
		/// <inheritdoc cref="CreateFile(string, byte[])"/>
		/// <param name="value">The file path to create.</param>
		/// <param name="content">The content to apply.</param>
		/// <param name="encoder">The encoding method.</param>
		public static void CreateFile(this string value, string content, Encoding encoder)
		{
			value.CreateFile(encoder.GetBytes(content));
		}
		/// <summary>
		/// Creates a new file.
		/// </summary>
		/// <param name="value">The file path to create.</param>
		/// <param name="content">The content to apply.</param>
		public static async void CreateFile(this string value, byte[]? content)
		{
			if(!value.IsFile())
			{
				File.Create(value);
				if(content is not null && content.Length>0)
					await File.WriteAllBytesAsync(value, content);
			}
		}

	}
}