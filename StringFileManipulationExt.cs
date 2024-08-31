using System.Text;
using VAdvanceStringLibrary.Services.Internals.Objects;

namespace VAdvanceStringLibrary
{
	/// <summary>
	/// Provides string extension methods for file manipulation.
	/// </summary>
	public static class StringFileManipulationExt
	{

		/// <summary>
		/// Deletes a file.
		/// </summary>
		/// <param name="value">The <see cref="string"/> representation of the file path to delete.</param>
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
				if(content is not null && content.Length > 0)
					await File.WriteAllBytesAsync(value, content);
			}
		}
		private static void PrvFileWrite(this string path, string? content, Encoding? encoder = null)
		{
			if(path.IsValid())
			{
				if(encoder.NotNull())
					File.WriteAllText(path, content, encoder!);
				else
					File.WriteAllText(path, content);
			}
		}
		private static void PrvFileWrite(this string path, byte[]? content)
		{
			if(path.IsValid())
			{
				if(content.NotNull())
					File.WriteAllBytes(path, content!);
				else
					File.WriteAllText(path, "");
			}
		}
		private static async void PrvFileWriteAsync(this string path, byte[]? content)
		{
			if(path.IsValid())
			{
				if(content.NotNull())
					await File.WriteAllBytesAsync(path, content!);
				else
					await File.WriteAllTextAsync(path, "");
			}
		}
		private static async void PrvFileWriteAsync(this string path, string? content, Encoding? encoder = null)
		{
			if(path.IsValid())
			{
				if(encoder.NotNull())
					await File.WriteAllTextAsync(path, content, encoder!);
				else
					await File.WriteAllTextAsync(path, content);
			}
		}
		/// <summary>
		/// Writes all text to the file.
		/// </summary>
		/// <param name="path">The file path.</param>
		/// <param name="content">The content to write to the file.</param>
		/// <param name="encoder">The encoding object to use.</param>
		public static void FileWrite(this string path, string? content, Encoding encoder) => PrvFileWrite(path, content, encoder);
		/// <inheritdoc cref="FileWrite(string, string, Encoding)"/>
		public static void FileWrite(this string path, string? content) => PrvFileWrite(path, content);
		/// <inheritdoc cref="FileWrite(string, string, Encoding)"/>
		public static void FileWrite(this string path, byte[]? content) => PrvFileWrite(path, content);
		/// <inheritdoc cref="FileWrite(string, string, Encoding)"/>
		public static void FileWriteAsync(this string path, byte[]? content) => PrvFileWriteAsync(path, content);
		/// <inheritdoc cref="FileWrite(string, string, Encoding)"/>
		public static void FileWriteAsync(this string path, string? content, Encoding encoder) => PrvFileWriteAsync(path, content, encoder);
		/// <inheritdoc cref="FileWrite(string, string, Encoding)"/>
		public static void FileWriteAsync(this string path, string? content) => PrvFileWriteAsync(path, content);
		/// <summary>
		/// Manipulates a file's timestamp data.
		/// </summary>
		/// <param name="path">The file path.</param>
		/// <param name="timestamp">The <see cref="DateTime"/> representation of the timestamp to set.</param>
		public static void FileSetCreationTime(this string path, DateTime timestamp) => File.SetCreationTime(path, timestamp);
		/// <inheritdoc cref="FileSetCreationTime(string, DateTime)" />
		public static void FileSetLastAccessTime(this string path, DateTime timestamp) => File.SetLastAccessTime(path, timestamp);
		/// <inheritdoc cref="FileSetCreationTime(string, DateTime)" />
		public static void FileSetLastModifiedTime(this string path, DateTime timestamp) => File.SetLastWriteTime(path, timestamp);
		/// <summary>
		/// Sets an attribute on the file.
		/// </summary>
		/// <param name="path"></param>
		/// <param name="attributes"></param>
		public static void FileSetAttributes(this string path, FileAttributes attributes) => File.SetAttributes(path, attributes);

	}
}